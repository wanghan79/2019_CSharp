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

namespace FileWork
{
    public partial class FileWorkMain : Form
    {
        public static string m_strPath = String.Empty;
        public static string m_strFileName = String.Empty;
        public delegate void RefreshFileList(object sender);

        public FileWorkMain()
        {
            InitializeComponent();
            tb_FilePath.Text = "请输入路径！";
            tb_FilePath.ForeColor = Color.Gray;
            tb_SearchFile.Text = "请输入搜索内容！";
            tb_SearchFile.ForeColor = Color.Gray;
            
        }

        public void MyDelay(int millisecond)
        {
            int i = Environment.TickCount;
            while (Environment.TickCount - i < millisecond)
            {
                Application.DoEvents();
            }
        }

        //FilePath 文本框焦点移入
        private void tb_FilePath_Enter(object sender, EventArgs e)
        {
            tb_SearchFile.Text = "请输入搜索内容！";
            tb_SearchFile.ForeColor = Color.Gray;

            if(tb_FilePath.Text!="")
            {
                tb_FilePath.Text = "";
                tb_FilePath.ForeColor = Color.Black;
            }
           
        }

        //FilePath 文本框焦点移出
        private void tb_FilePath_Leave(object sender, EventArgs e)
        {
            if (tb_FilePath.Text == "")
            {
                tb_FilePath.Text = "请输入路径！";
                tb_FilePath.ForeColor = Color.Gray;

            }
        }

        //SearchFile文本框焦点移出
        private void tb_SearchFile_Leave(object sender, EventArgs e)
        {
            if(tb_SearchFile.Text == "")
            {
                tb_SearchFile.Text = "请输入搜索内容！";
                tb_SearchFile.ForeColor = Color.Gray;
            }
        }

        //转到给定路径
        private void bt_Goto_Click(object sender, EventArgs e)
        {
            tb_SearchFile.Text = "请输入搜索内容！";
            tb_SearchFile.ForeColor = Color.Gray;
            if (tb_FilePath.Text == "请输入路径！" || tb_FilePath.Text == "")
            {
                MessageBox.Show("路径为空!");

            }
            else
            {
                pgb_isFinish.Value = 0;
                ckb_isFinish.Checked = false;
                lbl_isFinish.Text = "文件搜索中……";

                m_strPath = tb_FilePath.Text;
                DirectoryInfo TheFolder = new DirectoryInfo(m_strPath);

                if (TheFolder.Exists)
                {
                    SearchFiles(this);
                    tb_FilePath.Text = "当前路径：" + tb_FilePath.Text;
                }
                else
                {
                    MessageBox.Show("路径不存在，请重新输入！");
                    tb_FilePath.Text = "请输入路径！";
                    tb_FilePath.ForeColor = Color.Gray;
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
                pgb_isFinish.Value = 0;
                ckb_isFinish.Checked = false;
                lbl_isFinish.Text = "文件搜索中……";
                if (m_strPath == dialog.SelectedPath)
                {

                }
                else
                {
                    m_strPath = dialog.SelectedPath;
                    tb_FilePath.Text = "请输入路径！";
                    tb_FilePath.ForeColor = Color.Gray;
                    tb_SearchFile.Text = "请输入搜索内容！";
                    tb_SearchFile.ForeColor = Color.Gray;
                    SearchFiles(this);
                }
            }
        }

        public static void SearchFiles(object obj)
        {
            FileWorkMain thisform = (FileWorkMain)obj;
            string text = thisform.tb_SearchFile.Text;

            DirectoryInfo TheFolder = new DirectoryInfo(m_strPath);
            DirectoryInfo[] Subfolders = TheFolder.GetDirectories();
            
            if (TheFolder.Exists)
            {
                thisform.pgb_isFinish.Value += thisform.pgb_isFinish.Step;
                try
                {
                    thisform.lvw_FileList.Items.Clear();
                    foreach (System.IO.FileInfo NextFile in TheFolder.GetFiles())
                    {
                        if(text != "请输入搜索内容！")
                        {
                            if (NextFile.ToString().Contains(text))
                            {
                                ListViewItem item = new ListViewItem();

                                item.Text = NextFile.FullName;
                                item.SubItems.Add(NextFile.LastAccessTime.ToString());
                                item.SubItems.Add(GetFileType(NextFile.Name));

                                thisform.lvw_FileList.Items.Add(item);
                            }
                        }
                        else
                        {
                            ListViewItem item = new ListViewItem
                            {
                                Text = NextFile.FullName
                            };
                            item.SubItems.Add(NextFile.LastAccessTime.ToString());
                            item.SubItems.Add(GetFileType(NextFile.Name));

                            thisform.lvw_FileList.Items.Add(item);
                        }
                    }
                    /*不建议的处理方式
                    //SearchInSubfolders s = new SearchInSubfolders
                    //{
                    //    FlieList = FileList,
                    //    text = text
                    //};
                    ////////Control.CheckForIllegalCrossThreadCalls = false;
                    //Thread t = new Thread(new ThreadStart(s.Search));
                    //t.Start();
                     */
                    Thread thread = new Thread(new ParameterizedThreadStart(SearchInSubfolders));
                    thread.Start(thisform);

                    RefreshFileList update = new RefreshFileList(SearchInSubfolders);
                    thisform.Invoke(update, thisform);
                }
                catch { }
                while (thisform.pgb_isFinish.Value < thisform.pgb_isFinish.Maximum) 
                {
                    thisform.pgb_isFinish.Value += thisform.pgb_isFinish.Step;
                    //MessageBox.Show(thisform.pgb_isFinish.Value.ToString());
                }
                
                if (thisform.pgb_isFinish.Value == 100)
                {
                    thisform.MyDelay(600);
                    thisform.ckb_isFinish.Checked = true;
                    thisform.lbl_isFinish.Text = "文件搜索或查询已完成";
                    //MessageBox.Show("sss");
                }
            }
            else
            {
                MessageBox.Show("文件夹不存在");
            }
        }

        public static void SearchInSubfolders(object obj)
        {
            FileWorkMain thisform = (FileWorkMain)obj;
            string text =thisform.tb_SearchFile.Text;
            
            DirectoryInfo TheFolder = new DirectoryInfo(m_strPath);
            DirectoryInfo[] Subfolders = TheFolder.GetDirectories();

            if(thisform.InvokeRequired)
            {
                RefreshFileList delegateFunc = new RefreshFileList(SearchInSubfolders);
                thisform.Invoke(delegateFunc,thisform);
            }
            else
            {
                try
                {
                    for (int i = 0; i < Subfolders.Length; i++)
                    {
                        thisform.pgb_isFinish.Value += thisform.pgb_isFinish.Step;
                        foreach (System.IO.FileInfo NextFile in Subfolders[i].GetFiles())
                        {
                            if (text != "请输入搜索内容！")
                            {
                                if (NextFile.ToString().Contains(text))
                                {
                                    ListViewItem item = new ListViewItem
                                    {
                                        Text = NextFile.FullName
                                    };
                                    item.SubItems.Add(NextFile.LastAccessTime.ToString());
                                    item.SubItems.Add(GetFileType(NextFile.Name));

                                    thisform.lvw_FileList.Items.Add(item);
                                }
                            }
                            else
                            {
                                ListViewItem item = new ListViewItem();

                                item.Text = NextFile.FullName;
                                item.SubItems.Add(NextFile.LastAccessTime.ToString());
                                item.SubItems.Add(GetFileType(NextFile.Name));

                                thisform.lvw_FileList.Items.Add(item);
                            }
                        }
                    }
                }
                catch { }         
            }
        }

        //SearchFile 文本框焦点移入
        private void tb_SearchFile_Enter(object sender, EventArgs e)
        {
            tb_SearchFile.Text = "";
            tb_SearchFile.ForeColor = Color.Black;
        }

        //点击查询
        private void bt_Search_Click(object sender, EventArgs e)
        {
            if (tb_SearchFile.Text == "请输入搜索内容！" || tb_SearchFile.Text == "")
            {
                MessageBox.Show("搜索内容为空!");

            }
            else
            {
                pgb_isFinish.Value = 0;
                ckb_isFinish.Checked = false;
                lbl_isFinish.Text = "文件查询中……";
                SearchFiles(this);
                tb_SearchFile.Text = "当前搜索内容：" + tb_SearchFile.Text;
            }
        }

        //双击预览文件详情
        private void FileList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            m_strFileName = lvw_FileList.SelectedItems[0].Text;
            FileInfo fi = new FileInfo();
            fi.Show();
        }

