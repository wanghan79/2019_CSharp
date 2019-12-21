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

namespace FirstClass
{
    public partial class saveFile : Form
    {
        public saveFile()
        {
            InitializeComponent();
        }

        string path;
     

        private void btn_openFiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.*)|*.*";                
            ofd.RestoreDirectory = true;             
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               path = ofd.FileName;
            }
            FileStream filename = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(filename, Encoding.Default);
            txt_showFiles.Text = sr.ReadToEnd();
            
        }

        private void btn_saveFiles_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            
            sfd.Title = "请选择保存文件";
            sfd.Filter = "文档 | *.txt ;*.docx";
            sfd.ShowDialog();
            using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[300];
                    while (true)
                    {
                      
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        if (r == 0)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);
                    }
                    MessageBox.Show("保存成功");

                }

            }

        }
    }
    
}
