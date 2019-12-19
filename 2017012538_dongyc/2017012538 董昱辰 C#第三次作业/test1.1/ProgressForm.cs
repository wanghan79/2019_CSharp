using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1._1
{
    public partial class ProgressForm : Form
    {
        double pos;
        public ProgressForm(BackgroundWorker bgWork,double p)
        {
            InitializeComponent();
            pos = p;
            this.backgroundWorker1 = bgWork;
            //绑定进度条改变事件
            this.backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            //绑定后台操作完成，取消，异常时的事件
            this.backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

        }
        void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = (int)pos;  //获取异步任务的进度百分比
        }

        void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Close();  //执行完之后，直接关闭页面
        }

        //取消
        private void BtnCancel_Click_1(object sender, EventArgs e)
        {
            this.backgroundWorker1.CancelAsync(); //请求取消挂起的后台操作
            this.btnCancel.Enabled = false;
            this.Close();
        }
    }
}
