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




namespace parctise
{
    public partial class ouyyn : Form
    {
        
        private FileText anotherform;
        public ouyyn()
        {
           
            InitializeComponent();
            searchedFiles = new List<string>();
            anotherform = new FileText();
        }

        string defaultPath = "";
        private void Btn_buttonTransform_Click(object sender, EventArgs e)
        {
           
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                defaultPath = dialog.SelectedPath + "\\";
            }
            Thread thread = new Thread(new ParameterizedThreadStart(searchFilesinFolder));
            thread.Start(this);
            txt_filesName.Text = defaultPath ;
            lst_showSpecifyFiles.DataSource = searchedFiles;
        }

        public static void searchFilesinFolder(object obj)
        {
            
            ouyyn thisForm = (ouyyn)obj;
            string strDir = thisForm.txt_filesName.Text;
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
                    searchedFiles = allSearcheFiles;
                    
                }
            }
        }


        public void search_list(string dir)
        {
            type_files = new List<string>();
            try
            {
                foreach (string file in searchedFiles)
                {
                    if (file.EndsWith(m_str_type))
                        type_files.Add(file);
                }
            }
            catch { }

        }
        

        string m_str_type;
        private void Btn_showOneFile_Click(object sender, EventArgs e)
        {


            string m_file_type = txt_fileName.Text;
            int iIndex = m_file_type.LastIndexOf(".");
            if (m_file_type.IndexOf("*") == -1)
                m_str_type = txt_fileName.Text;
            else
                m_str_type = m_file_type.Substring(iIndex);

            
            search_list(defaultPath);

        }

 


        private void btn_openFile_Click(object sender, EventArgs e)
        {

             string path = defaultPath + lst_showSpecifyFiles.Text;
             FileStream filename = new FileStream(path, FileMode.Open,FileAccess.Read);
             StreamReader sr = new StreamReader(filename, Encoding.Default);
                anotherform.ttxt_fileText.Text = sr.ReadToEnd();
                FileInfo fi = new FileInfo(path);
                anotherform.Text = ("创建时间：" + fi.CreationTime.ToString() + "  写入文件的时间" + fi.LastWriteTime + "  访问的时间" + fi.LastAccessTime);
                anotherform.ShowDialog();
                sr.Close();
            }

        private void folder_path_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                defaultPath = txt_filesName.Text;
                lst_showSpecifyFiles.DataSource = null;
                Thread th_search = new Thread(new ParameterizedThreadStart(searchFilesinFolder));
                th_search.Start(this);
            
                lst_showSpecifyFiles.DataSource = searchedFiles;
                e.Handled = true;
            }
        }
        private void lst_showSpecifyFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static List<string> searchedFiles;
        public static List<string> type_files;

    }
    

  }

