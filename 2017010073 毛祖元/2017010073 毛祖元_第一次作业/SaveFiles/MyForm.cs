using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SaveFiles
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
            m_strDir = opDlg.FileNames;
            m_Length = m_strDir.Length;

        }

        private void btSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog svDlg = new SaveFileDialog();
            svDlg.ShowDialog();
            string strDir;
            for (int i = 0; i < m_Length; i++)
            {
                int iIndex = m_strDir[i].LastIndexOf("\\");
                string strName = m_strDir[i].Substring(iIndex + 1);
                string strGet = svDlg.FileName;
                iIndex = strGet.LastIndexOf("\\");
                strDir = strGet.Substring(0, iIndex + 1);
                strDir = strDir + strName;
                System.IO.File.Copy(m_strDir[i], strDir);
            }
        }
        string[] m_strDir;
        int m_Length;

        private void MyForm_Load(object sender, EventArgs e)
        {

        }
    }
}