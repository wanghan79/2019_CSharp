using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MttSecond2
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void file_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDlg = new OpenFileDialog();
            opDlg.ShowDialog();
            path.Text = opDlg.FileName;
            Content.Text = System.IO.File.ReadAllText(opDlg.FileName);
            //this.Content.Text = File.ReadAllText(opDlg.FileName);

            DateTime dt = System.DateTime.Now;
            time.Text = dt.ToString();
        }
    }
}
