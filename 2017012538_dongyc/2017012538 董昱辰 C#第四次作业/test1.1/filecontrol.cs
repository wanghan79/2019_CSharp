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
using static System.Console;


namespace test1._1
{
    public partial class FormWindows : Form
    {
        public FormWindows()
        {
            InitializeComponent();
            searchList = new List<string>();
            //searchComplete += new refreashListBoxHanlder(updateListBox);
           // this.backgroundWorker1.WorkerReportsProgress = true;  //设置能报告进度更新
           // this.backgroundWorker1.WorkerSupportsCancellation = true;
        }
       // public event refreashListBoxHanlder searchComplete;

        static string[] Filename = new string [1000000];
        //static string[] LastName = new string [1000000];
        static string[] searchnames = new string[10000000];
        static int lastnum , filenum ;
        String path;
        static List<string> searchList;
        static List<string> LastName;
        double pos;


        public static void SearchFile(object paths)
        {
            string path = paths.ToString();
            FormWindows thisForm = (FormWindows)paths;
            path = thisForm.selectBox.Text;
            if(path!=null&&path.Length>0)
            {
                if (Directory.Exists(path))
                {
                    searchList = new List<string>();
                    searchList.Clear();
                    List<string> Filenames = new List<string>();
                    List<string> txtnames = new List<string>();
                    Filenames.Add(path);
                    while (Filenames.Count > 0)
                    {
                        try
                        {
                            string cur = Filenames[0];
                            Filenames.RemoveAt(0);
                            string[] files = Directory.GetFiles(cur);
                            string[] dir = Directory.GetDirectories(cur);
                            foreach (string item in files)
                                txtnames.Add(item);
                            foreach (string item in dir)
                                Filenames.Add(item);
                        }
                        catch { }
                    }
                    searchList.AddRange(txtnames);

                    for (int i = 0; i < searchList.Count; ++i)
                    {
                        searchnames[i] = searchList[i];
                    }
                    lastnum = 0;
                    filenum = 0;
                    string oneLastName;
                    LastName = new List<string>();
                    LastName.Clear();
                    foreach (string file in searchnames)
                    {
                        if (file!= null)
                        {
                            //MessageBox.Show(file.ToString()) ;
                            string filename = file.ToString();
                            oneLastName = filename.Substring(filename.LastIndexOf(".") + 1,
                                (filename.Length - filename.LastIndexOf(".") - 1)); //扩展名
                            //MessageBox.Show(aLastName);
                             if (oneLastName!=null &&!LastName.Contains(oneLastName.ToString()))
                                   LastName.Add(oneLastName);
                            Filename[filenum] = filename;
                            filenum++;
                        }
                        //bool flag = false;
                       
                    }

                    refreashListBoxHanlder updateDelegate = new refreashListBoxHanlder(thisForm.updateListBox);
                    thisForm.Invoke(updateDelegate, thisForm);
                  //  thisForm.searchComplete(thisForm);
                    //MessageBox.Show(searchList.ToString());
                }
            }
        }


        
        private void Search_Click(object sender, EventArgs e)
        {
            // SelectFunc();
            FolderBrowserDialog fd = new FolderBrowserDialog();
            if(fd.ShowDialog()==DialogResult.OK)
            {
                selectBox.Text = fd.SelectedPath;
            }

            Thread thread = new Thread(new ParameterizedThreadStart(SearchFile));
            thread.Start(this);
            //进度条
           // this.backgroundWorker1.RunWorkerAsync();  //运行backgroundWorker组件
          //  ProgressForm form = new ProgressForm(this.backgroundWorker1,pos);  //显示进度条窗体
           // form.ShowDialog(this);
           // form.Close();
            //SelectFunc();
        }
        public delegate void refreashListBoxHanlder(object sender);
        private void updateListBox(object sender)
        {
            if (this.InvokeRequired)
            {
                refreashListBoxHanlder delegateFunc = new refreashListBoxHanlder(updateListBox);
                this.Invoke(delegateFunc,sender);
            }
            else
            {
                confgBox.Items.Clear();
                confgBox.Items.AddRange(LastName.ToArray());
                fileBox.Items.Clear();
                fileBox.Items.AddRange(searchList.ToArray());
            }
        }

