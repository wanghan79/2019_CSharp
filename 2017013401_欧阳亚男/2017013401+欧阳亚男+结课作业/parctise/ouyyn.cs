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



namespace parctise
{
    public partial class ouyyn : Form
    {

        private FileText anotherform;
        public ouyyn()
        {

            InitializeComponent();
            searchedFiles = new List<string>();
            searchComplete += new refreshListBoxHanlder(updateListBox);
            anotherform = new FileText();
        }

        
        private void Btn_buttonTransform_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_filesName.Text = dialog.SelectedPath;
            }
            Thread thread = new Thread(new ParameterizedThreadStart(searchFilesinFolder));
            thread.Start(this);
            progressBar.Value = 0;
            ProcessBarTimer.Enabled = true;
            
        }

        public static void searchFilesinFolder(object obj)
        {
            string strPath = obj.ToString();
            ouyyn thisForm = (ouyyn)obj;
            strPath = thisForm.txt_filesName.Text;
            if (strPath != null && strPath.Length > 0)
            {
                if (Directory.Exists(strPath))
                {
                    searchedFiles.Clear();
                    List<string> allSearcheFiles = new List<string>();
                    List<string> folders2Search = new List<string>();
                    folders2Search.Add(strPath);
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
                    thisForm.searchComplete(thisForm);

                }
            }
        }




      
        private void chose_File(string pathname, string a)
        {
            string[] files = Directory.GetFileSystemEntries(pathname);
            try
            {
                foreach (string dir in files)
                {
                    if (Directory.Exists(dir))
                    {
                        chose_File(dir, chose);
                    }
                    else
                    {
                        if (dir.EndsWith(chose))
                        {
                            lst_showSpecifyFiles.Items.Add(dir);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }


        string chose;
        private void Btn_showOneFile_Click(object sender, EventArgs e)
        {
            lst_showSpecifyFiles.Items.Clear();
            string text = txt_fileName.Text.ToString();
            if (text[0] == '*')
            {
                int index = text.LastIndexOf('*');
                chose = text.Substring(index + 1);
            }
            else
            {
                chose = text;
            }
            chose_File(txt_filesName.Text.ToString(), chose);
            progressBar.Value = 0;
            ProcessBarTimer.Enabled = true;


            /*OpenFileDialog opDlg = new OpenFileDialog();
            opDlg.ShowDialog();
            txt_fileName.Text = opDlg.FileName;*/

        }




        

        private void lst_showSpecifyFiles_DoubleClick(object sender, EventArgs e)//执行双击事件
        {
            string Chose_FileName = lst_showSpecifyFiles.SelectedItem.ToString();

            FileStream filename = new FileStream(Chose_FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(filename, Encoding.Default);
            anotherform.ttxt_fileText.Text = sr.ReadToEnd();
            FileInfo fi = new FileInfo(Chose_FileName);
            anotherform.Text = ("创建时间：" + fi.CreationTime.ToString() + "  写入文件的时间" + fi.LastWriteTime + "  访问的时间" + fi.LastAccessTime);
            anotherform.ShowDialog();
            sr.Close();
        }

        private void updateListBox(object sender)//委托
        {

            if (this.InvokeRequired)
            {
                refreshListBoxHanlder delegateFunc = new refreshListBoxHanlder(updateListBox);
                this.Invoke(delegateFunc, sender);
            }
            else
            {
                lst_showSpecifyFiles.Items.Clear();
                lst_showSpecifyFiles.Items.AddRange(searchedFiles.ToArray());
            }
        }
        private void lst_showSpecifyFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static List<string> searchedFiles;
        public delegate void refreshListBoxHanlder(object sender);
        public event refreshListBoxHanlder searchComplete;

        private void ProcessBarTimer_Tick(object sender, EventArgs e)
        {
            int i = 100;
            progressBar.Value = progressBar.Value + 10;
            i = 100 - progressBar.Value;
            if (i == 0)
            {
                ProcessBarTimer.Enabled = false;
            }

        }

        



    }
  }

