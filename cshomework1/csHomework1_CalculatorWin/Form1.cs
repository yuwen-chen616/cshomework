using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csHomework1_CalculatorWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            string s = textBox1.Text;
            bool IsInt;//isEft表示文本框中输入字符是否能成功解析为数字，解析成功则isEft为true，反之为false。
            IsInt = int.TryParse(s, out a);//解析第一个操作数
            if (!IsInt)//第一个操作数解析失败
            {
                label1.Text = "第一个操作数必须是数字";
                return;
            }
            s = textBox2.Text;
            IsInt = int.TryParse(s, out b);//解析第二个操作数
            if (!IsInt)//第二个操作数解析失败
            {
                label2.Text = "第二个操作数必须是数字";
                return;
            }
            int opt = comboBox1.SelectedIndex;
            
            switch (opt)
            {
                case 1:
                    textBox3.Text = $"{a + b}";
                    break;
                case 2:
                    textBox3.Text = $"{a - b}";
                    break;
                case 3:
                    textBox3.Text = $"{a * b}";
                    break;
                case 4:
                    if (b == 0)
                    {
                        label2.Text = "错误！除数不能为0";
                    }
                    else
                    {
                        textBox3.Text = $"{a / b}";
                    }
                    break;
            }
            return;
        }
    }
}
