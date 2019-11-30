namespace arduino
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.RGB4_checkBox16 = new System.Windows.Forms.CheckBox();
            this.RGB4_checkBox15 = new System.Windows.Forms.CheckBox();
            this.RGB4_checkBox14 = new System.Windows.Forms.CheckBox();
            this.RGB4_checkBox13 = new System.Windows.Forms.CheckBox();
            this.RGB3_checkBox12 = new System.Windows.Forms.CheckBox();
            this.RGB3_checkBox11 = new System.Windows.Forms.CheckBox();
            this.RGB3_checkBox10 = new System.Windows.Forms.CheckBox();
            this.RGB3_checkBox9 = new System.Windows.Forms.CheckBox();
            this.RGB2_checkBox8 = new System.Windows.Forms.CheckBox();
            this.RGB2_checkBox7 = new System.Windows.Forms.CheckBox();
            this.RGB2_checkBox6 = new System.Windows.Forms.CheckBox();
            this.RGB2_checkBox5 = new System.Windows.Forms.CheckBox();
            this.RGB1_checkBox4 = new System.Windows.Forms.CheckBox();
            this.RGB1_checkBox3 = new System.Windows.Forms.CheckBox();
            this.RGB1_checkBox2 = new System.Windows.Forms.CheckBox();
            this.RGB1_checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(34, 816);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1177, 126);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Connection";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(729, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            this.comboBox1.MouseLeave += new System.EventHandler(this.ComboBox1_MouseLeave);
            this.comboBox1.MouseHover += new System.EventHandler(this.ComboBox1_MouseHover);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(904, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.Button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.Button1_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.RGB4_checkBox16);
            this.groupBox1.Controls.Add(this.RGB4_checkBox15);
            this.groupBox1.Controls.Add(this.RGB4_checkBox14);
            this.groupBox1.Controls.Add(this.RGB4_checkBox13);
            this.groupBox1.Controls.Add(this.RGB3_checkBox12);
            this.groupBox1.Controls.Add(this.RGB3_checkBox11);
            this.groupBox1.Controls.Add(this.RGB3_checkBox10);
            this.groupBox1.Controls.Add(this.RGB3_checkBox9);
            this.groupBox1.Controls.Add(this.RGB2_checkBox8);
            this.groupBox1.Controls.Add(this.RGB2_checkBox7);
            this.groupBox1.Controls.Add(this.RGB2_checkBox6);
            this.groupBox1.Controls.Add(this.RGB2_checkBox5);
            this.groupBox1.Controls.Add(this.RGB1_checkBox4);
            this.groupBox1.Controls.Add(this.RGB1_checkBox3);
            this.groupBox1.Controls.Add(this.RGB1_checkBox2);
            this.groupBox1.Controls.Add(this.RGB1_checkBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(34, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(879, 758);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED Control";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label15.Location = new System.Drawing.Point(594, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "Rest Room";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.Location = new System.Drawing.Point(277, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 11;
            this.label14.Text = "Bed Room";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(486, 404);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 20);
            this.label13.TabIndex = 11;
            this.label13.Text = "Living Room";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.Location = new System.Drawing.Point(155, 380);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Home Entrance";
            // 
            // RGB4_checkBox16
            // 
            this.RGB4_checkBox16.AutoSize = true;
            this.RGB4_checkBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RGB4_checkBox16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB4_checkBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB4_checkBox16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RGB4_checkBox16.Location = new System.Drawing.Point(574, 564);
            this.RGB4_checkBox16.Name = "RGB4_checkBox16";
            this.RGB4_checkBox16.Size = new System.Drawing.Size(109, 33);
            this.RGB4_checkBox16.TabIndex = 21;
            this.RGB4_checkBox16.Text = "WHITE";
            this.RGB4_checkBox16.UseVisualStyleBackColor = false;
            this.RGB4_checkBox16.CheckedChanged += new System.EventHandler(this.RGB4_checkBox16_CheckedChanged);
            // 
            // RGB4_checkBox15
            // 
            this.RGB4_checkBox15.AutoSize = true;
            this.RGB4_checkBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RGB4_checkBox15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB4_checkBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB4_checkBox15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RGB4_checkBox15.Location = new System.Drawing.Point(426, 564);
            this.RGB4_checkBox15.Name = "RGB4_checkBox15";
            this.RGB4_checkBox15.Size = new System.Drawing.Size(117, 33);
            this.RGB4_checkBox15.TabIndex = 20;
            this.RGB4_checkBox15.Text = "GREEN";
            this.RGB4_checkBox15.UseVisualStyleBackColor = false;
            this.RGB4_checkBox15.CheckedChanged += new System.EventHandler(this.RGB4_checkBox15_CheckedChanged);
            // 
            // RGB4_checkBox14
            // 
            this.RGB4_checkBox14.AutoSize = true;
            this.RGB4_checkBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RGB4_checkBox14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB4_checkBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB4_checkBox14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.RGB4_checkBox14.Location = new System.Drawing.Point(574, 472);
            this.RGB4_checkBox14.Name = "RGB4_checkBox14";
            this.RGB4_checkBox14.Size = new System.Drawing.Size(94, 33);
            this.RGB4_checkBox14.TabIndex = 19;
            this.RGB4_checkBox14.Text = "BLUE";
            this.RGB4_checkBox14.UseVisualStyleBackColor = false;
            this.RGB4_checkBox14.CheckedChanged += new System.EventHandler(this.RGB4_checkBox14_CheckedChanged);
            // 
            // RGB4_checkBox13
            // 
            this.RGB4_checkBox13.AutoSize = true;
            this.RGB4_checkBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RGB4_checkBox13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB4_checkBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB4_checkBox13.ForeColor = System.Drawing.Color.Red;
            this.RGB4_checkBox13.Location = new System.Drawing.Point(426, 472);
            this.RGB4_checkBox13.Name = "RGB4_checkBox13";
            this.RGB4_checkBox13.Size = new System.Drawing.Size(82, 33);
            this.RGB4_checkBox13.TabIndex = 18;
            this.RGB4_checkBox13.Text = "RED";
            this.RGB4_checkBox13.UseVisualStyleBackColor = false;
            this.RGB4_checkBox13.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // RGB3_checkBox12
            // 
            this.RGB3_checkBox12.AutoSize = true;
            this.RGB3_checkBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RGB3_checkBox12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB3_checkBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB3_checkBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RGB3_checkBox12.Location = new System.Drawing.Point(164, 583);
            this.RGB3_checkBox12.Name = "RGB3_checkBox12";
            this.RGB3_checkBox12.Size = new System.Drawing.Size(109, 33);
            this.RGB3_checkBox12.TabIndex = 17;
            this.RGB3_checkBox12.Text = "WHITE";
            this.RGB3_checkBox12.UseVisualStyleBackColor = false;
            this.RGB3_checkBox12.CheckedChanged += new System.EventHandler(this.RGB3_checkBox12_CheckedChanged);
            // 
            // RGB3_checkBox11
            // 
            this.RGB3_checkBox11.AutoSize = true;
            this.RGB3_checkBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RGB3_checkBox11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB3_checkBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB3_checkBox11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RGB3_checkBox11.Location = new System.Drawing.Point(164, 528);
            this.RGB3_checkBox11.Name = "RGB3_checkBox11";
            this.RGB3_checkBox11.Size = new System.Drawing.Size(117, 33);
            this.RGB3_checkBox11.TabIndex = 16;
            this.RGB3_checkBox11.Text = "GREEN";
            this.RGB3_checkBox11.UseVisualStyleBackColor = false;
            this.RGB3_checkBox11.CheckedChanged += new System.EventHandler(this.RGB3_checkBox11_CheckedChanged);
            // 
            // RGB3_checkBox10
            // 
            this.RGB3_checkBox10.AutoSize = true;
            this.RGB3_checkBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RGB3_checkBox10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB3_checkBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB3_checkBox10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.RGB3_checkBox10.Location = new System.Drawing.Point(164, 472);
            this.RGB3_checkBox10.Name = "RGB3_checkBox10";
            this.RGB3_checkBox10.Size = new System.Drawing.Size(94, 33);
            this.RGB3_checkBox10.TabIndex = 15;
            this.RGB3_checkBox10.Text = "BLUE";
            this.RGB3_checkBox10.UseVisualStyleBackColor = false;
            this.RGB3_checkBox10.CheckedChanged += new System.EventHandler(this.RGB3_checkBox10_CheckedChanged);
            // 
            // RGB3_checkBox9
            // 
            this.RGB3_checkBox9.AutoSize = true;
            this.RGB3_checkBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RGB3_checkBox9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB3_checkBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB3_checkBox9.ForeColor = System.Drawing.Color.Red;
            this.RGB3_checkBox9.Location = new System.Drawing.Point(164, 421);
            this.RGB3_checkBox9.Name = "RGB3_checkBox9";
            this.RGB3_checkBox9.Size = new System.Drawing.Size(82, 33);
            this.RGB3_checkBox9.TabIndex = 14;
            this.RGB3_checkBox9.Text = "RED";
            this.RGB3_checkBox9.UseVisualStyleBackColor = false;
            this.RGB3_checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // RGB2_checkBox8
            // 
            this.RGB2_checkBox8.AutoSize = true;
            this.RGB2_checkBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RGB2_checkBox8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB2_checkBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB2_checkBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RGB2_checkBox8.Location = new System.Drawing.Point(598, 251);
            this.RGB2_checkBox8.Name = "RGB2_checkBox8";
            this.RGB2_checkBox8.Size = new System.Drawing.Size(109, 33);
            this.RGB2_checkBox8.TabIndex = 13;
            this.RGB2_checkBox8.Text = "WHITE";
            this.RGB2_checkBox8.UseVisualStyleBackColor = false;
            this.RGB2_checkBox8.CheckedChanged += new System.EventHandler(this.RGB2_checkBox8_CheckedChanged);
            // 
            // RGB2_checkBox7
            // 
            this.RGB2_checkBox7.AutoSize = true;
            this.RGB2_checkBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RGB2_checkBox7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB2_checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB2_checkBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RGB2_checkBox7.Location = new System.Drawing.Point(598, 212);
            this.RGB2_checkBox7.Name = "RGB2_checkBox7";
            this.RGB2_checkBox7.Size = new System.Drawing.Size(117, 33);
            this.RGB2_checkBox7.TabIndex = 12;
            this.RGB2_checkBox7.Text = "GREEN";
            this.RGB2_checkBox7.UseVisualStyleBackColor = false;
            this.RGB2_checkBox7.CheckedChanged += new System.EventHandler(this.RGB2_checkBox7_CheckedChanged);
            // 
            // RGB2_checkBox6
            // 
            this.RGB2_checkBox6.AutoSize = true;
            this.RGB2_checkBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RGB2_checkBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB2_checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB2_checkBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.RGB2_checkBox6.Location = new System.Drawing.Point(598, 173);
            this.RGB2_checkBox6.Name = "RGB2_checkBox6";
            this.RGB2_checkBox6.Size = new System.Drawing.Size(94, 33);
            this.RGB2_checkBox6.TabIndex = 11;
            this.RGB2_checkBox6.Text = "BLUE";
            this.RGB2_checkBox6.UseVisualStyleBackColor = false;
            this.RGB2_checkBox6.CheckedChanged += new System.EventHandler(this.RGB2_checkBox6_CheckedChanged);
            // 
            // RGB2_checkBox5
            // 
            this.RGB2_checkBox5.AutoSize = true;
            this.RGB2_checkBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RGB2_checkBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB2_checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB2_checkBox5.ForeColor = System.Drawing.Color.Red;
            this.RGB2_checkBox5.Location = new System.Drawing.Point(598, 134);
            this.RGB2_checkBox5.Name = "RGB2_checkBox5";
            this.RGB2_checkBox5.Size = new System.Drawing.Size(82, 33);
            this.RGB2_checkBox5.TabIndex = 10;
            this.RGB2_checkBox5.Text = "RED";
            this.RGB2_checkBox5.UseVisualStyleBackColor = false;
            this.RGB2_checkBox5.CheckedChanged += new System.EventHandler(this.RGB2_checkBox5_CheckedChanged);
            // 
            // RGB1_checkBox4
            // 
            this.RGB1_checkBox4.AutoSize = true;
            this.RGB1_checkBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RGB1_checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB1_checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB1_checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RGB1_checkBox4.Location = new System.Drawing.Point(440, 197);
            this.RGB1_checkBox4.Name = "RGB1_checkBox4";
            this.RGB1_checkBox4.Size = new System.Drawing.Size(109, 33);
            this.RGB1_checkBox4.TabIndex = 9;
            this.RGB1_checkBox4.Text = "WHITE";
            this.RGB1_checkBox4.UseVisualStyleBackColor = false;
            this.RGB1_checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // RGB1_checkBox3
            // 
            this.RGB1_checkBox3.AutoSize = true;
            this.RGB1_checkBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RGB1_checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB1_checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB1_checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.RGB1_checkBox3.Location = new System.Drawing.Point(219, 197);
            this.RGB1_checkBox3.Name = "RGB1_checkBox3";
            this.RGB1_checkBox3.Size = new System.Drawing.Size(94, 33);
            this.RGB1_checkBox3.TabIndex = 7;
            this.RGB1_checkBox3.Text = "BLUE";
            this.RGB1_checkBox3.UseVisualStyleBackColor = false;
            this.RGB1_checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // RGB1_checkBox2
            // 
            this.RGB1_checkBox2.AutoSize = true;
            this.RGB1_checkBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RGB1_checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB1_checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB1_checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RGB1_checkBox2.Location = new System.Drawing.Point(317, 197);
            this.RGB1_checkBox2.Name = "RGB1_checkBox2";
            this.RGB1_checkBox2.Size = new System.Drawing.Size(117, 33);
            this.RGB1_checkBox2.TabIndex = 6;
            this.RGB1_checkBox2.Text = "GREEN";
            this.RGB1_checkBox2.UseVisualStyleBackColor = false;
            this.RGB1_checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // RGB1_checkBox1
            // 
            this.RGB1_checkBox1.AutoSize = true;
            this.RGB1_checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RGB1_checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RGB1_checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.RGB1_checkBox1.ForeColor = System.Drawing.Color.Red;
            this.RGB1_checkBox1.Location = new System.Drawing.Point(131, 197);
            this.RGB1_checkBox1.Name = "RGB1_checkBox1";
            this.RGB1_checkBox1.Size = new System.Drawing.Size(82, 33);
            this.RGB1_checkBox1.TabIndex = 5;
            this.RGB1_checkBox1.Text = "RED";
            this.RGB1_checkBox1.UseVisualStyleBackColor = false;
            this.RGB1_checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(782, 695);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 962);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1237, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1237, 28);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkToolStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // linkToolStripMenuItem
            // 
            this.linkToolStripMenuItem.Name = "linkToolStripMenuItem";
            this.linkToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.linkToolStripMenuItem.Text = "Link";
            this.linkToolStripMenuItem.Click += new System.EventHandler(this.LinkToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(139, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripMenuItem.Image")));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox3.Location = new System.Drawing.Point(938, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 434);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            this.groupBox3.Enter += new System.EventHandler(this.GroupBox3_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(59, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 32);
            this.label11.TabIndex = 10;
            this.label11.Text = "OFF";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.Location = new System.Drawing.Point(180, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 32);
            this.label10.TabIndex = 9;
            this.label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(59, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 32);
            this.label9.TabIndex = 8;
            this.label9.Text = "OFF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(158, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "RED";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(59, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "ON";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(158, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "RED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(59, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "ON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(92, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rest Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(92, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bed Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(84, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Living Room";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(74, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Entrance";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(940, 509);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(248, 230);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.Location = new System.Drawing.Point(935, 759);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(251, 25);
            this.label16.TabIndex = 19;
            this.label16.Text = "Copyright © GTF Company";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1237, 984);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "SmartHome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox RGB1_checkBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox RGB1_checkBox2;
        private System.Windows.Forms.CheckBox RGB1_checkBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox RGB1_checkBox4;
        private System.Windows.Forms.CheckBox RGB2_checkBox8;
        private System.Windows.Forms.CheckBox RGB2_checkBox7;
        private System.Windows.Forms.CheckBox RGB2_checkBox6;
        private System.Windows.Forms.CheckBox RGB2_checkBox5;
        private System.Windows.Forms.CheckBox RGB4_checkBox16;
        private System.Windows.Forms.CheckBox RGB4_checkBox15;
        private System.Windows.Forms.CheckBox RGB4_checkBox14;
        private System.Windows.Forms.CheckBox RGB4_checkBox13;
        private System.Windows.Forms.CheckBox RGB3_checkBox12;
        private System.Windows.Forms.CheckBox RGB3_checkBox11;
        private System.Windows.Forms.CheckBox RGB3_checkBox10;
        private System.Windows.Forms.CheckBox RGB3_checkBox9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem linkToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

