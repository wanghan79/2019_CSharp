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
namespace FileManagement
{
    public partial class ContentForm : Form
    {

        public ContentForm(string strFilePath)
        {
            InitializeComponent();
            init(strFilePath);
        }

        private void init(string strFilePath)
        {
            //string filePath = MainForm.strPath;
            string[] lines = File.ReadAllLines(strFilePath);
            foreach (string line in lines)
            {
                this.tboxContent.AppendText(line + Environment.NewLine);
            }
        }

    }
}
