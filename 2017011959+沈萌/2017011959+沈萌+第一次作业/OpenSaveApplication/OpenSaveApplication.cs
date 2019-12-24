/*
 * 功能：1.实现选择（多个）文件 
 *       2.选择指定位置 
 *       3.复制到指定位置
 *       4.加载自定义皮肤进行美化设计控件和窗口
 * 作者：沈萌
 * 时间：2019.12.20
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace DelegateTest
{
    public partial class CopyFiles : Form
    {
        public CopyFiles()
        {
            InitializeComponent();
        }

        /*
         * 控件：button
         * 功能：实现选择多个文件
         */
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "选定文件";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string[] filenames = dialog.FileNames;
                foreach (string str in filenames)
                {
                    string realname = str.Substring(str.LastIndexOf('\\') + 1);
                    this.listBox2.Items.Add(new ListBoxItem(realname, str));
                }
                this.listBox2.SelectedIndex = 0;
                listBox2.TopIndex = listBox2.Items.Count - 1;//让数据向上移动，下方会一直显示最新数据
            }
        }

      

        /*
         * 控件：button
         * 功能：开始复制文件
         */
        private void DstFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = dialog.SelectedPath;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle rect = System.Windows.Forms.SystemInformation.WorkingArea;
            this.Left = (rect.Width - this.Width) / 2;
            this.Top = (rect.Height - this.Height) / 2;
        }

        public delegate bool CopyFileToDesPathEventHadler(string[] filename,string path);

        private bool CopyFileToDesPath(string[] filename,string path) 
        {
            foreach(string str in filename)
            {
                try
                {
                    FileStream fr = new FileStream(str,FileMode.Open,FileAccess.Read);
                  
                    string realname=str.Substring( str.LastIndexOf('\\')+1);
                    FileStream fw = new FileStream(path+"\\"+realname,FileMode.Create,FileAccess.Write);
                    byte[] buffer = new byte[1024];
                    int length = fr.Read(buffer,0,buffer.Length);
                    while(length!=0)
                    {
                        fw.Write(buffer,0,length);
                        fw.Flush();
                        length = fr.Read(buffer,0,buffer.Length);
                    }
                    fr.Close();
                    fw.Close();
                    this.SetListBox(str);
                    Thread.Sleep(20);
                }
                catch (Exception e) 
                {
                    MessageBox.Show(e.ToString());
                }
            }
            return false;
        }

        public delegate void SetListBoxEventHandler(string filename);

        private void SetListBox(string filename)
        {
            if (this.listBox1.InvokeRequired)
            {
                this.Invoke(new SetListBoxEventHandler(SetListBox),filename);
            }
            else
            {
                this.listBox1.Items.Add(filename+" 拷贝完成！");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string[] filename = new string[this.listBox2.Items.Count];
            for (int i = 0; i < this.listBox2.Items.Count; i++)
            {
                ListBoxItem com = (ListBoxItem)this.listBox2.Items[i];
                filename[i] = com.value;
            }
            if (filename.Length <= 0 || String.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("请确保目标文件和目录不为空！","提示",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            CopyFileToDesPathEventHadler cpy = new CopyFileToDesPathEventHadler(CopyFileToDesPath);

            cpy.BeginInvoke(filename,this.textBox1.Text,null,null);

        }

        private void CpyButton_Click(object sender, EventArgs e)
        {
            string[] filename = new string[this.listBox2.Items.Count];
            for (int i = 0; i < this.listBox2.Items.Count; i++)
            {
                ListBoxItem com = (ListBoxItem)this.listBox2.Items[i];
                filename[i] = com.value;
            }
            if (filename.Length <= 0 || String.IsNullOrEmpty(this.textBox1.Text))
            {
                MessageBox.Show("请确保目标文件和目录不为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            CopyFileToDesPathEventHadler cpy = new CopyFileToDesPathEventHadler(CopyFileToDesPath);

            cpy.BeginInvoke(filename, this.textBox1.Text, null, null);
        }

  

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        
        /*
         * 控件：button
         * 功能：清空操作实现
         */
        protected void ClearFileList()
        {
            listBox2.Items.Clear();
        }
        protected void ClearFolder()
        {
            textBox1.Text = "";
        }

        /*
         * 控件：button
         * 功能：实现清空下方列表
         */
        private void ClearButton1_Click(object sender, EventArgs e)
        {
            ClearFileList();
        }

        /*
         * 控件：button
         * 功能：实现清空下方目录表
         */
        private void ClearButton2_Click(object sender, EventArgs e)
        {
            ClearFolder();
        }
       
    }
   
    public class ListBoxItem
    {
        public string text;
        public string value;
        public ListBoxItem(string text, string value)
        {
            this.text = text;
            this.value = value;
        }
        public override string ToString()
        {
            return this.text;
        }
    }
}
