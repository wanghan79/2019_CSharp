using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HR_APP
{
    public partial class text_show : Form
    {
        string text;
        public text_show(string text_name )
        {
            InitializeComponent();
            text = text_name;
        }

        private void text_show_Load(object sender, EventArgs e)
        {
            system_time.Start();
            System.IO.StreamReader reader = new System.IO.StreamReader(@text);
            System.Text.Encoding.GetEncoding("gb2312");
            string s = reader.ReadLine();
            while(s!=null)
            {
                show_content.AppendText(s + "\r\n");
                s = reader.ReadLine();
            }
            reader.Close();

        }

        private void system_time_Tick(object sender, EventArgs e)
        {
            DateTime dt=System.DateTime.Now;
            show_time.Text=dt.ToString();

        }

     
   
    }
}