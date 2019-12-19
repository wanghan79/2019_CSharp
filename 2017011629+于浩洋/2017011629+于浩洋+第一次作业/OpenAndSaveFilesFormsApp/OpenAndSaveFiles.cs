using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenAndSaveFilesFormsApp
{
    public partial class OpenAndSaveFiles : Form
    {
        string[] m_strDirs;
        public OpenAndSaveFiles()
        {
            InitializeComponent();
            bt_SaveFiles.Enabled = false;
        }

        private void OpenFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDlg = new OpenFileDialog
            {
                Multiselect = true
            };
            if (opDlg.ShowDialog()==DialogResult.OK)
            {
                m_strDirs = opDlg.FileNames;

                foreach (string dir in m_strDirs)
                {
                    tb_FileContent.Clear();
                    string[] lines = System.IO.File.ReadAllLines(dir);
                    foreach (string s in lines)
                    {
                        tb_FileContent.AppendText(s + Environment.NewLine);
                    }
                    lb_FilePath.Text = dir;
                }
                bt_SaveFiles.Enabled = true;
            }
        }

        private void SaveFiles_Click(object sender, EventArgs e)
        {
            SaveFileDialog svDlg = new SaveFileDialog
            {
                Filter = "All files (*.*)|*.*"
            };

            string str_fileName = System.IO.Path.GetFileName(lb_FilePath.Text);
            foreach (string dir in m_strDirs)
            {
                svDlg.FileName = Path.GetFileName(dir);
                if (svDlg.ShowDialog() == DialogResult.OK)
                {

                    lb_FilePath.Text = svDlg.FileName;
                    tb_FileContent.Clear();
                    if(dir==svDlg.FileName)
                    {

                    }
                    else
                    {
                        File.Copy(dir, lb_FilePath.Text, true);
                    }
                    
                }
            }
        }
        
    }
}
