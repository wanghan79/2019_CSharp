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
            search_result.Items.Clear();
            ListAll(m_dir_path);

        }


        string m_str_type;
        //private void chose_types_TextChanged(object sender, EventArgs e)
        //{
        //    string m_file_type = chose_types.Text;
        //    int iIndex = m_file_type.LastIndexOf(".");
        //    m_str_type = m_file_type.Substring(iIndex + 1);
        //}

        private void search_list(string dir)
        {

            string[] files = Directory.GetFileSystemEntries(dir);//提取所有文件及文件夹的名称(包括路径)
            try
            {
                foreach (string file in files)
                {
                    if (Directory.Exists(file))//若为子目录则继续递归
                        search_list(file);
                    else if (file.EndsWith(m_str_type))
                        search_result.Items.Add(file);//若为指定类型文件则加入列表
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void ListAll(string dir)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            System.Diagnostics.Process.Start(search_result.SelectedItem.ToString());
        }



        private void folder_path_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                m_dir_path = folder_path.Text;
                search_result.Items.Clear();
                ListAll(m_dir_path);
                e.Handled = true;
            }
        }

        private void chose_types_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == System.Convert.ToChar(13))
            {
                string m_file_type = chose_types.Text;
                int iIndex = m_file_type.LastIndexOf(".");
                if (m_file_type.IndexOf("*") == -1)
                    m_str_type = chose_types.Text;
                else
                    m_str_type = m_file_type.Substring(iIndex);

                search_result.Items.Clear();
                search_list(m_dir_path);
                e.Handled = true;
            }
        }

        public string text_name;
        private void search_result_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(this.search_result.SelectedItem.ToString()); //执行双击事件
            text_name = this.search_result.SelectedItem.ToString();
            text_show text_show = new text_show(text_name);
            text_show.ShowDialog();
        }


    }
}