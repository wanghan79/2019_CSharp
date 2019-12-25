using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyFiles
{
    public partial class ryyThread : Form
    {
        public ryyThread()
        {
            InitializeComponent();
            searchedFiles = new List<string>();
            searchComplete += new refresh_list_box_hanlder(update_list_box);
        }
        public delegate void refresh_list_box_hanlder(object sender);
        public event refresh_list_box_hanlder searchComplete;
        private void ShowFolder_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChsFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (m_dir_path != "")
            {
                //设置此次默认目录为上一次选中目录  
                dialog.SelectedPath = m_dir_path;
            }
            //按下确定选择的按钮  
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录  
                m_dir_path = dialog.SelectedPath;
            }
            ShowFolder.Text = m_dir_path;
            ShowFile.DataSource = null;
            Thread thSearch = new Thread(search_files_in_folder);
            thSearch.Start(this);
            ShowFile.DataSource = searchedFiles;

        }
        string m_dir_path="";
        private void FileType_TextChanged(object sender, EventArgs e)
        {
            string m_file_type = FileType.Text;
            int iIndex = m_file_type.LastIndexOf(".");
            m_str_type = m_file_type.Substring(iIndex + 1);
        }
        string m_str_type;
        private void ShowFile_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        public static List<string> type_files;
        private void search_list(string dir)
        {
            type_files = new List<string>();
            try {
                foreach (string file in searchedFiles)
                {
                    if(file.EndsWith(m_str_type))
                        type_files.Add(file);//若为指定类型文件则加入列表
                }
            }
            catch { }
        }
        public static List<string> searchedFiles;
        public static void search_files_in_folder(object obj)
        {
            string strDir = obj.ToString();
            ryyThread thisForm = (ryyThread)obj;
            strDir = thisForm.m_dir_path;
            if(strDir!=null&&strDir.Length>0)
            {
                if(Directory.Exists(strDir))
                {
                    searchedFiles.Clear();
                    List<string> allSearchFiles = new List<string>();
                    List<string> folders2Search = new List<string>();
                    folders2Search.Add(strDir);
                    while(folders2Search.Count>0)
                    {
                        try
                        {
                            string curFolder = folders2Search[0];
                            folders2Search.RemoveAt(0);
                            string[] files = Directory.GetFiles(curFolder);
                            string[] dirs = Directory.GetDirectories(curFolder);
                            foreach (string item in files)
                                allSearchFiles.Add(item);
                            foreach (string item in dirs)
                                folders2Search.Add(item);

                        }
                        catch { }
                    }
                    searchedFiles.AddRange(allSearchFiles);
                    thisForm.searchComplete(thisForm);
                }
            }
        }
        private void ListAll(string dir)
        {
            string[] files = Directory.GetFileSystemEntries(dir);
            try
            {
                foreach (string file in files)
                {
                    if (Directory.Exists(file))//若为子目录则继续递归
                        ListAll(file);
                    else
                    {
                        char[] chars = { '\\' };
                        ShowFile.Items.Add(file.Split(chars, StringSplitOptions.None).Last<string>());

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void update_list_box(object sender)
        {
            if (this.InvokeRequired)
            {
                refresh_list_box_hanlder delegateFunc = new refresh_list_box_hanlder(update_list_box);
                this.Invoke(delegateFunc, sender);
            }
            else
            {
                ShowFile.DataSource = null;
                ShowFile.DataSource = searchedFiles;
            }
        }

        private void btRunFile_Click(object sender, EventArgs e)
        {
            //启动指定文件 
            if (m_str_type == null)
                try
                {
                    System.Diagnostics.Process.Start(string.Concat(m_dir_path, '\\', ShowFile.SelectedItem.ToString()));
                }
                catch
                { }
            else
                System.Diagnostics.Process.Start(ShowFile.SelectedItem.ToString());
        }

        private void FileType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                string m_file_type = FileType.Text;
                int iIndex = m_file_type.LastIndexOf(".");
                if (m_file_type.IndexOf("*") == -1)
                    m_str_type = FileType.Text;
                else
                    m_str_type = m_file_type.Substring(iIndex);
                ShowFile.DataSource = null;
                search_list(m_dir_path);
                ShowFile.DataSource = type_files;
                e.Handled = true;
            }
        }

        private void ShowFile_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowCon showCon = new ShowCon();
            showCon.ShCon.Text = System.IO.File.ReadAllText(ShowFile.SelectedItem.ToString(), System.Text.Encoding.Default);
            showCon.CurTime.Text = DateTime.Now.ToLocalTime().ToString(); 
            showCon.ShowDialog();
        }
    }
}
