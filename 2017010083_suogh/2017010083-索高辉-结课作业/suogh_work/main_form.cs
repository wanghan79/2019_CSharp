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

namespace suogh_work
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
            searched_files=new List<string>();
            search_complete += new refresh_list_box_hanlder(update_list_box);
        }

        string m_dir_path = "";
        private void chose_folder_Click(object sender, EventArgs e)
        {
            
            
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            //打开的文件夹浏览对话框上的描述  
            dialog.Description = "请选择一个文件夹";
            //是否显示对话框左下角 新建文件夹 按钮，默认为 true  
            //dialog.ShowNewFolderButton = false;
            //首次defaultPath为空，按FolderBrowserDialog默认设置（即桌面）选择  
            if (m_dir_path != "")
            {
                //设置此次默认目录为上一次选中目录  
                dialog.SelectedPath = m_dir_path;
            }
            //按下确定选择的按钮  
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录  
                m_dir_path = dialog.SelectedPath;
            }
            folder_path.Text = m_dir_path;
            search_result.DataSource = null;
            //ListAll(m_dir_path);
            Thread th_search = new Thread(new ParameterizedThreadStart(search_files_in_folder));
            th_search.Start(this);
            pb_searching.Value = 0;
            timer_searching.Enabled = true;
            //search_files_in_folder(m_dir_path);
            search_result.DataSource = searched_files;
        }
        
        
        string m_str_type;
        //private void chose_types_TextChanged(object sender, EventArgs e)
        //{
        //    string m_file_type = chose_types.Text;
        //    int iIndex = m_file_type.LastIndexOf(".");
        //    m_str_type = m_file_type.Substring(iIndex + 1);
        //}
        
        public void search_list(string dir) {

            //string[] files = Directory.GetFileSystemEntries(dir);//提取所有文件及文件夹的名称(包括路径)
            type_files = new List<string>();
            try {
                foreach (string file in searched_files)
                {
                    if(file.EndsWith(m_str_type))
                        type_files.Add(file);//若为指定类型文件则加入列表
                }
            }
            //catch (Exception ex) {
            //    MessageBox.Show(ex.ToString());
            //}
            catch { }
            
        }
        
        public static void search_files_in_folder(object obj)
        {
            string str_dir = obj.ToString();
            main_form this_form = (main_form)obj;
            //str_dir = thisForm.folder_path.Text;
            str_dir=this_form.m_dir_path;
            if (str_dir != null && str_dir.Length > 0)
            {
                if (Directory.Exists(str_dir))
                {
                    searched_files.Clear();
                    List<string> all_files = new List<string>();
                    List<string> folders2search=new List<string>();
                    folders2search.Add(str_dir);
                    for (int i=0;i<folders2search.Count;i++)
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
                            catch{  }
                     }
                    searched_files = all_files;
                    this_form.search_complete(this_form);
                }
            }
        }
        
        
        public void ListAll(string dir)
        {
            //List<string> list = new List<string>();
            string[] files = Directory.GetFileSystemEntries(dir);
            try
            {
                foreach (string file in files)
                {
                    if (Directory.Exists(file))//若为子目录则继续递归
                        ListAll(file);
                    else
                    {
                        //char[] chars = { '\\' };
                        //search_result.Items.Add(file.Split(chars, StringSplitOptions.None).Last<string>());
                        search_result.Items.Add(file);
                    }
                }
            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            catch { }
        }

        private void bt_run_file_Click(object sender, EventArgs e)
        {
            //启动指定文件 
            //if (m_str_type == null)
            //    try
            //    {
            //        System.Diagnostics.Process.Start(string.Concat(m_dir_path, '\\', search_result.SelectedItem.ToString()));
            //    }
            //    catch
            //    {
            //        //throw new FormatException("该文件仅为文件名，非完整路径，无法打开，请查询类型后打开");
            //        MessageBox.Show("该文件仅为文件名，非完整路径，无法打开，请操作查询指令后打开");
            //    }
            //else
            if(search_result!=null)
                System.Diagnostics.Process.Start(search_result.SelectedItem.ToString());
         }

        

        private void folder_path_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                m_dir_path = folder_path.Text;
                search_result.DataSource = null;
                //search_files_in_folder(m_dir_path);
                Thread th_search = new Thread(new ParameterizedThreadStart(search_files_in_folder));
                th_search.Start(this);
                pb_searching.Value = 0;
                timer_searching.Enabled = true;
                search_result.DataSource = searched_files;
                e.Handled = true;
            }
        }

        private void chose_types_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                string m_file_type = chose_types.Text;
                int iIndex = m_file_type.LastIndexOf(".");
                if(m_file_type.IndexOf("*")==-1)
                    m_str_type = chose_types.Text;
                else
                m_str_type = m_file_type.Substring(iIndex);
                
                search_result.DataSource=null;
                search_list(m_dir_path);
                search_result.DataSource = type_files;
                e.Handled = true;
            }
        }

        
        private void search_result_DoubleClick(object sender, EventArgs e)
        {
            string name=null;
            if (this.search_result.SelectedItem != null) { 
                name = this.search_result.SelectedItem.ToString();
                MessageBox.Show(name); //执行双击事件
                if (name.EndsWith("txt")){
                    text_name = name;
                    text_show text_show = new text_show(text_name);
                    text_show.ShowDialog();
                }
                else
                    System.Diagnostics.Process.Start(search_result.SelectedItem.ToString());
             }
        }

        private void update_list_box(object sender)
        {
            //lsbFiles.Items.Clear();
            //lsbFiles.Items.AddRange(searchedFiles.ToArray());

            if (this.InvokeRequired)
            {
                refresh_list_box_hanlder delegateFunc = new refresh_list_box_hanlder(update_list_box);
                this.Invoke(delegateFunc, sender);
            }
            else
            {
                search_result.DataSource = null;
                search_result.DataSource = searched_files;

                //this.pb_searching.Value = Convert.ToInt32(sender);//
            }
        }



        public int total_step;
        public static List<string> type_files;
        public static List<string> searched_files;
        public string text_name;
        public delegate void refresh_list_box_hanlder(object sender);
        public event refresh_list_box_hanlder search_complete;
        private void timer_searching_Tick(object sender, EventArgs e)
        {
            int i = 100;
            pb_searching.Value = pb_searching.Value + 1;
            i = 100 - pb_searching.Value;
            if (i == 0)
            {
                timer_searching.Enabled = false;
            }
        }

    }
}
