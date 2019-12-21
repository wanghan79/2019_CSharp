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
using System.Net;

namespace parctise
{
    public partial class ouyyn : Form
    {

        private FileText anotherform;
        public ouyyn()
        {
            InitializeComponent();
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
            txt_filesName.Text = defaultPath ;
            lst_showSpecifyFiles.Items.Clear();
           findFile(defaultPath);
        }


        public  void TransformFiles(string path)
        {
            string text = txt_fileName.Text;
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileInfo[] files = dir.GetFiles("*." + text);
                foreach (FileInfo file in files)
                {
                    
                    lst_showSpecifyFiles.Items.Add(defaultPath + file);
                }

                DirectoryInfo[] direcs = dir.GetDirectories();
                foreach (DirectoryInfo dinfo in direcs)
                {
                    defaultPath = path + dinfo.Name + "\\";
                    TransformFiles(path + dinfo);
                }
            }
            catch { }

    
        }
        private void findFile(string path)//迭代列出文件
        {
            string[] files = Directory.GetFileSystemEntries(path);
            try
            {
                foreach (string dir in files)
                {
                    if (Directory.Exists(dir))//判断是否为目录，是目录就继续递归
                    {
                       findFile(dir);
                    }
                    else
                    {
                        lst_showSpecifyFiles.Items.Add(dir);//是文件就加入listbox中
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            
        }

        private void Btn_showOneFile_Click(object sender, EventArgs e)
        {

            lst_showSpecifyFiles.Items.Clear();
            TransformFiles(defaultPath);
            

        }

        
        private void lst_showSpecifyFiles_DoubleClick(object sender, EventArgs e)//执行双击事件
        {   string text_name;
 
            text_name = this.lst_showSpecifyFiles.SelectedItem.ToString();

            FileStream filename = new FileStream(text_name, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(filename, Encoding.Default);
            anotherform.ttxt_fileText.Text = sr.ReadToEnd();
            FileInfo fi = new FileInfo(text_name);
            anotherform.Text = ("创建时间：" + fi.CreationTime.ToString() + "  写入文件的时间" + fi.LastWriteTime + "  访问的时间" + fi.LastAccessTime);
            anotherform.ShowDialog();
            sr.Close();
        }
         

       

        private void lst_showSpecifyFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_filesName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    

  }

