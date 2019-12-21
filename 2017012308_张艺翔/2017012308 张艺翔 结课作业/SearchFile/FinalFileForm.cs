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

namespace SearchFile
{
    public partial class FinalFileForm : Form
    {
        public FinalFileForm()
        {
            InitializeComponent();
            searchedFiles = new List<string>();

        }

        string m_dir_path = "";

        private void btChooseFile_Click(object sender, EventArgs e)
        {


            FolderBrowserDialog dialog = new FolderBrowserDialog();//打开的文件夹浏览对话框上的描述 
             
            dialog.Description = "请选择一个文件夹";  
            
            if (m_dir_path != "")
            {
                
                dialog.SelectedPath = m_dir_path;
            }
              
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                m_dir_path = dialog.SelectedPath;
            }
            this.tbPath.Text = m_dir_path;
            this.FileList.Items.Clear();
            ListAll(m_dir_path);

            Thread thread = new Thread(new ParameterizedThreadStart(searchFilesinFolder)); //线程
            thread.Start(this);

        }

        public static void searchFilesinFolder(object obj)
        {
            string strDir = obj.ToString();
            FinalFileForm thisForm = (FinalFileForm)obj;
            strDir = thisForm.tbPath.Text;
            if (strDir != null && strDir.Length > 0)
            {
                if (Directory.Exists(strDir))
                {
                    searchedFiles.Clear();
                    List<string> allSearcheFiles = new List<string>();
                    List<string> folders2Search = new List<string>();
                    folders2Search.Add(strDir);
                    while (folders2Search.Count > 0)
                    {
                        try
                        {
                            string curFolder = folders2Search[0];
                            folders2Search.RemoveAt(0);
                            string[] files = Directory.GetFiles(curFolder);
                            string[] dirs = Directory.GetDirectories(curFolder);
                            foreach (string item in files)
                                allSearcheFiles.Add(item);
                            foreach (string item in dirs)
                                folders2Search.Add(item);
                        }
                        catch { }
                    }
                    searchedFiles.AddRange(allSearcheFiles);
                    refreshListBoxHanlder updateDelegate = new refreshListBoxHanlder(thisForm.updateListBox);
                       thisForm.Invoke(updateDelegate, thisForm);
               
                }
            }
        }

        private void search_list(string dir)
        {

            string[] files = Directory.GetFileSystemEntries(dir);//提取所有文件及文件夹的名称(包括路径)
            try
            {
                foreach (string file in files)
                {
                    if (Directory.Exists(file))//若为子目录则继续递归
                        search_list(file);
                    else
                    FileList.Items.Add(file);//若为指定类型文件则加入列表
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ListAll(string dir)
        {
            List<string> list = new List<string>();
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
                        FileList.Items.Add(file.Split(chars, StringSplitOptions.None).Last<string>());
                    
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void updateListBox(object sender)
        {
            FileList.Items.Clear();

            if (this.InvokeRequired)
            {
                refreshListBoxHanlder delegateFunc = new refreshListBoxHanlder(updateListBox);
                this.Invoke(delegateFunc, sender);
            }
            else
            {
                FileList.Items.Clear();
                FileList.Items.AddRange(searchedFiles.ToArray());
            }
            MessageBox.Show("查询完毕！");
        }
        public delegate void refreshListBoxHanlder(object sender);
        public static List<string> searchedFiles;



       //更新进度列表
        private delegate void SetPos(int ipos);
 
        private void SetTextMessage(int ipos)
        {
        if (this.InvokeRequired)
        {
        SetPos setpos = new SetPos(SetTextMessage);
        this.Invoke(setpos, new object[] { ipos });
        }
        else
        {
        this.label.Text = ipos.ToString() + "%";
        this.TimeBar.Value = Convert.ToInt32(ipos);
        }
        }
 
        public Thread fThread;
 
        private void button1_Click(object sender, EventArgs e)
        {
            fThread = new Thread(new ThreadStart(SleepT));//开辟一个新的线程
            fThread.Start();
         
        }
 
        private void SleepT()
        {
            for (int i = 0; i <= 500; i++)
            {
                System.Threading.Thread.Sleep(10); //线程休眠，控制进度条的速度。
                SetTextMessage(100 * i / 500); 
            }

            if (TimeBar.Value == 100)
            {
                if (MessageBox.Show("已完成！", "提示", MessageBoxButtons.OK) 
                     == DialogResult.OK)
                {
                   TimeBar.Value = 0;
                    this.label.Text = "";
                
             }              
            }
        }

        private void tbPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNotice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSiftFile_Click(object sender, EventArgs e)
        {

        }

    }
}
