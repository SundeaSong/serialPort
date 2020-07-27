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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModBus
{
    public partial class Form1 : Form
    {
        IniFiles ini = new IniFiles(Application.StartupPath + @"\config.ini");
        public Form1()
        {
            InitializeComponent();
        }
        

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
        }
        public bool btn_status = false;
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
                    switch (double.Parse(comboBox3.Text))                               //停止位
                    {
                        case 1: serialPort1.StopBits = StopBits.One; break;
                        case 1.5: serialPort1.StopBits = StopBits.OnePointFive; break;
                        case 2: serialPort1.StopBits = StopBits.Two; break;
                        default: break;
                    }
                    serialPort1.DataBits = int.Parse(comboBox4.Text);                   //数据位
                                                                                        //                     public enum PARITYMODE { NONE = 1, ODD = 2, EVEN = 3, MARK = 4, SPACE = 5 };
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
                }
                else if (btn_status == true)
                {
                    btn_status = false;
                    Btn_port_switch.Text = "打开串口";
                    serialPort1.Close();
                }
            }
        }
        /// <summary>
        /// 点击串口的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.Items.Clear();
            foreach (string s in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);                      //串口号显示到combobox里
            }
            ini.IniWriteValue("串口号", "com", comboBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini.IniWriteValue("波特率", "BaudRate", comboBox2.Text);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini.IniWriteValue("停止位", "StopBits", comboBox3.Text);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini.IniWriteValue("数据位", "DataBits", comboBox4.Text);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            ini.IniWriteValue("校验位", "Parity", comboBox5.Text);
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            int ReceiveNums = serialPort1.BytesToRead;
            byte[] data = { 0 ,0,0,0,0,0};
            if (radioButton2.Checked == true)
            {
                serialPort1.Read(data, 0, ReceiveNums);
                for (int i = 0; i < ReceiveNums; i++)
                {
                    log_txt.AppendText(String.Format("{0:X2} ", serialPort1.ReadByte()));
                    
                }
                log_txt.AppendText("\r\n");
               

            }
            else
            {
                if (radioButton1.Checked == true)
                {
                    serialPort1.Encoding = System.Text.Encoding.GetEncoding("GB2312");//解决中午乱码问题，国标2312编码格式
                    log_txt.AppendText(serialPort1.ReadExisting());
                }
            }
        }

        private void Btn_ClearData_Click(object sender, EventArgs e)
        {
            log_txt.Text = "";
        }
        public int CheckOutputStatus(object send)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string InputAscii = textbox_ascii.Text;
            var Input_16num = textbox_16.Text;
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
                if (radioButton3.Checked == true)
                {
                    try
                    {
                        var list = new List<byte>();
                        var arr = Input_16num.Split(' ');
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

        private void textbox_ascii_TextChanged(object sender, EventArgs e)
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
        }
        public int num = 0;
        private void Y1_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y2_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y3_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y4_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y5_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y6_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y7_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y8_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y9_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y10_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y11_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y12_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y13_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y14_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y15_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }

        private void Y16_CheckedChanged(object sender, EventArgs e)
        {
            num = CheckOutputStatus(1);
        }
    }
}
