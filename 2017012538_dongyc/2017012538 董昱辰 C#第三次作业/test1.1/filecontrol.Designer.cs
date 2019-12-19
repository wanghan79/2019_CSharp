namespace test1._1
{
    partial class FormWindows
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.search = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.confgBox = new System.Windows.Forms.ListBox();
            this.fileBox = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.selectBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(926, 44);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(108, 35);
            this.search.TabIndex = 0;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.Search_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(926, 254);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(108, 36);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "OpenFile";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(926, 320);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(108, 36);
            this.saveFile.TabIndex = 2;
            this.saveFile.Text = "SaveFile";
            this.saveFile.UseVisualStyleBackColor = true;
            // 
            // confgBox
            // 
            this.confgBox.FormattingEnabled = true;
            this.confgBox.ItemHeight = 18;
            this.confgBox.Location = new System.Drawing.Point(13, 111);
            this.confgBox.MultiColumn = true;
            this.confgBox.Name = "confgBox";
            this.confgBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.confgBox.Size = new System.Drawing.Size(861, 112);
            this.confgBox.TabIndex = 4;
            this.confgBox.SelectedIndexChanged += new System.EventHandler(this.ConfgBox_SelectedIndexChanged);
            // 
            // fileBox
            // 
            this.fileBox.FormattingEnabled = true;
            this.fileBox.ItemHeight = 18;
            this.fileBox.Location = new System.Drawing.Point(12, 254);
            this.fileBox.MultiColumn = true;
            this.fileBox.Name = "fileBox";
            this.fileBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.fileBox.Size = new System.Drawing.Size(862, 292);
            this.fileBox.TabIndex = 5;
            this.fileBox.SelectedIndexChanged += new System.EventHandler(this.FileBox_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectBox
            // 
            this.selectBox.Location = new System.Drawing.Point(13, 44);
            this.selectBox.Multiline = true;
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(861, 35);
            this.selectBox.TabIndex = 0;
            this.selectBox.TextChanged += new System.EventHandler(this.SelectBox_TextChanged_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // backgroundWorker1
            // 
           // this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // FormWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 614);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.fileBox);
            this.Controls.Add(this.confgBox);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.search);
            this.Name = "FormWindows";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        private System.Windows.Forms.ListBox confgBox;
        private System.Windows.Forms.ListBox fileBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox selectBox;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

