namespace ModBus
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_port_switch = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.X7 = new System.Windows.Forms.CheckBox();
            this.X16 = new System.Windows.Forms.CheckBox();
            this.X1 = new System.Windows.Forms.CheckBox();
            this.X15 = new System.Windows.Forms.CheckBox();
            this.X2 = new System.Windows.Forms.CheckBox();
            this.X14 = new System.Windows.Forms.CheckBox();
            this.X3 = new System.Windows.Forms.CheckBox();
            this.X13 = new System.Windows.Forms.CheckBox();
            this.X4 = new System.Windows.Forms.CheckBox();
            this.X12 = new System.Windows.Forms.CheckBox();
            this.X5 = new System.Windows.Forms.CheckBox();
            this.X11 = new System.Windows.Forms.CheckBox();
            this.X6 = new System.Windows.Forms.CheckBox();
            this.X10 = new System.Windows.Forms.CheckBox();
            this.X8 = new System.Windows.Forms.CheckBox();
            this.X9 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Y7 = new System.Windows.Forms.CheckBox();
            this.Y16 = new System.Windows.Forms.CheckBox();
            this.Y1 = new System.Windows.Forms.CheckBox();
            this.Y15 = new System.Windows.Forms.CheckBox();
            this.Y2 = new System.Windows.Forms.CheckBox();
            this.Y14 = new System.Windows.Forms.CheckBox();
            this.Y3 = new System.Windows.Forms.CheckBox();
            this.Y13 = new System.Windows.Forms.CheckBox();
            this.Y4 = new System.Windows.Forms.CheckBox();
            this.Y12 = new System.Windows.Forms.CheckBox();
            this.Y5 = new System.Windows.Forms.CheckBox();
            this.Y11 = new System.Windows.Forms.CheckBox();
            this.Y6 = new System.Windows.Forms.CheckBox();
            this.Y10 = new System.Windows.Forms.CheckBox();
            this.Y8 = new System.Windows.Forms.CheckBox();
            this.Y9 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.IO监控 = new System.Windows.Forms.TabPage();
            this.串口监视 = new System.Windows.Forms.TabPage();
            this.十六进制发送 = new System.Windows.Forms.GroupBox();
            this.textbox_16 = new System.Windows.Forms.TextBox();
            this.ASCII发送 = new System.Windows.Forms.GroupBox();
            this.textbox_ascii = new System.Windows.Forms.TextBox();
            this.CRC发送 = new System.Windows.Forms.TabPage();
            this.BCC发送 = new System.Windows.Forms.TabPage();
            this.log_txt = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Btn_ClearData = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.IO监控.SuspendLayout();
            this.串口监视.SuspendLayout();
            this.十六进制发送.SuspendLayout();
            this.ASCII发送.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_port_switch);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(350, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // Btn_port_switch
            // 
            this.Btn_port_switch.Location = new System.Drawing.Point(86, 185);
            this.Btn_port_switch.Name = "Btn_port_switch";
            this.Btn_port_switch.Size = new System.Drawing.Size(105, 29);
            this.Btn_port_switch.TabIndex = 0;
            this.Btn_port_switch.Text = "打开串口";
            this.Btn_port_switch.Click += new System.EventHandler(this.Btn_port_switch_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(105, 23);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "串口操作";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(86, 90);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(105, 23);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(86, 122);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(105, 23);
            this.comboBox4.TabIndex = 8;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "校验位";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(86, 154);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(105, 23);
            this.comboBox5.TabIndex = 9;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "停止位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "波特率";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.X7);
            this.groupBox2.Controls.Add(this.X16);
            this.groupBox2.Controls.Add(this.X1);
            this.groupBox2.Controls.Add(this.X15);
            this.groupBox2.Controls.Add(this.X2);
            this.groupBox2.Controls.Add(this.X14);
            this.groupBox2.Controls.Add(this.X3);
            this.groupBox2.Controls.Add(this.X13);
            this.groupBox2.Controls.Add(this.X4);
            this.groupBox2.Controls.Add(this.X12);
            this.groupBox2.Controls.Add(this.X5);
            this.groupBox2.Controls.Add(this.X11);
            this.groupBox2.Controls.Add(this.X6);
            this.groupBox2.Controls.Add(this.X10);
            this.groupBox2.Controls.Add(this.X8);
            this.groupBox2.Controls.Add(this.X9);
            this.groupBox2.Location = new System.Drawing.Point(15, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 269);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "输入监视";
            // 
            // X7
            // 
            this.X7.AutoSize = true;
            this.X7.Location = new System.Drawing.Point(6, 204);
            this.X7.Name = "X7";
            this.X7.Size = new System.Drawing.Size(45, 19);
            this.X7.TabIndex = 8;
            this.X7.Text = "X7";
            this.X7.UseVisualStyleBackColor = true;
            // 
            // X16
            // 
            this.X16.AutoSize = true;
            this.X16.Location = new System.Drawing.Point(65, 234);
            this.X16.Name = "X16";
            this.X16.Size = new System.Drawing.Size(53, 19);
            this.X16.TabIndex = 17;
            this.X16.Text = "X16";
            this.X16.UseVisualStyleBackColor = true;
            // 
            // X1
            // 
            this.X1.AutoSize = true;
            this.X1.Location = new System.Drawing.Point(6, 24);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(45, 19);
            this.X1.TabIndex = 2;
            this.X1.Text = "X1";
            this.X1.UseVisualStyleBackColor = true;
            // 
            // X15
            // 
            this.X15.AutoSize = true;
            this.X15.Location = new System.Drawing.Point(65, 204);
            this.X15.Name = "X15";
            this.X15.Size = new System.Drawing.Size(53, 19);
            this.X15.TabIndex = 16;
            this.X15.Text = "X15";
            this.X15.UseVisualStyleBackColor = true;
            // 
            // X2
            // 
            this.X2.AutoSize = true;
            this.X2.Location = new System.Drawing.Point(6, 54);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(45, 19);
            this.X2.TabIndex = 3;
            this.X2.Text = "X2";
            this.X2.UseVisualStyleBackColor = true;
            // 
            // X14
            // 
            this.X14.AutoSize = true;
            this.X14.Location = new System.Drawing.Point(65, 174);
            this.X14.Name = "X14";
            this.X14.Size = new System.Drawing.Size(53, 19);
            this.X14.TabIndex = 15;
            this.X14.Text = "X14";
            this.X14.UseVisualStyleBackColor = true;
            // 
            // X3
            // 
            this.X3.AutoSize = true;
            this.X3.Location = new System.Drawing.Point(6, 84);
            this.X3.Name = "X3";
            this.X3.Size = new System.Drawing.Size(45, 19);
            this.X3.TabIndex = 4;
            this.X3.Text = "X3";
            this.X3.UseVisualStyleBackColor = true;
            // 
            // X13
            // 
            this.X13.AutoSize = true;
            this.X13.Location = new System.Drawing.Point(65, 144);
            this.X13.Name = "X13";
            this.X13.Size = new System.Drawing.Size(53, 19);
            this.X13.TabIndex = 14;
            this.X13.Text = "X13";
            this.X13.UseVisualStyleBackColor = true;
            // 
            // X4
            // 
            this.X4.AutoSize = true;
            this.X4.Location = new System.Drawing.Point(6, 114);
            this.X4.Name = "X4";
            this.X4.Size = new System.Drawing.Size(45, 19);
            this.X4.TabIndex = 5;
            this.X4.Text = "X4";
            this.X4.UseVisualStyleBackColor = true;
            // 
            // X12
            // 
            this.X12.AutoSize = true;
            this.X12.Location = new System.Drawing.Point(65, 114);
            this.X12.Name = "X12";
            this.X12.Size = new System.Drawing.Size(53, 19);
            this.X12.TabIndex = 13;
            this.X12.Text = "X12";
            this.X12.UseVisualStyleBackColor = true;
            // 
            // X5
            // 
            this.X5.AutoSize = true;
            this.X5.Location = new System.Drawing.Point(6, 144);
            this.X5.Name = "X5";
            this.X5.Size = new System.Drawing.Size(45, 19);
            this.X5.TabIndex = 6;
            this.X5.Text = "X5";
            this.X5.UseVisualStyleBackColor = true;
            // 
            // X11
            // 
            this.X11.AutoSize = true;
            this.X11.Location = new System.Drawing.Point(65, 84);
            this.X11.Name = "X11";
            this.X11.Size = new System.Drawing.Size(53, 19);
            this.X11.TabIndex = 12;
            this.X11.Text = "X11";
            this.X11.UseVisualStyleBackColor = true;
            // 
            // X6
            // 
            this.X6.AutoSize = true;
            this.X6.Location = new System.Drawing.Point(6, 174);
            this.X6.Name = "X6";
            this.X6.Size = new System.Drawing.Size(45, 19);
            this.X6.TabIndex = 7;
            this.X6.Text = "X6";
            this.X6.UseVisualStyleBackColor = true;
            // 
            // X10
            // 
            this.X10.AutoSize = true;
            this.X10.Location = new System.Drawing.Point(65, 54);
            this.X10.Name = "X10";
            this.X10.Size = new System.Drawing.Size(53, 19);
            this.X10.TabIndex = 11;
            this.X10.Text = "X10";
            this.X10.UseVisualStyleBackColor = true;
            // 
            // X8
            // 
            this.X8.AutoSize = true;
            this.X8.Location = new System.Drawing.Point(6, 234);
            this.X8.Name = "X8";
            this.X8.Size = new System.Drawing.Size(45, 19);
            this.X8.TabIndex = 9;
            this.X8.Text = "X8";
            this.X8.UseVisualStyleBackColor = true;
            // 
            // X9
            // 
            this.X9.AutoSize = true;
            this.X9.Location = new System.Drawing.Point(65, 24);
            this.X9.Name = "X9";
            this.X9.Size = new System.Drawing.Size(45, 19);
            this.X9.TabIndex = 10;
            this.X9.Text = "X9";
            this.X9.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Y7);
            this.groupBox3.Controls.Add(this.Y16);
            this.groupBox3.Controls.Add(this.Y1);
            this.groupBox3.Controls.Add(this.Y15);
            this.groupBox3.Controls.Add(this.Y2);
            this.groupBox3.Controls.Add(this.Y14);
            this.groupBox3.Controls.Add(this.Y3);
            this.groupBox3.Controls.Add(this.Y13);
            this.groupBox3.Controls.Add(this.Y4);
            this.groupBox3.Controls.Add(this.Y12);
            this.groupBox3.Controls.Add(this.Y5);
            this.groupBox3.Controls.Add(this.Y11);
            this.groupBox3.Controls.Add(this.Y6);
            this.groupBox3.Controls.Add(this.Y10);
            this.groupBox3.Controls.Add(this.Y8);
            this.groupBox3.Controls.Add(this.Y9);
            this.groupBox3.Location = new System.Drawing.Point(160, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(133, 269);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出监视/控制";
            // 
            // Y7
            // 
            this.Y7.AutoSize = true;
            this.Y7.Location = new System.Drawing.Point(6, 204);
            this.Y7.Name = "Y7";
            this.Y7.Size = new System.Drawing.Size(45, 19);
            this.Y7.TabIndex = 8;
            this.Y7.Text = "Y7";
            this.Y7.UseVisualStyleBackColor = true;
            this.Y7.CheckedChanged += new System.EventHandler(this.Y7_CheckedChanged);
            // 
            // Y16
            // 
            this.Y16.AutoSize = true;
            this.Y16.Location = new System.Drawing.Point(65, 234);
            this.Y16.Name = "Y16";
            this.Y16.Size = new System.Drawing.Size(53, 19);
            this.Y16.TabIndex = 17;
            this.Y16.Text = "Y16";
            this.Y16.UseVisualStyleBackColor = true;
            this.Y16.CheckedChanged += new System.EventHandler(this.Y16_CheckedChanged);
            // 
            // Y1
            // 
            this.Y1.AutoSize = true;
            this.Y1.Location = new System.Drawing.Point(6, 24);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(45, 19);
            this.Y1.TabIndex = 2;
            this.Y1.Text = "Y1";
            this.Y1.UseVisualStyleBackColor = true;
            this.Y1.CheckedChanged += new System.EventHandler(this.Y1_CheckedChanged);
            // 
            // Y15
            // 
            this.Y15.AutoSize = true;
            this.Y15.Location = new System.Drawing.Point(65, 204);
            this.Y15.Name = "Y15";
            this.Y15.Size = new System.Drawing.Size(53, 19);
            this.Y15.TabIndex = 16;
            this.Y15.Text = "Y15";
            this.Y15.UseVisualStyleBackColor = true;
            this.Y15.CheckedChanged += new System.EventHandler(this.Y15_CheckedChanged);
            // 
            // Y2
            // 
            this.Y2.AutoSize = true;
            this.Y2.Location = new System.Drawing.Point(6, 54);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(45, 19);
            this.Y2.TabIndex = 3;
            this.Y2.Text = "Y2";
            this.Y2.UseVisualStyleBackColor = true;
            this.Y2.CheckedChanged += new System.EventHandler(this.Y2_CheckedChanged);
            // 
            // Y14
            // 
            this.Y14.AutoSize = true;
            this.Y14.Location = new System.Drawing.Point(65, 174);
            this.Y14.Name = "Y14";
            this.Y14.Size = new System.Drawing.Size(53, 19);
            this.Y14.TabIndex = 15;
            this.Y14.Text = "Y14";
            this.Y14.UseVisualStyleBackColor = true;
            this.Y14.CheckedChanged += new System.EventHandler(this.Y14_CheckedChanged);
            // 
            // Y3
            // 
            this.Y3.AutoSize = true;
            this.Y3.Location = new System.Drawing.Point(6, 84);
            this.Y3.Name = "Y3";
            this.Y3.Size = new System.Drawing.Size(45, 19);
            this.Y3.TabIndex = 4;
            this.Y3.Text = "Y3";
            this.Y3.UseVisualStyleBackColor = true;
            this.Y3.CheckedChanged += new System.EventHandler(this.Y3_CheckedChanged);
            // 
            // Y13
            // 
            this.Y13.AutoSize = true;
            this.Y13.Location = new System.Drawing.Point(65, 144);
            this.Y13.Name = "Y13";
            this.Y13.Size = new System.Drawing.Size(53, 19);
            this.Y13.TabIndex = 14;
            this.Y13.Text = "Y13";
            this.Y13.UseVisualStyleBackColor = true;
            this.Y13.CheckedChanged += new System.EventHandler(this.Y13_CheckedChanged);
            // 
            // Y4
            // 
            this.Y4.AutoSize = true;
            this.Y4.Location = new System.Drawing.Point(6, 114);
            this.Y4.Name = "Y4";
            this.Y4.Size = new System.Drawing.Size(45, 19);
            this.Y4.TabIndex = 5;
            this.Y4.Text = "Y4";
            this.Y4.UseVisualStyleBackColor = true;
            this.Y4.CheckedChanged += new System.EventHandler(this.Y4_CheckedChanged);
            // 
            // Y12
            // 
            this.Y12.AutoSize = true;
            this.Y12.Location = new System.Drawing.Point(65, 114);
            this.Y12.Name = "Y12";
            this.Y12.Size = new System.Drawing.Size(53, 19);
            this.Y12.TabIndex = 13;
            this.Y12.Text = "Y12";
            this.Y12.UseVisualStyleBackColor = true;
            this.Y12.CheckedChanged += new System.EventHandler(this.Y12_CheckedChanged);
            // 
            // Y5
            // 
            this.Y5.AutoSize = true;
            this.Y5.Location = new System.Drawing.Point(6, 144);
            this.Y5.Name = "Y5";
            this.Y5.Size = new System.Drawing.Size(45, 19);
            this.Y5.TabIndex = 6;
            this.Y5.Text = "Y5";
            this.Y5.UseVisualStyleBackColor = true;
            this.Y5.CheckedChanged += new System.EventHandler(this.Y5_CheckedChanged);
            // 
            // Y11
            // 
            this.Y11.AutoSize = true;
            this.Y11.Location = new System.Drawing.Point(65, 84);
            this.Y11.Name = "Y11";
            this.Y11.Size = new System.Drawing.Size(53, 19);
            this.Y11.TabIndex = 12;
            this.Y11.Text = "Y11";
            this.Y11.UseVisualStyleBackColor = true;
            this.Y11.CheckedChanged += new System.EventHandler(this.Y11_CheckedChanged);
            // 
            // Y6
            // 
            this.Y6.AutoSize = true;
            this.Y6.Location = new System.Drawing.Point(6, 174);
            this.Y6.Name = "Y6";
            this.Y6.Size = new System.Drawing.Size(45, 19);
            this.Y6.TabIndex = 7;
            this.Y6.Text = "Y6";
            this.Y6.UseVisualStyleBackColor = true;
            this.Y6.CheckedChanged += new System.EventHandler(this.Y6_CheckedChanged);
            // 
            // Y10
            // 
            this.Y10.AutoSize = true;
            this.Y10.Location = new System.Drawing.Point(65, 54);
            this.Y10.Name = "Y10";
            this.Y10.Size = new System.Drawing.Size(53, 19);
            this.Y10.TabIndex = 11;
            this.Y10.Text = "Y10";
            this.Y10.UseVisualStyleBackColor = true;
            this.Y10.CheckedChanged += new System.EventHandler(this.Y10_CheckedChanged);
            // 
            // Y8
            // 
            this.Y8.AutoSize = true;
            this.Y8.Location = new System.Drawing.Point(6, 234);
            this.Y8.Name = "Y8";
            this.Y8.Size = new System.Drawing.Size(45, 19);
            this.Y8.TabIndex = 9;
            this.Y8.Text = "Y8";
            this.Y8.UseVisualStyleBackColor = true;
            this.Y8.CheckedChanged += new System.EventHandler(this.Y8_CheckedChanged);
            // 
            // Y9
            // 
            this.Y9.AutoSize = true;
            this.Y9.Location = new System.Drawing.Point(65, 24);
            this.Y9.Name = "Y9";
            this.Y9.Size = new System.Drawing.Size(45, 19);
            this.Y9.TabIndex = 10;
            this.Y9.Text = "Y9";
            this.Y9.UseVisualStyleBackColor = true;
            this.Y9.CheckedChanged += new System.EventHandler(this.Y9_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.IO监控);
            this.tabControl1.Controls.Add(this.串口监视);
            this.tabControl1.Controls.Add(this.CRC发送);
            this.tabControl1.Controls.Add(this.BCC发送);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(316, 384);
            this.tabControl1.TabIndex = 21;
            // 
            // IO监控
            // 
            this.IO监控.Controls.Add(this.groupBox2);
            this.IO监控.Controls.Add(this.groupBox3);
            this.IO监控.Location = new System.Drawing.Point(4, 25);
            this.IO监控.Name = "IO监控";
            this.IO监控.Padding = new System.Windows.Forms.Padding(3);
            this.IO监控.Size = new System.Drawing.Size(308, 355);
            this.IO监控.TabIndex = 0;
            this.IO监控.Text = "IO监控";
            this.IO监控.UseVisualStyleBackColor = true;
            // 
            // 串口监视
            // 
            this.串口监视.Controls.Add(this.十六进制发送);
            this.串口监视.Controls.Add(this.ASCII发送);
            this.串口监视.Location = new System.Drawing.Point(4, 25);
            this.串口监视.Name = "串口监视";
            this.串口监视.Padding = new System.Windows.Forms.Padding(3);
            this.串口监视.Size = new System.Drawing.Size(308, 355);
            this.串口监视.TabIndex = 1;
            this.串口监视.Text = "串口监视";
            this.串口监视.UseVisualStyleBackColor = true;
            // 
            // 十六进制发送
            // 
            this.十六进制发送.Controls.Add(this.textbox_16);
            this.十六进制发送.Location = new System.Drawing.Point(6, 160);
            this.十六进制发送.Name = "十六进制发送";
            this.十六进制发送.Size = new System.Drawing.Size(289, 137);
            this.十六进制发送.TabIndex = 1;
            this.十六进制发送.TabStop = false;
            this.十六进制发送.Text = "16进制发送";
            // 
            // textbox_16
            // 
            this.textbox_16.Location = new System.Drawing.Point(6, 24);
            this.textbox_16.Multiline = true;
            this.textbox_16.Name = "textbox_16";
            this.textbox_16.Size = new System.Drawing.Size(277, 107);
            this.textbox_16.TabIndex = 24;
            // 
            // ASCII发送
            // 
            this.ASCII发送.Controls.Add(this.textbox_ascii);
            this.ASCII发送.Location = new System.Drawing.Point(6, 15);
            this.ASCII发送.Name = "ASCII发送";
            this.ASCII发送.Size = new System.Drawing.Size(289, 137);
            this.ASCII发送.TabIndex = 0;
            this.ASCII发送.TabStop = false;
            this.ASCII发送.Text = "ASCII发送";
            // 
            // textbox_ascii
            // 
            this.textbox_ascii.Location = new System.Drawing.Point(6, 21);
            this.textbox_ascii.Multiline = true;
            this.textbox_ascii.Name = "textbox_ascii";
            this.textbox_ascii.Size = new System.Drawing.Size(277, 105);
            this.textbox_ascii.TabIndex = 23;
            this.textbox_ascii.TextChanged += new System.EventHandler(this.textbox_ascii_TextChanged);
            // 
            // CRC发送
            // 
            this.CRC发送.Location = new System.Drawing.Point(4, 25);
            this.CRC发送.Name = "CRC发送";
            this.CRC发送.Size = new System.Drawing.Size(308, 355);
            this.CRC发送.TabIndex = 2;
            this.CRC发送.Text = "CRC发送";
            this.CRC发送.UseVisualStyleBackColor = true;
            // 
            // BCC发送
            // 
            this.BCC发送.Location = new System.Drawing.Point(4, 25);
            this.BCC发送.Name = "BCC发送";
            this.BCC发送.Size = new System.Drawing.Size(308, 355);
            this.BCC发送.TabIndex = 3;
            this.BCC发送.Text = "BCC发送";
            this.BCC发送.UseVisualStyleBackColor = true;
            // 
            // log_txt
            // 
            this.log_txt.AcceptsReturn = true;
            this.log_txt.AcceptsTab = true;
            this.log_txt.Location = new System.Drawing.Point(7, 24);
            this.log_txt.Multiline = true;
            this.log_txt.Name = "log_txt";
            this.log_txt.ReadOnly = true;
            this.log_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.log_txt.Size = new System.Drawing.Size(525, 164);
            this.log_txt.TabIndex = 22;
            this.log_txt.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.log_txt);
            this.groupBox4.Location = new System.Drawing.Point(16, 402);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(538, 194);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Log显示";
            // 
            // Btn_ClearData
            // 
            this.Btn_ClearData.Location = new System.Drawing.Point(32, 41);
            this.Btn_ClearData.Name = "Btn_ClearData";
            this.Btn_ClearData.Size = new System.Drawing.Size(138, 29);
            this.Btn_ClearData.TabIndex = 28;
            this.Btn_ClearData.Text = "清除接收数据";
            this.Btn_ClearData.UseVisualStyleBackColor = true;
            this.Btn_ClearData.Click += new System.EventHandler(this.Btn_ClearData_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(98, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ASCII显示";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(101, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 19);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.Text = "16进制显示";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Btn_ClearData);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.radioButton1);
            this.groupBox5.Location = new System.Drawing.Point(348, 320);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 76);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.radioButton3);
            this.groupBox6.Controls.Add(this.radioButton4);
            this.groupBox6.Location = new System.Drawing.Point(348, 238);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(206, 76);
            this.groupBox6.TabIndex = 31;
            this.groupBox6.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 29);
            this.button1.TabIndex = 28;
            this.button1.Text = "发送数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(101, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 19);
            this.radioButton3.TabIndex = 29;
            this.radioButton3.Text = "16进制发送";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(4, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(98, 19);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ASCII发送";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 602);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.IO监控.ResumeLayout(false);
            this.串口监视.ResumeLayout(false);
            this.十六进制发送.ResumeLayout(false);
            this.十六进制发送.PerformLayout();
            this.ASCII发送.ResumeLayout(false);
            this.ASCII发送.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_port_switch;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox X7;
        private System.Windows.Forms.CheckBox X16;
        private System.Windows.Forms.CheckBox X1;
        private System.Windows.Forms.CheckBox X15;
        private System.Windows.Forms.CheckBox X2;
        private System.Windows.Forms.CheckBox X14;
        private System.Windows.Forms.CheckBox X3;
        private System.Windows.Forms.CheckBox X13;
        private System.Windows.Forms.CheckBox X4;
        private System.Windows.Forms.CheckBox X12;
        private System.Windows.Forms.CheckBox X5;
        private System.Windows.Forms.CheckBox X11;
        private System.Windows.Forms.CheckBox X6;
        private System.Windows.Forms.CheckBox X10;
        private System.Windows.Forms.CheckBox X8;
        private System.Windows.Forms.CheckBox X9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox Y7;
        private System.Windows.Forms.CheckBox Y16;
        private System.Windows.Forms.CheckBox Y1;
        private System.Windows.Forms.CheckBox Y15;
        private System.Windows.Forms.CheckBox Y2;
        private System.Windows.Forms.CheckBox Y14;
        private System.Windows.Forms.CheckBox Y3;
        private System.Windows.Forms.CheckBox Y13;
        private System.Windows.Forms.CheckBox Y4;
        private System.Windows.Forms.CheckBox Y12;
        private System.Windows.Forms.CheckBox Y5;
        private System.Windows.Forms.CheckBox Y11;
        private System.Windows.Forms.CheckBox Y6;
        private System.Windows.Forms.CheckBox Y10;
        private System.Windows.Forms.CheckBox Y8;
        private System.Windows.Forms.CheckBox Y9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage IO监控;
        private System.Windows.Forms.TabPage 串口监视;
        private System.Windows.Forms.GroupBox 十六进制发送;
        private System.Windows.Forms.GroupBox ASCII发送;
        private System.Windows.Forms.TextBox textbox_ascii;
        private System.Windows.Forms.TextBox textbox_16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TabPage CRC发送;
        private System.Windows.Forms.TabPage BCC发送;
        private System.Windows.Forms.TextBox log_txt;
        private System.Windows.Forms.Button Btn_ClearData;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}

