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

namespace FileManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //
        //功能函数模块
        //

        private void GetFile()
        {
            if (this.listVwFilelist.Items.Count > 0)
                this.listVwFilelist.Items.Clear();

            string strDir = this.tboxFilePath.Text;

            if (strDir != null && strDir.Length > 0)
            {
                if (Directory.Exists(strDir))
                {
                    //定义文件夹队列
                    List<string> queueFolder = new List<string>();

                    //加入当前文件夹路径
                    queueFolder.Add(strDir);
                    while (queueFolder.Count > 0)
                    {
                        try
                        {
                            //获取队列头文件夹路径
                            string curFolder = queueFolder[0];

                            //移除队列
                            queueFolder.RemoveAt(0);

                            //获取当前路径文件夹
                            string[] dirs = Directory.GetDirectories(curFolder);

                            //对队列头的路径进行添加
                            DirectoryInfo TheFolder = new DirectoryInfo(curFolder);
                            foreach (FileInfo CurrentFile in TheFolder.GetFiles())
                            {
                                FileInfo file = new FileInfo(this.tboxFilePath.Text + CurrentFile.Name);
                                string fileType = Path.GetExtension(CurrentFile.Name);
                                ListViewItem item = new ListViewItem(this.tboxFilePath.Text + "\\" + CurrentFile.Name + "\\" + CurrentFile.Name);
                                item.SubItems.Add(fileType);
                                item.SubItems.Add(CurrentFile.Name);
                                item.SubItems.Add(CurrentFile.LastWriteTime.ToString());
                                listVwFilelist.Items.Add(item);
                            }

                            //将当前路径的文件夹路径加入队列
                            foreach (string item in dirs)
                                queueFolder.Add(item);
                        }
                        catch { }
                    }

                    //refreshListBoxHanlder updateDelegate = new refreshListBoxHanlder(thisForm.updateListBox);
                    //thisForm.Invoke(updateDelegate, thisForm);
                    //thisForm.searchComplete(thisForm);
                }
            }
        }

        private void SearchFile()
        {
            string keyword = tboxSearch.Text;
            if ( keyword != null & keyword.Length > 0 )
            {
                for (int i = 0; i < listVwFilelist.Items.Count; i++)
                {
                    //处理Item   
                    ListViewItem item = listVwFilelist.Items[i];

                    //item.SubItems[2]为文件名称
                    if (!item.SubItems[2].ToString().Contains(keyword))
                    {
                        item.Remove();
                        //此处因移除item项目，listVwFilelist.Items.Count数目在减小
                        //在没碰到符合的item项目时，偏移量i始终不变
                        i--;

                    }
                }
            }
        }


        //
        //按钮交互功能板块
        //     

        //tboxFilePath响应回车
        private void tboxFilePath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!Directory.Exists(this.tboxFilePath.Text))
                {
                    MessageBox.Show("路径不存在！");
                    tboxFilePath.Text = "请输入路径";
                    tboxFilePath.ForeColor = Color.Gray;
                }
                else
                {
                    //GetFile();
                    // create one thread
                    Thread t = new Thread(new ThreadStart(GetFile));
                    // invoke this thread
                    t.Start();
                }
            }
            //TODO 输出的异常处理，路径的合法性
        }
        
        //tboxSearch响应回车
        private void tboxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tboxSearch.Text == null)
                {
                    MessageBox.Show("搜索内容为空!");
                }
                else
                {
                    SearchFile();
                }
            }
        }

        //双击，打开文件窗体
        private void listVwFilelist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //可借用strPath静态字符串来传输路径
            //strPath = listVwFilelist.SelectedItems[0].Text;

            //此处使用类接口进行传递
            ContentForm Form = new ContentForm(listVwFilelist.SelectedItems[0].Text);
            Form.Show();
        }

        //点击查找打开文件按钮
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderBrowser = new FolderBrowserDialog();
            if (FolderBrowser.ShowDialog() == DialogResult.OK)
            {
                this.tboxFilePath.Text = FolderBrowser.SelectedPath;
                this.tboxFilePath.ForeColor = Color.Black;

                //GetFile();
                Thread t = new Thread(new ThreadStart(GetFile));
                //// invoke this thread
                t.Start();
            }
        }

        //点击tboxFilePath时，非空时，重置为空
        private void tboxFilePath_Enter(object sender, EventArgs e)
        {
            if (tboxFilePath.Text != "")
            {
                tboxFilePath.Text = "";
                tboxFilePath.ForeColor = Color.Black;
            }
        }

        //点击tboxSearch时，非空时，重置为空
        private void tboxSearch_Enter(object sender, EventArgs e)
        {
            if (tboxSearch.Text != "")
            {
                tboxSearch.Text = "";
                tboxSearch.ForeColor = Color.Black;
            }
        }

        //移出路径tboxFilePath时，重置为提示信息
        private void tboxFilePath_Leave(object sender, EventArgs e)
        {
            if (tboxFilePath.Text == "")
            {
                tboxFilePath.Text = "请输入路径";
                tboxFilePath.ForeColor = Color.Gray;

            }
        }
        
        //移出路径tboxSearch时，重置为提示信息
        private void tBoxSearch_Leave(object sender, EventArgs e)
        {
            if (tboxSearch.Text == "")
            {
                tboxSearch.Text = "请输入搜索关键字";
                tboxSearch.ForeColor = Color.Gray;

            }
        }

    }
}
