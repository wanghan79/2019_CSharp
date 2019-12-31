using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Files;
using System.IO;
namespace Files.lib
{
    class File1
    {
        public string OpenFile()
        {
            string fName = null;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "文本文件|*.*|C#文件|*.cs|所有文件|*.*";
            //openFileDialog.RestoreDirectory = true;
            //openFileDialog.FilterIndex = 1;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                fName = dialog.SelectedPath;
            }
            return fName;
        }
        public void searchFilesFolder(object obj)
        {
            string strDir = obj.ToString();
            if (strDir != null && strDir.Length > 0)
            {
                if (Directory.Exists(strDir))
                {
                    Files.listBoxFile.fs.fileName.Clear();
                    List<string> allFiles = new List<string>();
                    List<string> folder2search = new List<string>();
                    folder2search.Add(strDir);
                    while (folder2search.Count > 0)
                    {
                        try
                        {
                            string curFolder = folder2search[0];
                            folder2search.RemoveAt(0);
                            string [] files = Directory.GetFiles(curFolder);
                            string[] folder = Directory.GetDirectories(curFolder);
                            foreach (string Item in files)
                            {
                                allFiles.Add(Item);
                            }
                            foreach (string Item in folder)
                            {
                                folder2search.Add(Item);
                            }
                        }
                        catch
                        {

                        }
                    }

                    Files.listBoxFile.fs.fileName.AddRange(allFiles);
                }
            }
        }

    }
    public class FileDirectory
    {
        private string _rootDirectory = null;//根目录
        private List<string> _fileName = new List<string>();//根目录下的文件
        private List<string> _DirectoryName = new List<string>();//目录下的文件夹
        private string _selectedFile = null;//被选择文件的路径
        private string _fileSelected = null;//打开文件的名称
        public string rootDirectory
        {
            get
            {
                return _rootDirectory;
            }
            set
            {
                _rootDirectory = value;
            }

        }
        public List<string> fileName
        {
            get{    return _fileName;}
            set{    _fileName = value;}
        }
        public string selectedFile
        {
            get { return _selectedFile; }
            set { _selectedFile = value; }
        }
        public string fileSelected
        {
            get { return _fileSelected; }
            set { _fileSelected = value; }
        }
        public List<string> DirectoryName
        {
            get { return _DirectoryName; }
            set { _DirectoryName = value; }
        }
    }
   class MyControl
    {
        public RichTextBox CreateRichBox()
        {
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Name = "richTextBox_show";
            richTextBox.Location = new System.Drawing.Point(39, 103);
            richTextBox.Size = new System.Drawing.Size(281, 303);
            richTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            return richTextBox;
        }
        public ListBox CreateListBox()
        {
            ListBox listBox = new ListBox();
            listBox.Name = "listBoxFile";
            listBox.Location = new System.Drawing.Point(39, 103);
            listBox.Size = new System.Drawing.Size(281, 303);
            listBox.Enabled = true;

            return listBox;
        }
    }
}
