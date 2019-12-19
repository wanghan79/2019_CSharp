using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;//用到了正则表达式

namespace isLeapyear
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

         //MainForm关闭事件
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("是否关闭程序？","标题栏",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                e.Cancel=false;//确定关闭
            }
            else
            {
                e.Cancel=true;//不关闭
            }
        }

        //button1点击事件
        private void button1_Click(object sender, EventArgs e)
        {
            if(new Regex("^[0-9]+$").IsMatch(textBox1.Text)||new Regex("^[-][0-9]+$").IsMatch(textBox1.Text))
                //利用正则表达式判断输入的是否为数字
            {
                int year=int.Parse(textBox1.Text);//将textbox1中文本转化为整形
                if((year%4==0&&year%100!=0)||year%400==0)
                {
                    MessageBox.Show("是闰年","结果");
                }
                else
                {
                    MessageBox.Show("不是闰年","结果");
                }
            }
            else
            {
                MessageBox.Show("输入不符合格式","结果");
            }
        }

       
    }
}
