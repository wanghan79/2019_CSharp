using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SaveFile.Models;
namespace SaveFile
{
    public partial class SaveFile : Form
    {
        public SaveFile()
        {
            InitializeComponent();
            btnSaveFile.Enabled = false;
        }
        private FrmFileOperation openFile = new FrmFileOperation();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (this.openFile.OpenFolder())
            {
                btnSaveFile.Enabled = true;
                openFilePath.Text = this.openFile.openFilelabel();
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (openFile.SaveFile())
            {
                btnSaveFile.Enabled = false;
                LabelSave.Text = this.openFile.SaveFilelabel();
            }
            else
            {
                btnSaveFile.Enabled = true;
                
            }
        }
        private Point _mousePoint;
        private void Form_MouseMove(object sender, MouseEventArgs e)
        { if (e.Button == MouseButtons.Left)
            {
                Top = MousePosition.Y - _mousePoint.Y;
                Left = MousePosition.X - _mousePoint.X;
            }
        }
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mousePoint.X = e.X; _mousePoint.Y = e.Y;
            }
        }  
    }
}
