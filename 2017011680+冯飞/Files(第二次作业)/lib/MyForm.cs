using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Files.lib
{
    public partial class Myform : Form
    {
        public Myform()
        {
            InitializeComponent();
        }

        private void Myform_Load(object sender, EventArgs e)
        {
            this.lab_openfileName.Text = Files.listBoxFile.fs.fileSelected;
            System.DateTime dateTime = new System.DateTime();
            dateTime = System.DateTime.Now;
            this.lab_openfile_time.Text = dateTime.ToString();
            this.richTextBox_show.LoadFile(Files.listBoxFile.fs.selectedFile, RichTextBoxStreamType.PlainText);
        }
    }
}
