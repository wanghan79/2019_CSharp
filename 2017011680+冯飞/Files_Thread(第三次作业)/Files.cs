using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Files.lib;
namespace Files
{
    public partial class listBoxFile : Form
    {
        public static FileDirectory fs = new FileDirectory();
        MyControl myControl = new MyControl();
        //RichTextBox richTextBox;
        //ListBox listBox;
        public listBoxFile()
        {
            InitializeComponent();
        }


        private void watchFile_Click(object sender, EventArgs e)
        {
            File1 f = new File1();
            fs.rootDirectory = f.OpenFile();
            this.openfile.Text = fs.rootDirectory;
            this.listBox.Items.Clear();
            File1 getFiles = new File1();
            getFiles.searchFilesFolder(fs.rootDirectory);
            foreach (string file in fs.fileName)
            {
                this.listBox.Items.Add(file);
            }
            bindText();
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
            //this.listBoxFile.Items.Clear();
            //foreach(string file in fs.fileName)
            //{
            //    if (file.IndexOf(this.textBoxSearch.Text.ToString())!=-1)
            //    {
            //        this.listBoxFile.Items.Add(file);
            //    }
            //}
        }

        private void openfile_TextChanged(object sender, EventArgs e)
        {

        }

        private void openfiles_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex!=-1)
            {
                this.textBoxSearch.Text = listBox.SelectedItem.ToString();
            }
            if (this.textBoxSearch.Text == null || this.textBoxSearch.Text==string.Empty)
            {
                MessageBox.Show("请选择需要打开的文件！","提示" );
            }
            else
            {
                fs.fileSelected = this.textBoxSearch.Text;
                fs.selectedFile = fs.rootDirectory + "/" + this.textBoxSearch.Text;
                if (File.Exists(fs.selectedFile))
                {
                    Myform myform = new Myform();
                    myform.Show();
                }
            }
        }
        private void bindText()
        {
            this.textBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.textBoxSearch.AutoCompleteCustomSource = null;
            foreach (string file in fs.fileName)
            {
                string file1 = file.Substring(file.LastIndexOf("\\")+1);
                //MessageBox.Show(file1);
                this.textBoxSearch.AutoCompleteCustomSource.Add(file1);
            }
        }
        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.textBoxSearch.Text = Path.GetFileName(listBox.SelectedItem.ToString());
            fs.fileSelected = this.textBoxSearch.Text;
            fs.selectedFile = listBox.SelectedItem.ToString() ;
            Myform myform = new Myform();
            myform.Show();
        }

        private void listBoxFile_Load(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
