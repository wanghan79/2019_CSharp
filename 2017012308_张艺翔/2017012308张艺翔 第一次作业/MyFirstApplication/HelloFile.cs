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

namespace MyFirstApplication
{
    public partial class HelloFile : Form
    {
        public HelloFile()
        {
            InitializeComponent();
        }

        string SourcePath;
        string path;

        private void OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            ofd.Title = "Please choose the file you want to operate";
            SourcePath = ofd.FileName;

        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "";
            sfd.ShowDialog();
            path = sfd.FileName;

            File.Copy(SourcePath,path);

            }
        
    }
}
