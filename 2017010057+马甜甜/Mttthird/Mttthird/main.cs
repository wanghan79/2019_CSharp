using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Mttthird
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            //searchedFiles = new List<string>();
            ////第二种委托方式调用代码
            //searchComplete += new refreshListBoxHanlder(updateListBox);
        }

        private void labfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btsavefile_Click(object sender, EventArgs e)
        {
            string keyword = txKeyWord.Text;
            if (keyword != null && keyword.Length > 0)
            {

            }
        }

        private void btopenflie_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if (folderDlg.ShowDialog() == DialogResult.OK)//选择要搜索的文件夹
            {
                txDir.Text = folderDlg.SelectedPath;//在界面显示该文件夹
            }
            //启动文件搜索线程
            Thread thread = new Thread(new ParameterizedThreadStart(searchFilesinFolder));
            thread.Start(this);
            //searchFilesinFolder(txDir.Text);
        }
         
        public static void searchFilesinFolder(object obj)//文件搜索线程调用的函数
        {
            string strDir = obj.ToString();
            main thisForm = (main)obj;
            strDir = thisForm.txDir.Text;//待搜索文件夹路径
            if (strDir!=null && strDir.Length>0)
            {
                if(Directory.Exists(strDir))
                {
                    //searchedFiles.Clear();
                    List<string> allSearcheFiles = new List<string>();//用于存放所有搜索出来的文件
                    List<string> folders2Search = new List<string>();//用于存放所有待搜索的文件夹
                    folders2Search.Add(strDir);
                    while(folders2Search.Count>0)
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
                    //searchedFiles.AddRange(allSearcheFiles);
                    //第一种传递方式：直接委托调用
                    //refreshListBoxHanlder updateDelegate = new refreshListBoxHanlder(thisForm.updateListBox);
                    //thisForm.Invoke(updateDelegate, thisForm);
                    //第二种传递方式：基于委托的消息机制
                    //thisForm.searchComplete(thisForm);
                }
            }
        }

         //private void updateListBox(object sender)
         //{
             //第一种委托方式调用代码
             //lsbFiles.Items.Clear();
             //lsbFiles.Items.AddRange(searchedFiles.ToArray());

             //第二种委托方式调用代码
            //{
                // refreshListBoxHanlder delegateFunc = new refreshListBoxHanlder(updateListBox);
                // this.Invoke(delegateFunc, sender);
             }
           //  else
             //{
               //  labfiles.Items.Clear();
              //   labfiles.Items.AddRange(searchedFiles.ToArray());
             }
        // }
       //  public delegate void refreshListBoxHanlder(object sender);
         //public event refreshListBoxHanlder searchComplete;
        //public static List<string> searchedFiles;

        //private void lsbFiles_SelectedIndexChanged(object sender, EventArgs e)
        //{

       // }
   // }
//}
    

