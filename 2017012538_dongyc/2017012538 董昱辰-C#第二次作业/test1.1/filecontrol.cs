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


namespace test1._1
{
    public partial class filecontrol : Form
    {
        public filecontrol()
        {
            InitializeComponent();
        }
        string[] Filename = new string [1000];
        string[] LastName = new string [1000];
        int lastnum , filenum ;
        String path;
        private void Search_Click(object sender, EventArgs e)
        {
            confgBox.Items.Clear();
            path = selectBox.Text.ToString();
            if (selectBox.Text != String.Empty)
            {
                //System.Diagnostics.Process.Start(path);
                DirectoryInfo dir = new DirectoryInfo(path);
                FileInfo[] files = dir.GetFiles();
                lastnum = 0;
                filenum = 0;
                foreach (FileInfo file in files)
                {
                    bool flag = false;
                    //MessageBox.Show(file.ToString()) ;
                    string filename = file.ToString();
                    string aLastName = filename.Substring(filename.LastIndexOf(".") + 1,
                        (filename.Length - filename.LastIndexOf(".") - 1)); //扩展名
                    for (int i = 0; i < lastnum; ++i)
                    {
                        if (LastName[i] == aLastName)
                            flag = true;
                    }
                    if (!flag)
                    {
                        LastName[lastnum] = aLastName;
                        confgBox.Items.Add(aLastName);
                        lastnum++;
                    }
                    Filename[filenum] = filename;
                    filenum++;
                }
            }
            else
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "请选择文件夹";
                if (dialog.ShowDialog() == DialogResult.OK || dialog.ShowDialog() == DialogResult.Yes)
                {
                    selectBox.Text = dialog.SelectedPath;
                    path = dialog.SelectedPath;
                    DirectoryInfo dir = new DirectoryInfo(path);
                    FileInfo[] files = dir.GetFiles();
                    lastnum = 0;
                    filenum = 0;
                    foreach (FileInfo file in files)
                    {
                        bool flag = false;
                        //MessageBox.Show(file.ToString()) ;
                        string filename = file.ToString();
                        string aLastName = filename.Substring(filename.LastIndexOf(".") + 1,
                            (filename.Length - filename.LastIndexOf(".") - 1)); //扩展名
                        for (int i = 0; i < lastnum; ++i)
                        {
                            if (LastName[i] == aLastName)
                                flag = true;
                        }
                        if (!flag)
                        {
                            LastName[lastnum] = aLastName;
                            confgBox.Items.Add(aLastName);
                            lastnum++;
                        }
                        Filename[filenum] = filename;
                        filenum++;
                    }
                }
            }
        }

       

        private void SelectBox_TextChanged(object sender, EventArgs e)
        {
            path=selectBox.Text.ToString();
        }

        private void FileBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileBox.MultiColumn = true;
            int selectnum = fileBox.SelectedItems.Count;
            string[] selectfile = new string[1000];
            for (int j = 0; j < selectnum; j++)
                selectfile[j] = fileBox.SelectedItems[j].ToString();
            for(int i=0;i<selectnum;++i)
            {
                string filepath=path+"\\"+selectfile[i];
                System.Diagnostics.Process.Start(filepath);
            }
            
        }

        private void ConfgBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileBox.Items.Clear();
            confgBox.MultiColumn = true;
            int selectnum = confgBox.SelectedItems.Count;
            string[] selectconfg =new string[1000];
            for (int j = 0; j < selectnum; j++)
                selectconfg[j]= confgBox.SelectedItems[j].ToString();
           // MessageBox.Show(s);
           for(int i=0;i<filenum;++i)
            {
                string name = Filename[i];
                string lastName = name.Substring(name.LastIndexOf(".") + 1,
                        (name.Length - name.LastIndexOf(".") - 1)); 
                for(int j=0;j<selectnum;++j)
                {
                    if (lastName == selectconfg[j])
                         fileBox.Items.Add(name);
                }
            }

        }
    }
}
