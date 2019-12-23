using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows窗体事件
{
    public partial class FormOne : Form
    {
        public FormOne()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "装载窗体";
            this.BackgroundImage = Image.FromFile(@"D:\StartC#\u.jpg");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "单击窗体";
            this.BackgroundImage = Image.FromFile(@"D:\StartC#\c.jpg");
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.Text = "双击窗体";
            this.BackgroundImage = Image.FromFile(@"D:\StartC#\w.jpg");
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.txBox=""
        }
    }
}
