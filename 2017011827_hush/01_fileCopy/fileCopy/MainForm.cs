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

namespace fileCopy
{
    public partial class MainForm : Form
    {
        string pickPath = "";
        string pickName = "";
        string savePath = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_pickFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog pickDialog = new OpenFileDialog();
            pickDialog.Multiselect = true;//该值确定是否可以选择多个文件
            pickDialog.Title = "请选择文件夹";
            pickDialog.Filter = "所有文件(*.*)|*.*";
            if (pickDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pickPath = pickDialog.FileName;
                pickName = System.IO.Path.GetFileName(pickDialog.FileName);
                lab_pickFileName.Text = pickPath;
            }
        }

        private void btn_copyTo_click(object sender, EventArgs e)
        {
            if (pickPath == "")
            {
                lab_pickFileName.Text = "请先选择需要复制的文件";
            }
            else
            {
                System.Windows.Forms.FolderBrowserDialog saveDialog = new System.Windows.Forms.FolderBrowserDialog();
                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    savePath = saveDialog.SelectedPath;
                    lab_savePath.Text = savePath;
                }
            }
        }


        private void btn_reset_Click(object sender, EventArgs e)
        {
            lab_pickFileName.Text = "";
            lab_savePath.Text = "";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            File.Copy(@pickPath, @savePath + @"\" + @pickName, true);
            MessageBox.Show("复制成功");
        }

        private void lab_pickFileName_Click(object sender, EventArgs e)
        {
            this.btn_pickFile_Click( sender,  e);
        }

        private void lab_savePath_Click(object sender, EventArgs e)
        {
            this.btn_copyTo_click(sender, e);
        }
    }
}
