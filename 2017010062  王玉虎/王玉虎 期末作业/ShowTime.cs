using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wangyh_work
{
    public partial class text_show : Form
    {
        

        string text;
        public text_show(string text_name)
        {
            InitializeComponent();
            text = text_name;
        }

        private void text_show_Load(object sender, EventArgs e)
        {
            system_time.Start();
            //text_box.Text = System.IO.File.ReadAllText(text);
            System.IO.StreamReader reader = new System.IO.StreamReader(@text);
            System.Text.Encoding.GetEncoding("gb2312");
            string s = reader.ReadLine();//字符型文件是一行行读 
            while (s != null)
            {
                text_box.AppendText(s + "\r\n");//尾部\r\n表换行 
                s = reader.ReadLine();
            }
            reader.Close(); 
        }

        private void system_time_Tick(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Now;
            tx_time.Text = dt.ToString();
        }
    }
}

    © 2019 GitHub, Inc.
    Terms
    Privacy
    Security
    Status
    Help

    Contact GitHub
    Pricing
    API
    Training
    Blog
    About

