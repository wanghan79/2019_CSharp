/*
 * 功能：1.搜索指定路径下文件及其子文件
 *       2.根据下拉选框搜索不同类型文件
 *       3.打开文件并显示
 *       4.清空和在线编辑修改保存
 *       5.显示当前文件大小和访问时间
 *       6.添加cskin美化外观
 * 作者：沈萌
 * 时间：2019.12.21
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 常用测试路径：c:/users/lenovo/desktop/learning/创新思维训练
 */

namespace SearchFileApplication_V1
{
    public partial class SearchFileApplication_V1 : Form
    {
        string chose;
        public SearchFileApplication_V1()
        {
            InitializeComponent();
        }
        /*
        * 功能：扫描文件及其子文件
        */
        private void scan(string pathname)
        {
            string[] files = Directory.GetFileSystemEntries(pathname);
            try
            {
                foreach (string dir in files)
                {
                    if (Directory.Exists(dir))
                    {
                        scan(dir);
                    }
                    else
                    {
                        FilelistBox1.Items.Add(dir);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        /*
         * 功能：实现对指定后缀文件进行搜索
         */
        private void ChoseenSearch(string pathname, string a)
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
                        if (dir.EndsWith(chose))
                        {
                            FilelistBox1.Items.Add(dir);
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
         * 整个窗体
         */
        private void SearchFileApplication_V1_Load(object sender, EventArgs e)
        {

        }
        /*
         * 控件：label
         * 功能：自定义路径
         */
        private void PathLabel1_Click(object sender, EventArgs e)
        {

        }
        /*
         * 控件：textbox
         * 功能：自定义路径输入
         */
        private void PathTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /*
         * 控件：button
         * 功能：点击开始搜索路径下文件及其子文件
         */
        private void SearchButton1_Click(object sender, EventArgs e)
        {
            FilelistBox1.Items.Clear();
            if (PathTextBox1.Text == string.Empty)
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string foldpath = dialog.SelectedPath;
                    DirectoryInfo files = new DirectoryInfo(foldpath);
                    PathTextBox1.Text = files.ToString();
                    scan(files.ToString());
                }
            }
            else
            {
                string filepath = PathTextBox1.Text;
                scan(filepath);
            }
        }
        /*
         * 控件：button
         * 功能：清空路径
         */
        private void ClearPathButton1_Click(object sender, EventArgs e)
        {
            PathTextBox1.Text = " ";
        }
        /*
         * 控件：label
         * 功能：后缀选项
         */
        private void ChoseLabel1_Click(object sender, EventArgs e)
        {

        }
        /*
         * 控件：combobox
         * 功能：文件类型选择
         */
        private void FileTypeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
        * 功能：按照后缀点击搜索
        */
        private void ChoseButton1_Click(object sender, EventArgs e)
        {
            FilelistBox1.Items.Clear();   
            string text = FileTypeComboBox1.SelectedItem.ToString();         
            try
            {              
                if (FileTypeComboBox1.Text.Equals(string.Empty))
                {
                    MessageBox.Show("请选择后缀!");
                    return;
                }
                else 
                {
                    if (text[0] == '*')
                    {
                        int index = text.LastIndexOf('*');
                        chose = text.Substring(index + 1);
                    }
                    else
                    {
                        chose = text;
                    }
                    ChoseenSearch(PathTextBox1.Text.ToString(), chose);
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
        }
        /*
        * 控件：label
        * 功能：文件列表
        */
        private void FileListLabel1_Click(object sender, EventArgs e)
        {

        }
        /*
        * 控件：listbox
        * 功能：文件列表展示
        */
        private void FilelistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*
        * 控件：button
        * 功能：打开文件
        */
        private void OpenButton1_Click(object sender, EventArgs e)
        {
            string opfilepath = FilelistBox1.SelectedItem.ToString();
            if (opfilepath.Equals(string.Empty))
            {
                MessageBox.Show("请输入文件的路径!");
                return;
            }
           
            StreamReader str=new StreamReader(opfilepath,Encoding.GetEncoding("GB2312"));
            FileDetailTextBox1.Text = str.ReadToEnd();
            FileInfo info = new FileInfo(opfilepath);
            string selectedfile = FilelistBox1.SelectedItem.ToString();
            if (!info.Exists)
            {
                throw new FileNotFoundException("未找到文件！" + opfilepath);
            }
            else
            {  
             
                FileSizeTextBox1.Text = selectedfile.Length + "bytes";

                //System.DateTime currentTime=new System.DateTime();
                CurrVisTextBox3.Text = DateTime.Now.ToString();
            }
        }
        /*
         * 控件：button
         * 功能：清空文件
         */
        private void ClearFileButton1_Click(object sender, EventArgs e)
        {
            FileDetailTextBox1.Text = " ";
        }
        /*
         * 控件：button
         * 功能：保存修改后的文件到指定路径
         */
        private void SaveButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string opfilepath = FilelistBox1.SelectedItem.ToString();
                FileStream fs = new FileStream(opfilepath, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(this.FileDetailTextBox1.Text);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        /*
        * 控件：label
        * 功能：文件详情
        */
        private void skinLabel1_Click(object sender, EventArgs e)
        {

        }
        /*
        * 控件：textbox
        * 功能：文件详情展示
        */
        private void FileDetailTextBox1_Paint(object sender, PaintEventArgs e)
        {
          
        }
        /*
        * 控件：textbox
        * 功能：文件大小
        */
        private void FileSizeTextBox1_TextChanged(object sender, EventArgs e)
        {
            /*
            string selectedfile = FilelistBox1.SelectedItem.ToString();
            FileSizeTextBox1.Text = selectedfile.Length + "bytes";
            */
        }             
        /*
         * 控件：textbox
         * 功能：文件当前访问时间
         */
        private void CurrVisTextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
