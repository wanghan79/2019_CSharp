using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFrom
{
    public partial class myform : Form
    {
        public myform()
        {
            InitializeComponent();
        }

        private void open_click_Click(object sender, EventArgs e)
        {
            OpenFileDialog opDlg = new OpenFileDialog();
            opDlg.Multiselect = true;
            opDlg.ShowDialog();
            m_strDir = opDlg.FileNames;
            m_Length = m_strDir.Length;
        }
        string[] m_strDir;
        int m_Length;

        private void save_click_Click(object sender, EventArgs e)
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
    }

}
