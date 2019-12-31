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

namespace sec
{
    //section 
    public partial class fileserch : Form
    {

        string file_string_dir,file_dir_path,file_str_type;



        private void button_read_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog opDlg = new FolderBrowserDialog();
            opDlg.ShowDialog();
            file_string_dir = opDlg.SelectedPath;
            find_file.Text = file_string_dir;
            straight(file_string_dir);
        }
      
        private void open_file_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Concat(file_string_dir, '\\', show_file.SelectedItem.ToString()));
        }

        private void straight1(string dir)
        {


            /*
             * 函数用来获取所有文件   以及 文件夹的名称  
             */
            string[] files = Directory.GetFileSystemEntries(dir);
            try
            {
                foreach (string file in files)
                {
                    /*
                     * 判断是否是子文件*/
                    if (Directory.Exists(file))
                        straight1(file);
                    
                    else if (file.EndsWith(file_str_type))
                        show_file.Items.Add(file);
                    
                    //将指定类型的文件加入目的列表
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

          public void straight(string strs)
        {
            string[] files = Directory.GetFileSystemEntries(strs);
            foreach (string file in files)
            {
                if (Directory.Exists(file))
                    straight(file);
                else
                {

                    show_file.Items.Add(file);
                }
            }




        }

        private void find_file_KeyPress(object sender, KeyPressEventArgs e)
        {
             if(e.KeyChar==System .Convert.ToChar(13))
            {

                file_dir_path = find_file.Text;
                show_file.Items.Clear();
                straight(file_dir_path);
                e.Handled = true;

                

            }
        }


        private void select_file_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                string m_file_type = select_file.Text;
                int iIndex = m_file_type.LastIndexOf(".");
                if (m_file_type.IndexOf("*") == -1)
                    file_str_type = select_file.Text;
                else
                    file_str_type = m_file_type.Substring(iIndex);
                show_file.Items.Clear();
                straight1(file_string_dir);
                e.Handled = true;
            }




        }

        public fileserch()
        {
            InitializeComponent();

        }


        public string param_label;
        private void show_file_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(this.show_file.SelectedItem.ToString());
            param_label = this.show_file.SelectedItem.ToString();
            text_show text_show = new text_show(param_label);
            text_show.ShowDialog();

        }
       

    }
}
