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

namespace sec
{
    public partial class filesearch : Form
    {

        public static List<string> file_type;
        public static List<string> quire_name;
        public string text_name;
        public delegate void refresh_list_box_hanlder(object sender);
        public event refresh_list_box_hanlder quire_entire;
        string file_string_dir, file_dir_path, file_str_type;

        private void button_read_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
 
            
            if (file_string_dir != "")
            {
                dialog.SelectedPath = file_string_dir;
            }
    
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                file_string_dir = dialog.SelectedPath;
            }
           find_file.Text = file_string_dir;
          show_file.DataSource = null;
       
            Thread th_search = new Thread(new ParameterizedThreadStart(search_files_in_folder));
            th_search.Start(this);
            
            show_file.DataSource = quire_name;
        }
       

        private void open_file_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Concat(file_string_dir, '\\', show_file.SelectedItem.ToString()));
        }

        public void search_list(string dir)
        {


            file_type = new List<string>();
            try
            {
                foreach (string file in quire_name)
                {
                    if (file.EndsWith(file_str_type))
                        file_type.Add(file);
                }
            }
       
            catch {

            }

        }

        public static void search_files_in_folder(object obj)
        {
            string file_dir = obj.ToString();
            sec this_form = (sec)obj;
            file_dir = this_form.file_string_dir;
            if (file_dir != null && file_dir.Length > 0)
            {
                if (Directory.Exists(file_dir))
                {
                    quire_name.Clear();
                    List<string> all_files = new List<string>();
                    List<string> folders = new List<string>();
                    folders.Add(file_dir);
                    for (int i = 0; i < folders.Count; i++)
                    {
                        try
                        {
                            string cur_folder = folders[i];
                            string[] files = Directory.GetFiles(cur_folder);
                            string[] dirs = Directory.GetDirectories(cur_folder);
                            foreach (string item in files)
                                all_files.Add(item);
                            foreach (string item in dirs)
                                folders.Add(item);
                        }
                        catch { }
                    }
                    quire_name = all_files;
                    this_form.quire_entire(this_form);
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

                file_dir_path = find_file.Text;
               show_file.DataSource = null;
         
                Thread th_search = new Thread(new ParameterizedThreadStart(search_files_in_folder));
                th_search.Start(this);
                show_file.DataSource = quire_name;
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
                    file_str_type = find_file.Text;
                else
                    file_str_type = m_file_type.Substring(iIndex);
                
                show_file.DataSource=null;
                search_list(file_string_dir);
                show_file.DataSource = file_type;
                e.Handled = true;
            }
            

        }
        private void new_box(object sender)
        {
           

            if (this.InvokeRequired)
            {
                refresh_list_box_hanlder delegateFunc = new refresh_list_box_hanlder(new_box);
                this.Invoke(delegateFunc, sender);
            }
            else
            {
               show_file.DataSource = null;
               show_file.DataSource = quire_name;

              
            }
        }

        public filesearchc()
        {
            InitializeComponent();
            quire_name = new List<string>();
            quire_entire += new refresh_list_box_hanlder(new_box);

        }

 
    
        private void show_file_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(this.show_file.SelectedItem.ToString());
            text_name = this.show_file.SelectedItem.ToString();
            text_show text_show = new text_show(text_name);
            text_show.ShowDialog();

        }

       

    }
}
