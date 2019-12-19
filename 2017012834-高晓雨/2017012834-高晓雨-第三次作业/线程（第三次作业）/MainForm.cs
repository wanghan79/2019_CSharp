using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 线程_第三次作业_
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
           searchALLFiles = new List<string>();
        }
        public static void searchFile(object obj)
        {
            string dirPath = obj.ToString();
            if (dirPath != null && dirPath.Length > 0)
            {
                if (Directory.Exists(dirPath))
                {
                    if(searchALLFiles!=null)
                        searchALLFiles.Clear();
                    List<string> Files = new List<string>();
                    List<string> Dirs = new List<string>();
                    Dirs.Add(dirPath);
                    while (Dirs.Count > 0)
                    {
                        try
                        {
                            string searchDir = Dirs[0];
                            Dirs.RemoveAt(0);
                            string[] files = Directory.GetFiles(searchDir);
                            string[] dirs = Directory.GetDirectories(searchDir);
                            foreach (string item in files)
                                Files.Add(item);
                            foreach (string item in dirs)
                                Dirs.Add(item);
                        }
                        catch { }
                    }
                    searchALLFiles.AddRange(Files);
                }
            }
        }
        private void btSearch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            if (folderDlg.ShowDialog() == DialogResult.OK)
            {
                txbFilePath.Text = folderDlg.SelectedPath;
            }
            object obj = txbFilePath.Text;
            Thread thread = new Thread(new ParameterizedThreadStart(searchFile));//创建线程
            thread.Start(obj);//启动线程
            //lsbFile.Items.AddRange(searchALLFiles.ToArray());
        }

        public static List<string> searchALLFiles;
    }
}