        //点击打开文件
        private void bt_OpenFile_Click(object sender, EventArgs e)
        {
            if (lvw_FileList.SelectedItems.Count == 0)
                return;
            else
            {
                string str_fileName = lvw_FileList.SelectedItems[0].Text;
                try
                {
                    System.Diagnostics.Process.Start(str_fileName);
                }
                catch
                {
                    MessageBox.Show("找不到默认应用程序以打开此文件！");
                }
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
        private void pgb_isFinish_Load(object sender, EventArgs e)
        {
            pgb_isFinish.Maximum = 100;//设置最大长度值
            pgb_isFinish.Value = 50;//设置当前值
            pgb_isFinish.Step = 5;//设置没次增长多少

        }
        
    }
    //class SearchInSubfolders
    //{
    //    public ListView FlieList;
    //    public string text;
    //    public static string m_Path = FileWorkMain.m_Path;
    //    public void Search()
    //    {
    //        DirectoryInfo TheFolder = new DirectoryInfo(m_Path);
    //        DirectoryInfo[] Subfolders = TheFolder.GetDirectories();
    //        for (int i = 0; i < Subfolders.Length; i++)
    //        {
    //            foreach (System.IO.FileInfo NextFile in Subfolders[i].GetFiles())
    //            {
    //                //MessageBox.Show(NextFile.FullName);
    //                if (this.text != "请输入搜索内容！")
    //                {
    //                    if (NextFile.ToString().Contains(this.text))
    //                    {
    //                        ListViewItem item = new ListViewItem();

    //                        item.Text = NextFile.FullName;
    //                        item.SubItems.Add(NextFile.LastAccessTime.ToString());
    //                        item.SubItems.Add(FileWorkMain.GetFileType(NextFile.Name));

    //                        this.FlieList.Items.Add(item);
    //                    }
    //                }
    //                else
    //                {
    //                    ListViewItem item = new ListViewItem();

    //                    item.Text = NextFile.FullName;
    //                    item.SubItems.Add(NextFile.LastAccessTime.ToString());
    //                    item.SubItems.Add(FileWorkMain.GetFileType(NextFile.Name));

    //                    this.FlieList.Items.Add(item);
    //                }
    //            }
    //        }
    //    }
    //}

}
