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

namespace HR_APP
{
    public partial class hr : Form
    {

        public hr()
        {
            InitializeComponent();
            searched_files = new List<string>();
            search_complete += new refresh_list_box_hanlder(update_list_box);
        
        }

        private void button_read_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
 
            
            if (m_str_dir != "")
            {
                dialog.SelectedPath = m_str_dir;
            }
    
            if (dialog.ShowDialog() == DialogResult.OK)
            {
              
               m_str_dir= dialog.SelectedPath;
            }
           find_file.Text = m_str_dir;
          show_file.DataSource = null;
       
            Thread th_search = new Thread(new ParameterizedThreadStart(search_files_in_folder));
            th_search.Start(this);
            
            show_file.DataSource = searched_files;
        }
        string m_str_dir, m_dir_path,my_str_type;
      
        private void open_file_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Concat(m_str_dir, '\\', show_file.SelectedItem.ToString()));
        }

        public void search_list(string dir)
        {

         
            type_files = new List<string>();
            try
            {
                foreach (string file in searched_files)
                {
                    if (file.EndsWith(my_str_type))
                        type_files.Add(file);
                }
            }
       
            catch { }

        }

        public static void search_files_in_folder(object obj)
        {
            string str_dir = obj.ToString();
        hr this_form = (hr)obj;
            //str_dir = thisForm.folder_path.Text;
            str_dir = this_form.m_str_dir;
            if (str_dir != null && str_dir.Length > 0)
            {
                if (Directory.Exists(str_dir))
                {
                    searched_files.Clear();
                    List<string> all_files = new List<string>();
                    List<string> folders2search = new List<string>();
                    folders2search.Add(str_dir);
                    for (int i = 0; i < folders2search.Count; i++)
                    {
                        try
                        {
                            string cur_folder = folders2search[i];
                            string[] files = Directory.GetFiles(cur_folder);
                            string[] dirs = Directory.GetDirectories(cur_folder);
                            foreach (string item in files)
                                all_files.Add(item);
                            foreach (string item in dirs)
                                folders2search.Add(item);
                        }
                        catch { }
                    }
                    searched_files = all_files;
                    this_form.search_complete(this_form);
                }
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
               show_file.DataSource = null;
         
                Thread th_search = new Thread(new ParameterizedThreadStart(search_files_in_folder));
                th_search.Start(this);
                show_file.DataSource = searched_files;
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
                string m_file_type = find_file.Text;
                int iIndex = m_file_type.LastIndexOf(".");
                if(m_file_type.IndexOf("*")==-1)
                    my_str_type = find_file.Text;
                else
                my_str_type = m_file_type.Substring(iIndex);
                
                show_file.DataSource=null;
                search_list(m_str_dir);
                show_file.DataSource = type_files;
                e.Handled = true;
            }
            

        }
        private void update_list_box(object sender)
        {
           

            if (this.InvokeRequired)
            {
                refresh_list_box_hanlder delegateFunc = new refresh_list_box_hanlder(update_list_box);
                this.Invoke(delegateFunc, sender);
            }
            else
            {
               show_file.DataSource = null;
               show_file.DataSource = searched_files;

              
            }
        }



        public int total_step;
        public static List<string> type_files;
        public static List<string> searched_files;
        public string text_name;
        public delegate void refresh_list_box_hanlder(object sender);
        public event refresh_list_box_hanlder search_complete;
    
        private void show_file_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(this.show_file.SelectedItem.ToString());
            text_name = this.show_file.SelectedItem.ToString();
            text_show text_show = new text_show(text_name);
            text_show.ShowDialog();

        }

       

    }
}
