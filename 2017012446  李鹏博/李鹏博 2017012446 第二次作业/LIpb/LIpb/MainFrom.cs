using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSave
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }
        string dir;
        private void btOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "All files (*.*)|*.*";
            op.RestoreDirectory = true;
            if(op.ShowDialog()==DialogResult.OK)
            {
                if(op.OpenFile()!=null)
                {
                    dir = op.FileName;
                }
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sa = new SaveFileDialog();
            sa.Filter = "All files (*.*)|*.*";
            sa.RestoreDirectory = true;
            DialogResult dr = sa.ShowDialog();
            if(dr==DialogResult.OK&&sa.FileName.Length>0)
            {
                string m_dir;
                m_dir = sa.FileName;
                System.IO.File.Copy(dir, m_dir);
                MessageBox.Show("Success !");
            }
        }
    }
}
