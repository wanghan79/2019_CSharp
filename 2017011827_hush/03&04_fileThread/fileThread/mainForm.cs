using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace fileList
{
    public partial class mainForm : Form
    {
        string pickPath;
        public mainForm()
        {
            InitializeComponent();
        }

        private void cbb_pickFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string format = "*" + cbb_pickFormat.SelectedItem.ToString();
            changeFiles(format, false);
        }

        private void lab_pickPath_Click(object sender, EventArgs e)
        {
            //打开文件夹，选择路径
            System.Windows.Forms.FolderBrowserDialog saveDialog = new System.Windows.Forms.FolderBrowserDialog();
            if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //获取路径
                pickPath = saveDialog.SelectedPath;
                //label显示路径
                lab_pickPath.Text = pickPath;
                changeFiles("*", true);
            }
        }

        private void lsb_fileList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsb_fileList.SelectedItem!=null)
            {
                string openFilePath = lsb_fileList.SelectedItem.ToString();
                    System.Diagnostics.Process.Start(openFilePath);
                
            }
            
        }
        public void changeFiles(string changeFormat,bool isResetFormat)
        {
            //清除listBox与comboBox
            lsb_fileList.Items.Clear();
            if (isResetFormat)
            {
                cbb_pickFormat.Items.Clear();
            }
            //启动新线程搜索
            Search s = new Search();
            s.pickPath = pickPath;
            s.changeFormat = changeFormat;
            Thread newThread = new Thread(s.search);
            newThread.Start();
            newThread.Join();
            //listBox显示文件
            foreach (string file in s.files)
            {
                //再listBox里面添加每个文件
                lsb_fileList.Items.Add(file);
                //获取每个文件的格式
                string extension = Path.GetExtension(file);
                //如果这个文件格式在comboBox中不存在，加入
                if (isResetFormat && cbb_pickFormat.FindStringExact(extension) == -1)
                {
                    cbb_pickFormat.Items.Add(extension);
                }
            }
        }

    }

    public class Search
    {
        public string pickPath;
        public string changeFormat;
        public string[] files;
        public void search()
        {
            //listBox显示文件
            files =  Directory.GetFiles(pickPath, changeFormat, SearchOption.AllDirectories);
        }
    }
}
