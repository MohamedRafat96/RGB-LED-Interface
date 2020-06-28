namespace RGB
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Si_Blue = new System.Windows.Forms.Panel();
            this.Si_Green = new System.Windows.Forms.Panel();
            this.Si_Red = new System.Windows.Forms.Panel();
            this.trackBar_blue = new System.Windows.Forms.TrackBar();
            this.trackBar_green = new System.Windows.Forms.TrackBar();
            this.trackBar_red = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_red = new System.Windows.Forms.TextBox();
            this.textBox_blue = new System.Windows.Forms.TextBox();
            this.textBox_green = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button_random_stop = new System.Windows.Forms.Button();
            this.button_random = new System.Windows.Forms.Button();
            this.button_stop_reset = new System.Windows.Forms.Button();
            this.checkBox_random = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.Maroon;
            this.header.Controls.Add(this.button3);
            this.header.Controls.Add(this.label1);
            this.header.Controls.Add(this.button2);
            this.header.Controls.Add(this.button1);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(473, 24);
            this.header.TabIndex = 0;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Engravers MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "LED_RGB (BY : Mohamed Raafat ) ";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // Si_Blue
            // 
            this.Si_Blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Si_Blue.Location = new System.Drawing.Point(358, 187);
            this.Si_Blue.Name = "Si_Blue";
            this.Si_Blue.Size = new System.Drawing.Size(103, 64);
            this.Si_Blue.TabIndex = 0;
            // 
            // Si_Green
            // 
            this.Si_Green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Si_Green.Location = new System.Drawing.Point(358, 117);
            this.Si_Green.Name = "Si_Green";
            this.Si_Green.Size = new System.Drawing.Size(103, 64);
            this.Si_Green.TabIndex = 0;
            // 
            // Si_Red
            // 
            this.Si_Red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Si_Red.Location = new System.Drawing.Point(358, 47);
            this.Si_Red.Name = "Si_Red";
            this.Si_Red.Size = new System.Drawing.Size(103, 64);
            this.Si_Red.TabIndex = 0;
            // 
            // trackBar_blue
            // 
            this.trackBar_blue.LargeChange = 1;
            this.trackBar_blue.Location = new System.Drawing.Point(45, 120);
            this.trackBar_blue.Maximum = 255;
            this.trackBar_blue.Name = "trackBar_blue";
            this.trackBar_blue.Size = new System.Drawing.Size(340, 45);
            this.trackBar_blue.TabIndex = 2;
            // 
            // trackBar_green
            // 
            this.trackBar_green.LargeChange = 1;
            this.trackBar_green.Location = new System.Drawing.Point(45, 69);
            this.trackBar_green.Maximum = 255;
            this.trackBar_green.Name = "trackBar_green";
            this.trackBar_green.Size = new System.Drawing.Size(340, 45);
            this.trackBar_green.TabIndex = 3;
            // 
            // trackBar_red
            // 
            this.trackBar_red.LargeChange = 1;
            this.trackBar_red.Location = new System.Drawing.Point(45, 24);
            this.trackBar_red.Maximum = 255;
            this.trackBar_red.Name = "trackBar_red";
            this.trackBar_red.Size = new System.Drawing.Size(340, 45);
            this.trackBar_red.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "B";
            // 
            // textBox_red
            // 
            this.textBox_red.BackColor = System.Drawing.Color.Red;
            this.textBox_red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_red.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_red.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_red.Location = new System.Drawing.Point(399, 24);
            this.textBox_red.Multiline = true;
            this.textBox_red.Name = "textBox_red";
            this.textBox_red.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_red.Size = new System.Drawing.Size(44, 26);
            this.textBox_red.TabIndex = 8;
            this.textBox_red.Text = "0";
            this.textBox_red.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_blue
            // 
            this.textBox_blue.BackColor = System.Drawing.Color.Blue;
            this.textBox_blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_blue.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_blue.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_blue.Location = new System.Drawing.Point(399, 120);
            this.textBox_blue.Multiline = true;
            this.textBox_blue.Name = "textBox_blue";
            this.textBox_blue.Size = new System.Drawing.Size(44, 26);
            this.textBox_blue.TabIndex = 9;
            this.textBox_blue.Text = "0";
            this.textBox_blue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_green
            // 
            this.textBox_green.BackColor = System.Drawing.Color.Green;
            this.textBox_green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_green.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_green.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_green.Location = new System.Drawing.Point(399, 69);
            this.textBox_green.Multiline = true;
            this.textBox_green.Name = "textBox_green";
            this.textBox_green.Size = new System.Drawing.Size(44, 26);
            this.textBox_green.TabIndex = 10;
            this.textBox_green.Text = "0";
            this.textBox_green.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_blue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_green);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_red);
            this.groupBox1.Controls.Add(this.trackBar_blue);
            this.groupBox1.Controls.Add(this.trackBar_green);
            this.groupBox1.Controls.Add(this.trackBar_red);
            this.groupBox1.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 169);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COLOR CONTROL";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.button_random_stop);
            this.groupBox2.Controls.Add(this.button_random);
            this.groupBox2.Controls.Add(this.button_stop_reset);
            this.groupBox2.Controls.Add(this.checkBox_random);
            this.groupBox2.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 80);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPTIONS";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Aqua;
            this.button4.Location = new System.Drawing.Point(212, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 37);
            this.button4.TabIndex = 16;
            this.button4.Text = "RGB";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox2.DisplayMember = "100";
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.Color.Aqua;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000"});
            this.comboBox2.Location = new System.Drawing.Point(11, 49);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(75, 34);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.Text = "100";
            this.comboBox2.ValueMember = "100";
            // 
            // button_random_stop
            // 
            this.button_random_stop.BackColor = System.Drawing.Color.Black;
            this.button_random_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_random_stop.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_random_stop.FlatAppearance.BorderSize = 3;
            this.button_random_stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_random_stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_random_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_random_stop.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_random_stop.ForeColor = System.Drawing.Color.Red;
            this.button_random_stop.Location = new System.Drawing.Point(295, 24);
            this.button_random_stop.Name = "button_random_stop";
            this.button_random_stop.Size = new System.Drawing.Size(66, 37);
            this.button_random_stop.TabIndex = 3;
            this.button_random_stop.Text = "STOP";
            this.button_random_stop.UseVisualStyleBackColor = false;
            this.button_random_stop.Click += new System.EventHandler(this.button4_Click);
            // 
            // button_random
            // 
            this.button_random.BackColor = System.Drawing.Color.Black;
            this.button_random.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_random.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_random.FlatAppearance.BorderSize = 3;
            this.button_random.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_random.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_random.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_random.ForeColor = System.Drawing.Color.Aqua;
            this.button_random.Location = new System.Drawing.Point(112, 24);
            this.button_random.Name = "button_random";
            this.button_random.Size = new System.Drawing.Size(94, 37);
            this.button_random.TabIndex = 2;
            this.button_random.Text = "RANDOM";
            this.button_random.UseVisualStyleBackColor = false;
            this.button_random.Click += new System.EventHandler(this.button_random_Click);
            // 
            // button_stop_reset
            // 
            this.button_stop_reset.BackColor = System.Drawing.Color.Black;
            this.button_stop_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_stop_reset.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button_stop_reset.FlatAppearance.BorderSize = 3;
            this.button_stop_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_stop_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_stop_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_stop_reset.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_stop_reset.ForeColor = System.Drawing.Color.DarkViolet;
            this.button_stop_reset.Location = new System.Drawing.Point(367, 24);
            this.button_stop_reset.Name = "button_stop_reset";
            this.button_stop_reset.Size = new System.Drawing.Size(76, 37);
            this.button_stop_reset.TabIndex = 1;
            this.button_stop_reset.Text = "RESET";
            this.button_stop_reset.UseVisualStyleBackColor = false;
            this.button_stop_reset.Click += new System.EventHandler(this.button_stop_random_Click);
            // 
            // checkBox_random
            // 
            this.checkBox_random.AutoSize = true;
            this.checkBox_random.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_random.ForeColor = System.Drawing.Color.Aqua;
            this.checkBox_random.Location = new System.Drawing.Point(11, 22);
            this.checkBox_random.Name = "checkBox_random";
            this.checkBox_random.Size = new System.Drawing.Size(75, 30);
            this.checkBox_random.TabIndex = 0;
            this.checkBox_random.Text = "AUTO ";
            this.checkBox_random.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 518);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 68);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SERIAL COMMUNICATION";
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button8.FlatAppearance.BorderSize = 3;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(166)))));
            this.button8.Location = new System.Drawing.Point(362, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 34);
            this.button8.TabIndex = 3;
            this.button8.Text = "Arduino";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(124, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 34);
            this.button7.TabIndex = 2;
            this.button7.Text = "CONNECT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(232, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 34);
            this.button6.TabIndex = 1;
            this.button6.Text = "DISCONEECT";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 34);
            this.comboBox1.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Maroon;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Simplified Arabic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.GhostWhite;
            this.button9.Location = new System.Drawing.Point(12, 590);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(449, 36);
            this.button9.TabIndex = 14;
            this.button9.Text = "ABOUT";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(12, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 204);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.BackgroundImage = global::RGB.Properties.Resources.Picasa_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(3, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(408, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 24);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(441, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 24);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(473, 628);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Si_Blue);
            this.Controls.Add(this.Si_Green);
            this.Controls.Add(this.Si_Red);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_red)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Si_Blue;
        private System.Windows.Forms.Panel Si_Green;
        private System.Windows.Forms.Panel Si_Red;
        private System.Windows.Forms.TrackBar trackBar_blue;
        private System.Windows.Forms.TrackBar trackBar_green;
        private System.Windows.Forms.TrackBar trackBar_red;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_red;
        private System.Windows.Forms.TextBox textBox_blue;
        private System.Windows.Forms.TextBox textBox_green;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_random;
        private System.Windows.Forms.Button button_stop_reset;
        private System.Windows.Forms.CheckBox checkBox_random;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_random_stop;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer3;
    }
}

