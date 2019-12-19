using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Open_Search_ListBox
{
    public partial class FileShow : Form
    {
        public FileShow()
        {
            InitializeComponent();
        }

       private void FileShow_Load(object sender, EventArgs e)
        {
            clock.Enabled = true;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            DateTime dtime = DateTime.Now;
            Timelabel.Text = dtime.ToString(); 
        }
        public string textboxText
        {
            get { return this.ShowFile.Text; }
            set { this.ShowFile.Text = value; }
        }

       
    }
}
