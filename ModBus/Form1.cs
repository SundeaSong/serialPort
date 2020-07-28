using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBus
{
    public partial class Form1 : Form
    {
        #region Field
        IniFiles ini = new IniFiles(Application.StartupPath + @"\config.ini");
        private List<CheckBox> _lst = new List<CheckBox>();
        private delegate void UpdateText(string str);
        private delegate void GenerateInfo(SerialPort serial,byte[] arr);
        private bool btn_status = false;
        private int num = 0;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        #region EventMethod
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;    //窗口的最大化按钮失能
            this.MaximumSize = this.Size;    //窗口的最大尺寸为当前尺寸

            this.MinimumSize = this.Size;     //窗口的最小尺寸为当前尺寸
            CheckForIllegalCrossThreadCalls = false;                        //忽略跨线程的问题
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);                      //串口号显示到combobox里
            }
            //comboBox1.SelectedIndex = 0;                    //默认显示前面的串口号
            int[] a = { 110, 300, 600, 1200, 2400, 4800, 9600, 19200, 38400, 43000, 56000, 57600, 115200, 128000, 256000 };
            for (int i = 0; i < 15; i++)
            {
                comboBox2.Items.Add(a[i]);
            }
            comboBox3.Items.Add(1);
            comboBox3.Items.Add(1.5);
            comboBox3.Items.Add(2);
            comboBox4.Items.Add(8);
            comboBox4.Items.Add(7);
            comboBox4.Items.Add(6);
            
            comboBox5.Items.Add("NONE");
            comboBox5.Items.Add("ODD");
            comboBox5.Items.Add("EVEN");
            comboBox5.Items.Add("MARK");
            comboBox5.Items.Add("SPACE");
            if (ini.ExistINIFile())
            {
                comboBox1.Text = ini.IniReadValue("串口号", "com");
                comboBox2.Text = ini.IniReadValue("波特率", "BaudRate");
                comboBox3.Text = ini.IniReadValue("停止位", "StopBits");
                comboBox4.Text = ini.IniReadValue("数据位", "DataBits");
                comboBox5.Text = ini.IniReadValue("校验位","Parity");
            }
            _lst.Add(Y1);
            _lst.Add(Y2);
            _lst.Add(Y3);
            _lst.Add(Y4);
            _lst.Add(Y5);
            _lst.Add(Y6);
            _lst.Add(Y7);
            _lst.Add(Y8);
            _lst.Add(Y9);
            _lst.Add(Y10);
            _lst.Add(Y11);
            _lst.Add(Y12);
            _lst.Add(Y13);
            _lst.Add(Y14);
            _lst.Add(Y15);
            _lst.Add(Y16);

            UpdateLogTxt("程序启动");

        }
        /// <summary>
        /// 多线程控制log输出 输出[2020-7-8 20:12:20 Debug]:log
        /// </summary>
        public void UpdateLogTxt(string str)
        {
            if (log_txt.InvokeRequired)
            {
                this.BeginInvoke(new UpdateText(AppendText),str);
            }
            else
            {
                AppendText(str);
            }
        }

        /// <summary>
        /// 不可使用
        /// </summary>
        /// <param name="txt"></param>
        private void AppendText(string txt)
        {
            log_txt.Text += $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} Debug]: {txt}\r\n"; ;
        }

        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_port_switch_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("请选择端口");
            }
            else 
            {
                if (btn_status == false)
                {
                    btn_status = true;
                    Btn_port_switch.Text = "关闭串口";
                    serialPort1.PortName = comboBox1.Text;                              //端口
                    serialPort1.BaudRate = int.Parse(comboBox2.Text);                   //波特率
                    serialPort1.ReadBufferSize = 20;
                    switch (double.Parse(comboBox3.Text))                               //停止位
                    {
                        case 1: serialPort1.StopBits = StopBits.One; break;
                        case 1.5: serialPort1.StopBits = StopBits.OnePointFive; break; 
                        case 2: serialPort1.StopBits = StopBits.Two; break;
                        default: break;
                    }
                    serialPort1.DataBits = int.Parse(comboBox4.Text);                   //数据位
                                                                                        //public enum PARITYMODE { NONE = 1, ODD = 2, EVEN = 3, MARK = 4, SPACE = 5 };
                    if (comboBox5.Text == "NONE")
                    {
                        serialPort1.Parity = Parity.None;
                    }
                    else if (comboBox5.Text == "ODD")
                    {
                        serialPort1.Parity = Parity.Odd;
                    }
                    else if (comboBox5.Text == "EVEN")
                    {
                        serialPort1.Parity = Parity.Even;
                    }
                    else if (comboBox5.Text == "MARK")
                    {
                        serialPort1.Parity = Parity.Mark;
                    }
                    else if (comboBox5.Text == "SPACE")
                    {
                        serialPort1.Parity = Parity.Space;
                    }
                    serialPort1.Open();
                    UpdateLogTxt("打开串口");
                }
                else if (btn_status == true)
                {
                    btn_status = false;
                    Btn_port_switch.Text = "打开串口";
                    serialPort1.Close();
                    UpdateLogTxt("关闭串口");
                }
            }
        }

        /// <summary>
        /// 选择串口参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var com = (ComboBox)sender;
            switch (com.Name.ToLower())
            {
                case "combobox1":
                    foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
                    {
                        comboBox1.Items.Add(s);                      //串口号显示到combobox里
                    }
                    ini.IniWriteValue("串口号", "com", com.Text);
                    UpdateLogTxt($"选择串口：{com.Text}");
                    break; 
                case "combobox2":
                    ini.IniWriteValue("波特率", "BaudRate", com.Text);
                    UpdateLogTxt($"选择波特率：{com.Text}");
                    break; 
                case "combobox3":
                    ini.IniWriteValue("停止位", "StopBits", com.Text);
                    UpdateLogTxt($"选择停止位：{com.Text}");
                    break; 
                case "combobox4":
                    ini.IniWriteValue("数据位", "DataBits", com.Text);
                    UpdateLogTxt($"选择数据位：{com.Text}");
                    break;
                case "combobox5":
                    ini.IniWriteValue("校验位", "Parity", com.Text);
                    UpdateLogTxt($"选择校验位：{com.Text}");
                    break;
            }
            //comboBox1.Items.Clear();
          
        }

        /// <summary>
        /// 串口数据接收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serial = (SerialPort)sender;
            byte[] buffer = new byte[512];
            var receiveLen = serial.Read(buffer, 0, buffer.Length);
            var temp = new byte[receiveLen];
            Array.Copy(buffer, 0, temp, 0, receiveLen);
            if (radioButton2.Checked)
            {
                
                UpdateLogTxt(string.Join(" ",Array.ConvertAll(temp,p=>p.ToString("x2"))));
                this.BeginInvoke(new GenerateInfo(GenerateInfoCallBack),serial,temp);
            }
            else if (radioButton1.Checked)
            {
                UpdateLogTxt(Encoding.UTF8.GetString(temp));
            }
        }

        /// <summary>
        /// 委托返回方法
        /// </summary>
        /// <param name="serial"></param>
        /// <param name="temp"></param>
        private void GenerateInfoCallBack(SerialPort serial,byte[] temp)
        {
            var tmpLst = new List<byte>();
            if (temp.Length > 5)
            {
                var cmdTyp = temp[1];
                if (cmdTyp == 1)//查询
                {
                    var c = _lst.FindAll(p => p.Checked).Count;//计算有多少被选中
                    tmpLst.Add(1);
                    tmpLst.Add(1);
                    tmpLst.Add((byte)c);
                    tmpLst.Add(0);
                    tmpLst.Add(0);
                    tmpLst.Add(0);
                    serial.Write(tmpLst.ToArray(),0,tmpLst.Count);
                }
                else if (cmdTyp == 5)
                {
                    var index = temp[3];
                    var state = temp[4].ToString("x2").ToLower() == "ff";
                    foreach (var item in _lst)
                    {
                        var nId = item.Name.Substring(1);
                        if ((index+1).ToString() == nId)
                        {
                            item.Checked = state;
                            break;
                        }
                    }
                    tmpLst.AddRange(temp);
                    serial.Write(tmpLst.ToArray(), 0, tmpLst.Count);
                }
                else if (cmdTyp == 4)
                {
                    tmpLst.Add(1);
                    tmpLst.Add(4);
                    tmpLst.Add((byte)(num & 0x00ff));
                    tmpLst.Add((byte)((num & 0xff00) >> 8));
                    serial.Write(tmpLst.ToArray(), 0, tmpLst.Count);
                }
                else
                {
                    UpdateLogTxt($"无此命令");
                }
            }
            else
            {
                UpdateLogTxt(string.Join(" ", temp));
            }
        }

        /// <summary>
        /// 清空log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ClearData_Click(object sender, EventArgs e)
        {
            log_txt.Clear();
        }

        /// <summary>
        /// 计算选择代码
        /// </summary>
        /// <param name="send"></param>
        /// <returns></returns>
        private int CheckOutputStatus(object send)
        {
            int checklist = 0;
            for (int xxx = 0; xxx < 16; xxx++)
            {
                if (Y1.Checked)  { checklist |= 0x01; } else { checklist &= 0xfffe; }
                if (Y2.Checked)  { checklist |= 0x02; } else { checklist &= 0xfffd; }
                if (Y3.Checked)  { checklist |= 0x04; } else { checklist &= 0xfffb; }
                if (Y4.Checked)  { checklist |= 0x08; } else { checklist &= 0xfff7; }
                if (Y5.Checked)  { checklist |= 0x10; } else { checklist &= 0xffef; }
                if (Y6.Checked)  { checklist |= 0x20; } else { checklist &= 0xffdf; }
                if (Y7.Checked)  { checklist |= 0x40; } else { checklist &= 0xffbf; }
                if (Y8.Checked)  { checklist |= 0x80; } else { checklist &= 0xff7f; }
                if (Y9.Checked)  { checklist |= 0x100; } else { checklist &= 0xfeff; }
                if (Y10.Checked) { checklist |= 0x200; } else { checklist &= 0xfdff; }
                if (Y11.Checked) { checklist |= 0x400; } else { checklist &= 0xfbff; }
                if (Y12.Checked) { checklist |= 0x800; } else { checklist &= 0xf7ff; }
                if (Y13.Checked) { checklist |= 0x1000; } else { checklist &= 0xefff; }
                if (Y14.Checked) { checklist |= 0x2000; } else { checklist &= 0xdfff; }
                if (Y15.Checked) { checklist |= 0x4000; } else { checklist &= 0xbfff; }
                if (Y16.Checked) { checklist |= 0x8000; } else { checklist &= 0x7fff; }
            }
            return checklist;
        }

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            string InputAscii = textbox_ascii.Text;
            var Input_16num = textbox_16.Text;
            UpdateLogTxt("发送数据：" + Input_16num);
            try
            {
                if (radioButton4.Checked == true)
                {
                    try
                    {
                        char[] SendChar = InputAscii.ToArray();
                        int CharLength = SendChar.Length;

                        serialPort1.Encoding = System.Text.Encoding.GetEncoding("GB2312");
                        serialPort1.Write(SendChar, 0, CharLength);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("错误:" + ex.Message);
                    }
                }
                else if (radioButton3.Checked == true)
                {
                    try
                    {
                        var list = new List<byte>();
                        var arr = Input_16num.Trim(' ').Split(' ');
                        try
                        {
                            foreach (var s in arr)
                            {
                                var res = byte.Parse(s, NumberStyles.AllowHexSpecifier);
                                list.Add(res);
                            }
                            serialPort1.Write(list.ToArray(), 0, list.Count);
                        }
                        catch
                        {
                            MessageBox.Show("请在两个数字之间键入空格");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Err:端口未打开");
                    }

                }
            }
            catch
            {
                MessageBox.Show("串口未打开");
            }
            
        }

        /// <summary>
        /// ascii码发送
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextShow_TextChanged(object sender, EventArgs e)
        {
            string str = textbox_ascii.Text;
            byte[] array = System.Text.Encoding.ASCII.GetBytes(str);
            string asciiStr = null;
            for (int i = 0; i < array.Length;i++)
            {
                int asciicode = (int)(array[i]);
                asciiStr += Convert.ToString(asciicode,16);
                asciiStr += " ";
            }
            textbox_16.Text = asciiStr;
            UpdateLogTxt("ASCII码发送");
        }
        
        /// <summary>
        /// 输出控制计算状态码并赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IOCheckBox_Changed(object sender, EventArgs e)
        {
            num = CheckOutputStatus(sender);
            UpdateLogTxt("输出控制状态码："+num.ToString("x2"));
        }
        #endregion
    }
}
