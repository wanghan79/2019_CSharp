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
    public partial class FnewWindows : Form
    {
        public FnewWindows()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = System.DateTime.Now;
            label1.Text = dt.ToString();
        }
    }
}
