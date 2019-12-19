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

namespace Open_Search_ListBox
{
    public partial class MainForm : Form
    {
        string chose;
        public MainForm()
        {
            InitializeComponent();
        }

        private void LookFile(string pathname)//迭代列出文件
        {
            string[] files = Directory.GetFileSystemEntries(pathname);
            try
            {
                foreach(string dir in files)
                {
                    if(Directory.Exists(dir))//判断是否为目录，是目录就继续递归
                    {
                        LookFile(dir);
                    }
                    else
                    {
                        ListBox.Items.Add(dir);//是文件就加入listbox中
                    }
                }
            }
            catch(Exception ex)
            {
                ex.ToString();//防止有些文件无权限访问，屏蔽异常
            }
        }
       private void ChoseFile(string pathname,string a)//迭代筛选文件
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
                        if(dir.EndsWith(chose))//筛选条件
                        {
                            ListBox.Items.Add(dir);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();//防止有些文件无权限访问，屏蔽异常
            }
        }

        private void btChoseFile_Click(object sender, EventArgs e)//选择文件夹按钮被点击
        {
              ListBox.Items.Clear();
              if (txChoseFile.Text == string.Empty)
              {
                  FolderBrowserDialog dialog = new FolderBrowserDialog();
                  dialog.Description = "请选择文件夹";
                  if (dialog.ShowDialog() == DialogResult.OK)
                  {
                      string foldpath = dialog.SelectedPath;
                      DirectoryInfo files = new DirectoryInfo(foldpath);
                      txChoseFile.Text = files.ToString();
                      LookFile(files.ToString());
                  }
              }
              else
              {
                  string filepath = txChoseFile.Text;
                  LookFile(filepath);
              }
            
        }


        private void btChose_Click(object sender, EventArgs e)//筛选按钮被点击
        {
            ListBox.Items.Clear();
            string text = txChose.Text.ToString();
            if(text[0]=='*')
            {
                int index = text.LastIndexOf('*');
                chose = text.Substring(index + 1);
            }
            else
            {
                chose = text;
            }
            ChoseFile(txChoseFile.Text.ToString(),chose);
        }

        private void btOpenFile_Click(object sender, EventArgs e)//文件打开按钮被点击
        {
            string Chose_FileName = ListBox.SelectedItem.ToString();
            System.Diagnostics.Process.Start(Chose_FileName);
        }

        private void ListBox_DoubleClick(object sender, EventArgs e)//双击文件打开，附时间控件
        {
            string selectFile = ListBox.SelectedItem.ToString();
            FileShow formRead = new FileShow();
            formRead.textboxText = File.ReadAllText(selectFile);    
            formRead.Show();
        }
    }
}
