/*
 * 功能：1.实现双击打开文件查看详细内容的弹出窗口
 *       2.显示当前实时时间
 * 作者：沈萌
 * 时间：2019.12.19
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFileApplication
{
    public partial class FileList : Form
    {
        public FileList()
        {
            InitializeComponent();
        }
       /*
        *控件：label
        *功能：显示实时时间
        */
        private void FileList_Load(object sender, EventArgs e)
        {
            clock.Enabled = true;
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            DateTime dtime = DateTime.Now;
            Timelabel.Text = dtime.ToString(); 
        }

        /*
         * 控件：listbox
         * 功能：展示打开文件详细内容
         */
        public string textboxText
        {
            get 
            { 
                return this.DetailFile.Text; 
            }
            set 
            { 
                this.DetailFile.Text = value;
            }
        }      
    }
}
