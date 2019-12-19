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
        //FileWorkMain.m_Path+ "\\" + 
        string m_path = FileWorkMain.m_FileName;
        public FileInfo()
        {
            InitializeComponent();

            MessageBox.Show(m_path);
            //显示时间
            lb_Time.Text = DateTime.Now.ToString() + '\n' + '\n' + "文件内容 :";

            // 显示文件内容（文本文件）
            string[] lines = File.ReadAllLines(m_path);
            foreach (string line in lines)
            {
                FileContent.AppendText(line + Environment.NewLine);
            }

        }
    }
}
