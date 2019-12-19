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

namespace 多线程list文件夹下的文件
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            searchALLFiles = new List<string>();
            searchComplete += new refreshListBoxHandler(updateListBox);
        }

        public static void searchFile(object obj)
        {
            string dirPath = obj.ToString();
            MainForm thisForm = (MainForm)obj;
            dirPath = thisForm.txbFilePath.Text;
            if(dirPath!=null&&dirPath.Length>0)
            {
                if(Directory.Exists(dirPath))
                {
                    searchALLFiles.Clear();
                    List<string> Files = new List<string>();
                    List<string> Dirs = new List<string>();
                    Dirs.Add(dirPath);
                    while(Dirs.Count>0)
                    {
                        try
                        {
                            string searchDir = Dirs[0];
                            Dirs.RemoveAt(0);
                            string[] files = Directory.GetFiles(searchDir);
                            string[] dirs = Directory.GetDirectories(searchDir);
                            foreach (string item in files)
                                Files.Add(item);
                            foreach (string item in dirs)
                                Dirs.Add(item);
                        }
                        catch {  }
                    }
                    searchALLFiles.AddRange(Files);
                    //  法一
                    //refreshListBoxHandler updateDelegate = new refreshListBoxHandler(thisForm.updateListBox);
                    //thisForm.Invoke(updateDelegate, thisForm);
                    //  法二
                    thisForm.searchComplete(thisForm);
                }
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if(folderDlg.ShowDialog()==DialogResult.OK)
            {
                txbFilePath.Text = folderDlg.SelectedPath;
            }
            Thread thread = new Thread(new ParameterizedThreadStart(searchFile));
            thread.Start(this);
            //searchFile(txbFilePath.Text);
            progressBar.Value = 0;
            ProcessBarTimer.Enabled = true;
        }
        private void updateListBox(object sender)
        {
            if(this.InvokeRequired)
            {
                refreshListBoxHandler delegateFunc = new refreshListBoxHandler(updateListBox);
                this.Invoke(delegateFunc, sender);
            }
            else
            {
                lsbFile.Items.Clear();
                lsbFile.Items.AddRange(searchALLFiles.ToArray());
            }
        }

        public static List<string> searchALLFiles;
        public event refreshListBoxHandler searchComplete;
        public delegate void refreshListBoxHandler(object sender);

        //筛选
        private void ChoseFile(string pathname, string a)//迭代筛选文件
        {
            string[] files = Directory.GetFileSystemEntries(pathname);
            try
            {
                foreach (string dir in files)
                {
                    if (Directory.Exists(dir))//判断是否为目录，是目录就继续递归
                    {
                        ChoseFile(dir, chose);
                    }
                    else
                    {
                        if (dir.EndsWith(chose))//筛选条件
                        {
                            lsbFile.Items.Add(dir);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();//防止有些文件无权限访问，屏蔽异常
            }
        }

        //筛选
        private void btChose_Click_1(object sender, EventArgs e)
        {
            lsbFile.Items.Clear();
            string text = txChoseFile.Text.ToString();
            if (text[0] == '*')
            {
                int index = text.LastIndexOf('*');
                chose = text.Substring(index + 1);
            }
            else
            {
                chose = text;
            }
            ChoseFile(txbFilePath.Text.ToString(), chose);
        }

        string chose;

        //打开
        private void btOpenFile_Click(object sender, EventArgs e)
        {
            string Chose_FileName = lsbFile.SelectedItem.ToString();
            System.Diagnostics.Process.Start(Chose_FileName);
        }

        private void ProcessBarTimer_Tick(object sender, EventArgs e)
        {
            int i = 100;
            progressBar.Value = progressBar.Value + 1;
            i = 100 - progressBar.Value;
            if (i == 0)
            {
                ProcessBarTimer.Enabled = false;
            }

        }
    }
}
