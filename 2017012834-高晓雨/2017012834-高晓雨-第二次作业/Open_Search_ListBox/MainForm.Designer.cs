namespace Open_Search_ListBox
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txChoseFile = new System.Windows.Forms.TextBox();
            this.btChoseFile = new System.Windows.Forms.Button();
            this.txChose = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.btChose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txChoseFile
            // 
            this.txChoseFile.Location = new System.Drawing.Point(37, 41);
            this.txChoseFile.Name = "txChoseFile";
            this.txChoseFile.Size = new System.Drawing.Size(367, 28);
            this.txChoseFile.TabIndex = 0;
            // 
            // btChoseFile
            // 
            this.btChoseFile.Location = new System.Drawing.Point(434, 33);
            this.btChoseFile.Name = "btChoseFile";
            this.btChoseFile.Size = new System.Drawing.Size(100, 36);
            this.btChoseFile.TabIndex = 1;
            this.btChoseFile.Text = "选择";
            this.btChoseFile.UseVisualStyleBackColor = true;
            this.btChoseFile.Click += new System.EventHandler(this.btChoseFile_Click);
            // 
            // txChose
            // 
            this.txChose.Location = new System.Drawing.Point(54, 87);
            this.txChose.Name = "txChose";
            this.txChose.Size = new System.Drawing.Size(322, 28);
            this.txChose.TabIndex = 3;
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 18;
            this.ListBox.Location = new System.Drawing.Point(54, 154);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(448, 292);
            this.ListBox.TabIndex = 4;
            this.ListBox.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(444, 465);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(90, 43);
            this.btOpenFile.TabIndex = 5;
            this.btOpenFile.Text = "打开";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // btChose
            // 
            this.btChose.Location = new System.Drawing.Point(434, 81);
            this.btChose.Name = "btChose";
            this.btChose.Size = new System.Drawing.Size(100, 36);
            this.btChose.TabIndex = 6;
            this.btChose.Text = "筛选";
            this.btChose.UseVisualStyleBackColor = true;
            this.btChose.Click += new System.EventHandler(this.btChose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 533);
            this.Controls.Add(this.btChose);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.txChose);
            this.Controls.Add(this.btChoseFile);
            this.Controls.Add(this.txChoseFile);
            this.Name = "MainForm";
            this.Text = "Open&Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txChoseFile;
        private System.Windows.Forms.Button btChoseFile;
        private System.Windows.Forms.TextBox txChose;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Button btChose;
    }
}

