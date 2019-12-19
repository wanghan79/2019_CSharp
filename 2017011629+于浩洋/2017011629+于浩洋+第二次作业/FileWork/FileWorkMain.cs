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
    public partial class FileWorkMain : Form
    {
        public static string m_strPath = String.Empty;
        public static string m_strFileName = String.Empty;

        public FileWorkMain()
        {
            InitializeComponent();
            tb_FilePath.Text = "请输入路径！";
            tb_FilePath.ForeColor = Color.Gray;
            tb_SearchFile.Text = "请输入搜索内容！";
            tb_SearchFile.ForeColor = Color.Gray;
        }

        //FilePath 文本框焦点移入
        private void tb_FilePath_Enter(object sender, EventArgs e)
        {
            tb_SearchFile.Text = "请输入搜索内容！";
            tb_SearchFile.ForeColor = Color.Gray;

            tb_FilePath.Text = "";
            tb_FilePath.ForeColor = Color.Black;
        }

        //FilePath 文本框焦点移出
        private void tb_FilePath_Leave(object sender, EventArgs e)
        {
            tb_FilePath.Text = "请输入路径！";
            tb_FilePath.ForeColor = Color.Gray;
        }

        //SearchFile 文本框焦点移入
        private void tb_SearchFile_Enter(object sender, EventArgs e)
        {
            tb_SearchFile.Text = "";
            tb_SearchFile.ForeColor = Color.Black;
        }

        //转到给定路径
        private void bt_Goto_Click(object sender, EventArgs e)
        {
            tb_SearchFile.Text = "请输入搜索内容！";
            tb_SearchFile.ForeColor = Color.Gray;
            if (tb_FilePath.Text == "请输入路径！" || tb_FilePath.Text == "") 
            {
                MessageBox.Show("路径为空!");
                tb_FilePath.Text = "请输入路径！";
                tb_FilePath.ForeColor = Color.Gray;

            }
            else
            {
                m_strPath = tb_FilePath.Text;
                DirectoryInfo TheFolder = new DirectoryInfo(m_strPath);
                if (TheFolder.Exists)
                {
                    lvw_FileList.Items.Clear();
                    foreach (System.IO.FileInfo NextFile in TheFolder.GetFiles())
                    {
                        ListViewItem item = new ListViewItem();

                        item.Text = NextFile.ToString();
                        item.SubItems.Add(NextFile.LastAccessTime.ToString());
                        item.SubItems.Add(GetFileType(NextFile.Name));

                        lvw_FileList.Items.Add(item);
                    }
                    tb_FilePath.Text = "当前路径：" + tb_FilePath.Text;
                }
                else
                {
                    MessageBox.Show("路径不存在，请重新输入！");
                }
            }
        }

        //于文件资源管理器中打开指定文件夹
        private void bt_FolderBrowser_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件夹";
            dialog.ShowNewFolderButton = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                m_strPath = dialog.SelectedPath;
            }
            if (m_strPath == String.Empty)
            {
                MessageBox.Show("路径为空，请重新选择！");
            }
            else
            {
                DirectoryInfo TheFolder = new DirectoryInfo(m_strPath);
                if (TheFolder.Exists)
                {
                    lvw_FileList.Items.Clear();
                    foreach (System.IO.FileInfo NextFile in TheFolder.GetFiles())
                    {
                        ListViewItem item = new ListViewItem();

                        item.Text = NextFile.Name;
                        item.SubItems.Add(NextFile.LastAccessTime.ToString());
                        item.SubItems.Add(GetFileType(NextFile.Name));

                        lvw_FileList.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("文件夹不存在");
                }
            }
        }

        //点击查询
        private void bt_Search_Click(object sender, EventArgs e)
        {
            if (tb_SearchFile.Text == "请输入搜索内容！"|| tb_SearchFile.Text == "")
            {
                MessageBox.Show("搜索内容为空!");
                tb_SearchFile.Text = "请输入搜索内容！";
                tb_SearchFile.ForeColor = Color.Gray;

            }
            else
            {
                DirectoryInfo TheFolder = new DirectoryInfo(m_strPath);
                //遍历文件
                if (TheFolder.Exists)
                {
                    lvw_FileList.Items.Clear();
                    foreach (System.IO.FileInfo NextFile in TheFolder.GetFiles())
                    {
                        if (NextFile.ToString().Contains(tb_SearchFile.Text))
                        {
                            ListViewItem item = new ListViewItem();

                            item.Text = NextFile.ToString();
                            item.SubItems.Add(NextFile.LastAccessTime.ToString());
                            item.SubItems.Add(GetFileType(NextFile.Name));

                            lvw_FileList.Items.Add(item);
                        }
                    }
                }
                tb_SearchFile.Text = "当前搜索内容：" + tb_SearchFile.Text;
            }
        }

        //点击打开文件
        private void bt_OpenFile_Click(object sender, EventArgs e)
        {
            if (lvw_FileList.SelectedItems.Count == 0)
                return;
            else
            {
                string FileName = lvw_FileList.SelectedItems[0].Text;
                System.Diagnostics.Process.Start(m_strPath + "\\" + FileName);
            }
        }

        //为不同的文件创建相应的文件类型
        public static string GetFileType(string filename)
        {
            string filetype = Path.GetExtension(filename);
            if (filetype == ".doc" || filetype == ".docx" || filetype == ".txt"
                || filetype == ".ppt" || filetype == ".pptx" || filetype == ".xls"
                || filetype == ".xlsx" || filetype == ".pdf")
            {
                return "文档";
            }
            if (filetype == ".zip" || filetype == ".rar" || filetype == ".7z")
            {
                return "压缩文件";
            }
            if (filetype == ".jpg" || filetype == ".jpeg" || filetype == ".png")
            {
                return "图片";
            }
            if (filetype == ".mp3" || filetype == ".wav" || filetype == ".flac")
            {
                return "音频";
            }
            if (filetype == ".mp4" || filetype == ".avi" || filetype == ".wmv")
            {
                return "视频";
            }
            if (filetype == ".exe")
            {
                return "可执行文件";
            }
            return "其他" + "(" + filetype + ")";
        }
    }
}
