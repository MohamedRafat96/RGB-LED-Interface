using ArduinoUploader;
using ArduinoUploader.Hardware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace RGB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string connect;
        public void Connection()
        {
            connect = Convert.ToString(comboBox1.SelectedItem);
            serialPort1.PortName = connect;
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;


        }
        public void red_only()
        {
          

            int RED1, GREEN1, BLUE1;

            RED1 = 255;
            GREEN1 = 0;
            BLUE1 = 0;
          
            Color DIM1 = Color.FromArgb(RED1, GREEN1, BLUE1);
            this.SetColor(DIM1);

            
            



        }
        public void green_only()
        {

            

            int RED2, GREEN2, BLUE2;

            RED2 = 0;
            GREEN2 = 255;
            BLUE2 = 0;

            Color DIM2 = Color.FromArgb(RED2, GREEN2, BLUE2);
            this.SetColor(DIM2);
           

        }
        public void blue_only()
        {


            int RED3, GREEN3, BLUE3;

            RED3 = 0;
            GREEN3 = 0;
            BLUE3 = 255;

            Color DIM3 = Color.FromArgb(RED3, GREEN3, BLUE3);
            this.SetColor(DIM3);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //groupBox1
            trackBar_red.Enabled = false;
            trackBar_green.Enabled = false;
            trackBar_blue.Enabled = false;

            textBox_red.Enabled = false;
            textBox_green.Enabled = false;
            textBox_blue.Enabled = false;

            button_random_stop.Enabled = false;

            //groupBox2
            button_random.Enabled = false;
            button_stop_reset.Enabled = false;
            button4.Enabled = false;

            try
            {

                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    comboBox1.Items.Add(port);

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "Error", MessageBoxButtons.OK , MessageBoxIcon.Error);
            }



        }
        int mousex = 0, mousey = 0;
        bool mousedown;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mousex = MousePosition.X - 200;
                mousey = MousePosition.Y - 40;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Connection();
               
                MessageBox.Show("Connection Succeeded", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                    //groupBox1
                    trackBar_red.Enabled = true;
                    trackBar_green.Enabled = true;
                    trackBar_blue.Enabled = true;

                    textBox_red.Enabled = true;
                    textBox_green.Enabled = true;
                    textBox_blue.Enabled = true;
                    button_random_stop.Enabled = true;

                    //groupBox2        
                    button_random.Enabled = true;
                    button_stop_reset.Enabled = true;
                    button4.Enabled = true;
                

                timer1.Start();



            }
            catch (Exception ex)
            {
               

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to close the program?","Exit",MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if(Result == DialogResult.Yes)
            {
                Application.Exit();
            }
           else if (Result == DialogResult.No)
            {

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Connection();
            textBox_red.Text = Convert.ToString(trackBar_red.Value);
            textBox_green.Text = Convert.ToString(trackBar_green.Value);
            textBox_blue.Text = Convert.ToString(trackBar_blue.Value);

            int RED, GREEN, BLUE;

            RED = Convert.ToInt32(textBox_red.Text);
            GREEN = Convert.ToInt32(textBox_green.Text);
            BLUE = Convert.ToInt32(textBox_blue.Text);

            Color DIM3 = Color.FromArgb(RED, GREEN, BLUE);
            this.SetColor(DIM3);

            Si_Red.BackColor = Color.FromArgb(RED, 0, 0);
            Si_Green.BackColor = Color.FromArgb(0, GREEN, 0);
            Si_Blue.BackColor = Color.FromArgb(0, 0, BLUE);
           
        }

        private void SetColor(Color color)
        {
            
            Connection();
            serialPort1.Open();
            // Update color in the panel
            panel2.BackColor = color;

            // Write color to Arduino
          serialPort1.Write(new[] { color.R, color.G, color.B }, 0, 3);
            serialPort1.Close();

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_stop_random_Click(object sender, EventArgs e)
        {
            checkBox_random.CheckState = CheckState.Unchecked;
            trackBar_red.Value = 0;
            trackBar_green.Value = 0;
            trackBar_blue.Value = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = Convert.ToString(comboBox1.SelectedItem);
                string path = System.IO.Directory.GetCurrentDirectory();
                string pathino = path + "\\" + "LEDRGB.ino.hex";
                var uploader = new ArduinoSketchUploader(
                    new ArduinoSketchUploaderOptions()
                    {
                        FileName = pathino,
                        PortName = connect,
                        ArduinoModel = ArduinoModel.UnoR3

                    });
                uploader.UploadSketch();
                MessageBox.Show("Upload Done!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message , "Warning", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                timer2.Stop();
               timer3.Stop();
                serialPort1.Close();
              

                checkBox_random.CheckState = CheckState.Unchecked;
                trackBar_red.Value = 0;
                trackBar_green.Value = 0;
                trackBar_blue.Value = 0;

                string connect = Convert.ToString(comboBox1.SelectedItem);
                string path = System.IO.Directory.GetCurrentDirectory();
                string pathino = path + "\\" + "LEDRGB.ino.hex";
                var uploader = new ArduinoSketchUploader(
                    new ArduinoSketchUploaderOptions()
                    {
                        FileName = pathino,
                        PortName = connect,
                        ArduinoModel = ArduinoModel.UnoR3

                    });
                uploader.UploadSketch();
                //MessageBox.Show("Upload Done!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
               
                Random r = new Random();
                trackBar_red.Value = r.Next(0, 255);
                trackBar_green.Value = r.Next(0, 255);
                trackBar_blue.Value = r.Next(0, 255);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_random_Click(object sender, EventArgs e)
        {
            
            try
            {
               
                if (checkBox_random.Checked)
                {
                    string interval = Convert.ToString(comboBox2.SelectedItem);
                    timer1.Interval = Convert.ToInt32(interval);
                    timer2.Start();
                }
                else
                {
                    Random r = new Random();
                    trackBar_red.Value = r.Next(0, 255);
                    trackBar_green.Value = r.Next(0, 255);
                    trackBar_blue.Value = r.Next(0, 255);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();

            Si_Red.BackColor = Color.Red;
            Si_Green.BackColor = Color.Green;
            Si_Blue.BackColor = Color.Blue;

            timer3.Start();




        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            trackBar_red.Value = 255;
            textBox_red.Text = "255";
            trackBar_green.Value = 0;
            textBox_green.Text = "0";
            trackBar_blue.Value = 0;
            textBox_blue.Text = "0";
           

            red_only();
      

            Thread.Sleep(3000);

            trackBar_red.Value = 0;
            textBox_red.Text = "0";
            trackBar_green.Value = 255;
            textBox_green.Text = "255";
            trackBar_blue.Value = 0;
            textBox_blue.Text = "0";
            green_only();
          

            Thread.Sleep(3000);

            trackBar_red.Value = 0;
            textBox_red.Text = "0";
            trackBar_green.Value = 0;
            textBox_green.Text = "0";
            trackBar_blue.Value = 255;
            textBox_blue.Text = "255";
            blue_only();
         

            Thread.Sleep(3000);

            //Color DIM11 = Color.FromArgb(0, 0, 0);
            //this.SetColor(DIM11);
            //Si_Red.BackColor = Color.FromArgb(0, 0, 0);


            //int RED1, GREEN1, BLUE1;

            //RED1 = 255;
            //GREEN1 = 0;
            //BLUE1 = 0;

            //Color DIM1 = Color.FromArgb(RED1, GREEN1, BLUE1);
            //this.SetColor(DIM1);
            //Si_Red.BackColor = Color.FromArgb(RED1, 0, 0);

            //Thread.Sleep(2000);


            //Color DIM111 = Color.FromArgb(0, 0, 0);
            //this.SetColor(DIM111);
            //Si_Red.BackColor = Color.FromArgb(0, 0, 0);

            //int RED2, GREEN2, BLUE2;

            //RED2 = 0;
            //GREEN2 = 255;
            //BLUE2 = 0;

            //Color DIM2 = Color.FromArgb(RED2, GREEN2, BLUE2);
            //this.SetColor(DIM2);

            //Thread.Sleep(2000);


            //Color DIM1111 = Color.FromArgb(0, 0, 0);
            //this.SetColor(DIM1111);
            //Si_Red.BackColor = Color.FromArgb(0, 0, 0);
            //int RED3, GREEN3, BLUE3;

            //RED3 = 0;
            //GREEN3 = 0;
            //BLUE3 = 255;

            //Color DIM3 = Color.FromArgb(RED3, GREEN3, BLUE3);
            //this.SetColor(DIM3);

            //Thread.Sleep(2000);

        }

        private void button9_Click(object sender, EventArgs e)
        {
           

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                mousex = MousePosition.X - 200;
                mousey = MousePosition.Y - 40;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

       
    }
}
