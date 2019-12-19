using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileWork
{
    public partial class FileInfo : Form
    {
        string m_path = FileWorkMain.m_strFileName;
        public FileInfo()
        {
            InitializeComponent();

            lbl_Time.Text = DateTime.Now.ToString() + '\n' + '\n' + "文件内容 :";

            string[] lines = File.ReadAllLines(m_path);
            foreach (string line in lines)
            {
                tb_FileContent.AppendText(line + Environment.NewLine);
            }

        }
    }
}
