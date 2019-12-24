/*
 *功能：1.实现委托
 *      2.实现多线程
 *      3.搜索自定义路径下所有文件及其子文件
 *      4.搜索指定下拉后缀类型文件
 *      5.打开文件方式：①双击打开弹出新窗口展示详细内容
 *                      ②打开资源管理器   
 *      6.添加进度条
 *      7.添加cskin美化外观
 *作者：沈萌
 *时间：2019.12.13
 */
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

namespace SearchFileApplication
{
    public partial class SearchFile : Form
    {
        string chose;
        public static List<string> files;
        public event redraw finish;
        public delegate void redraw(object sender);

        public SearchFile()
        {
            InitializeComponent();
            files = new List<string>();         
            finish += new redraw(RedrawListBox);          
        }

        private void RedrawListBox(object sender)
        {
            if (this.InvokeRequired)
            {
                redraw delegateFunc = new redraw(RedrawListBox);
                this.Invoke(delegateFunc, sender);
            }
            else
            {
                ListBox.Items.Clear();
                ListBox.Items.AddRange(files.ToArray());
            }
        }

        /*
         * 功能：主窗体
         */
        private void SearchFile_Load(object sender, EventArgs e)
        {

        }

       
        /*
         * 功能：扫描文件及其子文件
         */
        public static int count;//统计文件数量
        public delegate void scanEventHandler(object pathname);
        private void scan(object pathname)
        {
            string dirPath = pathname.ToString();
            SearchFile thisForm = (SearchFile)pathname;
            dirPath = thisForm.PathTextBox.Text;
            if (dirPath != null && dirPath.Length > 0)
            {
                if (Directory.Exists(dirPath))
                {
                    files.Clear();
                    List<string> Files = new List<string>();
                    List<string> Dirs = new List<string>();
                    Dirs.Add(dirPath);
                    while (Dirs.Count > 0)
                    {
                        try
                        {
                            string searchDir = Dirs[0];
                            Dirs.RemoveAt(0);
                            string[] file = Directory.GetFiles(searchDir);
                            string[] dir = Directory.GetDirectories(searchDir);
                            foreach (string item in file)
                                Files.Add(item);
                            foreach (string item in dir)
                            {
                                Dirs.Add(item);
                                count++;
                            }
                        }
                        catch (Exception ex)
                        {
                            ex.ToString();
                        }
                       
                    } 
                    //MessageBox.Show(count.ToString());
                    files.AddRange(Files);
                    setListBoxEventHanlder up = new setListBoxEventHanlder(thisForm.setListBox);
                    thisForm.BeginInvoke(up, thisForm);
                    thisForm.Invoke(up, thisForm);
                    thisForm.finish(thisForm);
                    Thread.Sleep(1000);

                }
            }
        }

        
        /*
         * 功能：委托
         */
        public delegate void setListBoxEventHanlder(object pathname);
        private void setListBox(object pathname)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new setListBoxEventHanlder(setListBox), pathname);
            }
            else
            {
                ListBox.Items.Clear();
                this.ListBox.Items.Add(pathname.ToString());
            }
        }
      

     

       /*
        * 功能：实现对指定后缀文件进行搜索
        */
       private void ChoseenSearch(string pathname,string a)
        {
            string[] files = Directory.GetFileSystemEntries(pathname);
            try
            {
                foreach (string dir in files)
                {
                    if (Directory.Exists(dir))
                    {
                        ChoseenSearch(dir, chose);
                    }
                    else
                    {
                        if(dir.EndsWith(chose))
                        {
                            ListBox.Items.Add(dir);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

       /*
        * 控件：listbox
        * 功能：双击打开文件弹出带有详细内容和时钟的窗口
        */
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectFile = ListBox.SelectedItem.ToString();
            FileList detailfile = new FileList();
            detailfile.textboxText = File.ReadAllText(selectFile, Encoding.GetEncoding("GB2312"));
            detailfile.Show();
        }

        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinLabel1_Click(object sender, EventArgs e)
        {

        }

        /*
         * 控件：button
         * 功能：实现点击之后在下方listbox中展示指定后缀文件列表
         */
        private void ChooseButton1_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();
            string text = skinComboBox1.SelectedItem.ToString();
            if (text[0] == '*')
            {
                int index = text.LastIndexOf('*');
                chose = text.Substring(index + 1);
            }
            else
            {
                chose = text;
            }
            ChoseenSearch(PathTextBox.Text.ToString(), chose);
        }

        /*
         * 控件：button
         * 功能：实现打开文件
         */
        private void OpenButton1_Click(object sender, EventArgs e)
        {
            string file = ListBox.SelectedItem.ToString();         
            System.Diagnostics.Process.Start(file);
        }

        /*
         * 控件：button
         * 功能：打开资源管理器->打开文件
         */

        /*
         * 功能：模拟进度条
         */
        private void Send()
        {
            int i = 0;
            while (i <= count)
            {
                //显示进度信息
                this.ShowPro(i);
                if (i < count / 10)
                    i++;
                else
                    i = 100;
                Thread.Sleep(50);
            }
            Thread.CurrentThread.Abort();
        }

        private delegate void ProgressBarShow(int i);
        private void ShowPro(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ProgressBarShow(ShowPro), value);
            }
            else
            {
                this.progressBar1.Value = value;
            }
        }

        private void OpenSrcButton1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                PathTextBox.Text = folderDlg.SelectedPath;
            }
            //搜索线程
            Thread thread = new Thread(new ParameterizedThreadStart(scan));
            thread.Start(this);
            //进度条线程
            Thread thread1 = new Thread(new ThreadStart(Send)); //模拟进度条
            thread1.IsBackground = true;
            thread1.Start();  
        }
     
        
        /*
         * 控件：combobox
         * 功能：实现下拉列表选择文件后缀类型
         */
        private void skinComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
             所有文件|*.*|
             压缩文件|*.zip;*.rar;*.arj|
             文本文档|*.txt;*.pdf;*.doc;*.html;*.wps;*.rtf|
             图片文件|*.jpg;*.png;*.gif;*.jpeg;*.bmp|
             视频文件|*.avi;*.mp3;*.swf;*.mpg;*.mov|
             系统文件|*.int;*.sys;*.dll;*.adt|
             可执行文件|*.exe;*.com;*.bat;*.vbs";
             */
        }

        /*
         * 控件：button
         * 功能：清空输入路径
         */
        private void ClearButton1_Click(object sender, EventArgs e)
        {
            PathTextBox.Text = " ";
        }




        public object pathname { get; set; }

        public object thisForm { get; set; }

        /*
         * 控件：label
         * 功能：搜索进度
         */

        private void progressLabel4_Click(object sender, EventArgs e)
        {

        }
        /*
         * 控件：progressbar
         * 功能：搜索进度条
         */       
        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
        

        /*
         * 控件：backgroundwoker
         * 功能：后台进度
         */
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }
    }
}
