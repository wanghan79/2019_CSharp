using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<string> TheWayFile = new List<string>();
        string spath;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opdl = new OpenFileDialog();            opdl.Multiselect = true;            opdl.ShowDialog();            spath = opdl.FileName.Substring(0,opdl.FileName.LastIndexOf("\\"));            foreach (string sfile in opdl.FileNames)            {
                
                string sname = sfile.Substring(sfile.LastIndexOf("\\") +                  1, sfile.Length - sfile.LastIndexOf("\\") - 1);
                TheWayFile.Add(sname);
                //string filename = System.IO.Path.GetFileName(fullPath);//文件名  “Default.aspx”
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sadl = new SaveFileDialog();            sadl.ShowDialog();            string s_dir = sadl.FileName;            System.IO.Directory.CreateDirectory(s_dir);            foreach (string sfile in TheWayFile)            {                //MessageBox.Show(sfile);                System.IO.File.Copy(spath+"//"+sfile, s_dir + "//" + sfile);//添加根目录            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://timgsa.baidu.com/timg?image&quality=80&size=b9999_10000&sec=1569506273&di=f86e94feca77ac64d126d0c9d88321f5&imgtype=jpg&er=1&src=http%3A%2F%2F5b0988e595225.cdn.sohucs.com%2Fimages%2F20180227%2F4fe347ddc2ab4d54a29fa90585a2b2af.jpeg");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://image.baidu.com/search/detail?ct=503316480&z=0&ipn=d&word=%E6%88%91%E5%AD%A6%E4%B8%8D%E5%AE%8C%E4%BA%86&step_word=&hs=0&pn=1&spn=0&di=330&pi=0&rn=1&tn=baiduimagedetail&is=0%2C0&istype=0&ie=utf-8&oe=utf-8&in=&cl=2&lm=-1&st=-1&cs=2854835157%2C529046435&os=4135719582%2C3524409862&simid=3513693978%2C348885890&adpicid=0&lpn=0&ln=1269&fr=&fmq=1568902098991_R&fm=rs5&ic=undefined&s=undefined&hd=undefined&latest=undefined&copyright=undefined&se=&sme=&tab=0&width=undefined&height=undefined&face=undefined&ist=&jit=&cg=&bdtype=0&oriquery=%E6%88%91%E7%9C%9F%E7%9A%84%E5%AD%A6%E4%B8%8D%E5%8A%A8%E4%BA%86&objurl=http%3A%2F%2F5b0988e595225.cdn.sohucs.com%2Fq_70%2Cc_zoom%2Cw_640%2Fimages%2F20190106%2F971fdb8aff3349fba3f3431f65ed0265.jpeg&fromurl=ippr_z2C%24qAzdH3FAzdH3F4_z%26e3Bf5i7_z%26e3Bv54AzdH3FwAzdH3Fdb0aaam9n_llldc89b&gsm=0&rpstart=0&rpnum=0&islist=&querylist=&force=undefined");
        }
    }
}
