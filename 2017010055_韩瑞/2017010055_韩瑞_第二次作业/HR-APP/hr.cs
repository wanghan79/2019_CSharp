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

namespace HR_APP
{
    public partial class hr : Form
    {

        public hr()
        {
            InitializeComponent();
        
        }

        private void button_read_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog opDlg = new FolderBrowserDialog();
            opDlg.ShowDialog();
            m_str_dir = opDlg.SelectedPath;
            find_file.Text = m_str_dir;
            director2(m_str_dir);
        }
        string m_str_dir, m_dir_path,my_str_type;
      
        private void open_file_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Concat(m_str_dir, '\\', show_file.SelectedItem.ToString()));
        }

        private void director1(string dir)
        {

            string[] files = Directory.GetFileSystemEntries(dir);//提取所有文件及文件夹的名称(包括路径)
            try
            {
                foreach (string file in files)
                {
                    if (Directory.Exists(file))//若为子目录则继续递归
                        director1(file);
                    else if (file.EndsWith(my_str_type))
                        show_file.Items.Add(file);//若为指定类型文件则加入列表
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

          public void director2(string strs)
        {
            string[] files = Directory.GetFileSystemEntries(strs);
            foreach (string file in files)
            {
                if (Directory.Exists(file))
                    director2(file);
                else
                {
                    //char[] str = { '\\' };
                    show_file.Items.Add(file);
                }
            }




        }

        private void find_file_KeyPress(object sender, KeyPressEventArgs e)
        {
             if(e.KeyChar==System .Convert.ToChar(13))
            {

                m_dir_path = find_file.Text;
                show_file.Items.Clear();
                director2(m_dir_path);
                e.Handled = true;

                

            }
        }

        private void show_file_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void select_file_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                string m_file_type = select_file.Text;
                int iIndex = m_file_type.LastIndexOf(".");
                if (m_file_type.IndexOf("*") == -1)
                    my_str_type = select_file.Text;
                else
                    my_str_type = m_file_type.Substring(iIndex);
                show_file.Items.Clear();
                director1(m_str_dir);
                e.Handled = true;
            }




        }
        public string text_name;
        private void show_file_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(this.show_file.SelectedItem.ToString());
            text_name = this.show_file.SelectedItem.ToString();
            text_show text_show = new text_show(text_name);
            text_show.ShowDialog();

        }
       

    }
}