        public void SelectFunc()
        {
            confgBox.Items.Clear();
            path = selectBox.Text.ToString();
            for (int i = 0; i < searchList.Count; ++i)
            {
                searchnames[i] = searchList[i];
            }
            lastnum = 0;
            filenum = 0;
            foreach (string file in searchnames)
            {
                bool flag = false;
                //MessageBox.Show(file.ToString()) ;
                string filename = file.ToString();
                string aLastName = filename.Substring(filename.LastIndexOf(".") + 1,
                    (filename.Length - filename.LastIndexOf(".") - 1)); //扩展名
                for (int i = 0; i < lastnum; ++i)
                {
                    if (LastName[i] == aLastName)
                        flag = true;
                }
                if (!flag)
                {
                    LastName[lastnum] = aLastName;
                    confgBox.Items.Add(aLastName);
                    lastnum++;
                }
                Filename[filenum] = filename;
                filenum++;
            }
        }



        private void SelectBox_TextChanged(object sender, EventArgs e)
        {
            path=selectBox.Text.ToString();
        }
        int selectnum;
        string[] selectfile;

        private void FileBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileBox.MultiColumn = false;
            selectnum = fileBox.SelectedItems.Count;
            selectfile = new string[1000];
            for (int j = 0; j < selectnum; j++)
                selectfile[j] = fileBox.SelectedItems[j].ToString();
            for (int i = 0; i < selectnum; ++i)
            {
                //string filepath = path + "\\" + selectfile[i];
                string filepath = selectfile[i];
                //System.Diagnostics.Process.Start(filepath);
            }

        }
        private void OpenFile_Click(object sender, EventArgs e)
        {
            FnewWindows frm2 = new FnewWindows();
            frm2.Show();


            for (int i = 0; i < selectnum; ++i)
            {
                //string filepath = path + "\\" + selectfile[i];
                //System.Diagnostics.Process.Start(filepath);
                string filepath = selectfile[i];
                int num = 0;
                string sc = null;
                StringBuilder sb = new StringBuilder();
                using (StreamReader sr = new StreamReader(filepath, System.Text.Encoding.GetEncoding("gb2312")))
                {
                    while ((sc = sr.ReadLine()) != null)
                    {
                        sb.Append(sc);
                        num++;
                        if (num > 300)
                        { sr.Close(); }
                    }
                    frm2.NewBox.Text = sb.ToString();
                }
                /* while (true)
                 {
                     frm2.Time.Text = DateTime.Now.Second.ToString();
                     Application.DoEvents();
                     System.Threading.Thread.Sleep(100);
                 }*/
                frm2.timer1.Start();

            }
        }


        private void SelectBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }
        //进度条
      /*  private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int cur_count = 0;
            foreach(string name in LastName)
            {
                Thread.Sleep(800);
                ++cur_count;
                pos = (int)((double)cur_count / (double)LastName.ToArray().Length * 100);
                backgroundWorker1.ReportProgress(cur_count);
            }

            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 0; i < 100; i++)
            {
                System.Threading.Thread.Sleep(100);
                worker.ReportProgress(i);
                if (worker.CancellationPending) //获取程序是否已请求取消后台操作
                {
                    e.Cancel = true;
                    break;
                }
            }
        }*/
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("取消");
            }
            else
            {
                MessageBox.Show("完成");
            }
        }


        private void ConfgBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileBox.Items.Clear();
            confgBox.MultiColumn = true;
            int selectnum = confgBox.SelectedItems.Count;
            string[] selectconfg =new string[1000];
            for (int j = 0; j < selectnum; j++)
                selectconfg[j]= confgBox.SelectedItems[j].ToString();
           // MessageBox.Show(s);
           for(int i=0;i<filenum;++i)
            {
                string name = Filename[i];
                string lastName = name.Substring(name.LastIndexOf(".") + 1,
                        (name.Length - name.LastIndexOf(".") - 1)); 
                for(int j=0;j<selectnum;++j)
                {
                    if (lastName == selectconfg[j])
                         fileBox.Items.Add(name);
                }
            }

        }
    }
}
