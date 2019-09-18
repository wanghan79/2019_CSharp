using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsForms
{
    public partial class MyForm : Form
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void btOpenFile_Click(object sender, EventArgs e)
        {

            OpenFileDialog opDlg = new OpenFileDialog();
            opDlg.Multiselect = true;
            opDlg.ShowDialog();
            m_dir = opDlg.FileNames;
            length = m_dir.Length;

        }

        private void btSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog svDlg = new SaveFileDialog();
            svDlg.ShowDialog();
            string dir;
            for (int i = 0; i < length; i++)
            {
                index = m_dir[i].LastIndexOf("\\");
                m_name = m_dir[i].Substring(index + 1);
                string get = svDlg.FileName;
                index = get.LastIndexOf("\\");
                dir = get.Substring(0, get.LastIndexOf("\\") + 1);
                dir = dir + m_name;
                System.IO.File.Copy(m_dir[i], dir);
            }
        }
        string[] m_dir;
        int length;
        string m_name;
        int index;

        private void MyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
