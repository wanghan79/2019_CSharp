using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FirstJob : Form
    {
        public FirstJob()
        {
            InitializeComponent();
        }

        private void btSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog svDlg = new SaveFileDialog();
            svDlg.ShowDialog();
            string dir = svDlg.FileName;
            System.IO.File.Copy(m_dir, dir);
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDlg = new OpenFileDialog();
            opDlg.ShowDialog();
            m_dir = opDlg.FileName;
        }
        string m_dir;
        private void btChange_Click(object sender, EventArgs e)
        {
            txShow.Text = "Another Word!";
        }
        private void txShow_TextChanged(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
