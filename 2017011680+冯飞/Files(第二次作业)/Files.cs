using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
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
        private delegate void deleSetListBox(object sender);
        private delegate void deleSet();
        private void watchFile_Click(object sender, EventArgs e)
        {
            File1 f = new File1();
            fs.rootDirectory = f.OpenFile();
            this.openfile.Text = fs.rootDirectory;
            this.listBox.Items.Clear();
            //DirectoryInfo directoryInfo = new DirectoryInfo(fs.rootDirectory);
            File1 getFiles = new File1();
            //getFiles.searchFilesFolder(fs.rootDirectory);
            Thread thSearchFile = new Thread(new ParameterizedThreadStart(getFiles.searchFilesFolder));
            thSearchFile.Start(this);
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
        //public void bindText()
        //{
        //    //listBoxFile list = (listBoxFile)obj;
        //    if (this.listBox.InvokeRequired||this.textBoxSearch.InvokeRequired)
        //    {
        //        deleSet dele = new deleSet(bindText);
        //        this.Invoke(dele);
        //    }
        //    else
        //    {
        //        this.textBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        //        this.textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        //        this.textBoxSearch.AutoCompleteCustomSource = null;
        //        this.listBox.Items.AddRange(fs.fileName.ToArray());
        //        this.textBoxSearch.AutoCompleteCustomSource.AddRange(fs.fileName.ToArray());
        //    }

        //}

        public void bindText(object obj)
        {
            listBoxFile list = (listBoxFile)obj;
            if (this.listBox.InvokeRequired || this.textBoxSearch.InvokeRequired)
            {
                deleSetListBox dele = new deleSetListBox(bindText);
                list.Invoke(dele, list);
            }
            else
            {
                this.textBoxSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                this.textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                this.textBoxSearch.AutoCompleteCustomSource = null;
                this.listBox.Items.AddRange(fs.fileName.ToArray());
                this.textBoxSearch.AutoCompleteCustomSource.AddRange(fs.fileName.ToArray());
                this.listBox.Update();
            }
        }


        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox.SelectedIndex!= -1 )
            {
                this.textBoxSearch.Text = Path.GetFileName(listBox.SelectedItem.ToString());
                fs.fileSelected = this.textBoxSearch.Text;
                fs.selectedFile = listBox.SelectedItem.ToString();
                Myform myform = new Myform();
                myform.Show();
            }
            else
            {

            }
        }
    }
}
