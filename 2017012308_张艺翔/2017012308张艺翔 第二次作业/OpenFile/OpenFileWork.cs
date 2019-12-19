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

namespace OpenFile
{
    public partial class OpenFileWork : Form
    {
        public OpenFileWork()
        {
            InitializeComponent();
        }
        string path;

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
            dialog.Title = "Please choose the file you want open";
            path = dialog.FileName;
            this.tbFileContent.Text =File.ReadAllText(path);
            this.ReadTime.Text = "CreateTime：" + File.GetCreationTime(path) + "\r\nLastWriteTime：" + File.GetLastWriteTime(path) + "\r\nLastAccessTime：" + File.GetLastAccessTime(path);
        }

        private void ReadTime_Click(object sender, EventArgs e)
        {
         
  
 }

        private void tbFileContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
