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

namespace FileInfo
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }
        private void labfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if(fd.ShowDialog()==DialogResult.OK)
            {
                txDir.Text = fd.SelectedPath;
            }
            Thread thread = new Thread(new ParameterizedThreadStart(searchFilesinFolder));
            thread.Start(this);
        }
        public static void searchFilesinFolder(object obj)//多线程文件搜索
        {
            string strDir = obj.ToString();
            MainFrom thisForm = (MainFrom)obj;
            strDir = thisForm.txDir.Text;//待搜索文件夹路径
            if (strDir != null && strDir.Length > 0)
            {
                if (Directory.Exists(strDir))
                {
                    //searchedFiles.Clear();
                    List<string> allSearcheFiles = new List<string>();//用于存放所有搜索出来的文件
                    List<string> folders2Search = new List<string>();//用于存放所有待搜索的文件夹
                    folders2Search.Add(strDir);
                    while (folders2Search.Count > 0)
                    {
                        try
                        {
                            string curFolder = folders2Search[0];
                            folders2Search.RemoveAt(0);
                            string[] files = Directory.GetFiles(curFolder);//搜索当前目录下所有文件
                            string[] dirs = Directory.GetDirectories(curFolder);//搜索当前目录下所有文件夹
                            foreach (string item in files)
                                allSearcheFiles.Add(item);
                            foreach (string item in dirs)
                                folders2Search.Add(item);
                        }
                        catch { }
                    }
                }
            }
        }

        private void txDir_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
