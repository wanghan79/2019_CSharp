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

namespace FileDialogFirst
{
    public partial class dialogFirst : Form
    {
        public dialogFirst()
        {
            InitializeComponent();
            textenter.Multiline = true;
        }
        string[] File_path;
        public static string GetFileName(string strFileName)
        {
            int i = strFileName.LastIndexOf('\\');
            string s = strFileName.Substring(i + 1);
            return s;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void 打开文件_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文件";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"C;\";
            ofd.Filter = "文本文件|*.txt";
            ofd.ShowDialog();
            File_path = ofd.FileNames;

            string path = ofd.FileName;
            if (path == "")
            {
                return;
            }
            using (FileStream fsRead=new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                textenter.Text = Encoding.Default.GetString(buffer, 0, r);
            }
        }

        private void 存储文件_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "";
            sfd.InitialDirectory = @"C:\";
            sfd.Filter = "文本文件|*.txt";
            sfd.ShowDialog();

            string path = sfd.FileName;
            if (path == "")
            {
                return;
            }

            for(int i = 0; i < File_path.Length; ++i)
            {
                string str = sfd.FileName.ToString();
                string s = GetFileName(File_path[i]);
                str += s;
                System.IO.File.Copy(File_path[i], str);
            }
            using (FileStream fsWrite=new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                byte[] buffer = Encoding.Default.GetBytes(textenter.Text);
                fsWrite.Write(buffer, 0, buffer.Length);
                MessageBox.Show("保存成功");
                fsWrite.Close();
            }

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void SaveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
