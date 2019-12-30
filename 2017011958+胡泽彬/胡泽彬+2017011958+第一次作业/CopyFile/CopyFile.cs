using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace CopyFile
{
    public partial class CopyFiles : Form
    {
        public CopyFiles()
        {
            InitializeComponent();
        }

        private void btnOpenFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpFileDlg = new OpenFileDialog();
            OpFileDlg.Multiselect = true;
            OpFileDlg.ShowDialog();
            dirArray = OpFileDlg.FileNames;
            GetFileName();
        }

        private void GetFileName()
        {
            int j = 0;
            foreach(string i in dirArray)
            {   
                string[] Item = Regex.Split(i, @"\\");
                FileName[j] = Item[Item.Length - 1];
                ckListBoxFileName.Items.Add(FileName[j],true);
                j++;
            }
        }

        private void btnSaveFiles_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fldBrowserDlg = new FolderBrowserDialog();
            fldBrowserDlg.Description = "请选择文件路径";
            if(fldBrowserDlg.ShowDialog() == DialogResult.OK)
            {
                string foldPath = fldBrowserDlg.SelectedPath;
                System.Windows.Forms.MessageBox.Show("是否移动到文件夹:" + foldPath, "复制提示", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        string tempString;
        string[] dirArray = new string[100];
        string[] FileName = new string[100];

        private void CopyFiles_Load(object sender, EventArgs e)
        {

        }
    }
}
