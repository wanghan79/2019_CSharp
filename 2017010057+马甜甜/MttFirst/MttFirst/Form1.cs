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



namespace MttFirst
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void file_Click(object sender, EventArgs e)
        {
            OpenFileDialog filename = new OpenFileDialog(); //定义打开文件           
            filename.InitialDirectory = Application.StartupPath; //初始路径,这里设置的是程序的起始位置，可自由设置           
            filename.Filter = "All files(*.*)|*.*|txt files(*.txt)|*.txt";//设置打开类型,设置个*.*和*.txt就行了            
            filename.FilterIndex = 2;                  //文件类型的显示顺序（上一行.txt设为第二位）            
            filename.RestoreDirectory = true; //对话框记忆之前打开的目录            
            if (filename.ShowDialog() == DialogResult.OK)
            {
                path.Text = filename.FileName.ToString();//获得完整路径在textBox1中显示              
                StreamReader sr = new StreamReader(filename.FileName, Encoding.Default);//将选中的文件在textBox2中显示            
                show.Text = sr.ReadToEnd();
                sr.Close();
            }
        }
    }
}
