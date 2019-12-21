namespace SearchFile
{
    partial class FinalFileForm
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
            this.btChooseFile = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.tbNotice = new System.Windows.Forms.TextBox();
            this.FileList = new System.Windows.Forms.ListBox();
            this.btSiftFile = new System.Windows.Forms.Button();
            this.TimeBar = new System.Windows.Forms.ProgressBar();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btChooseFile
            // 
            this.btChooseFile.Location = new System.Drawing.Point(568, 21);
            this.btChooseFile.Name = "btChooseFile";
            this.btChooseFile.Size = new System.Drawing.Size(95, 34);
            this.btChooseFile.TabIndex = 0;
            this.btChooseFile.Text = ". . .";
            this.btChooseFile.UseVisualStyleBackColor = true;
            this.btChooseFile.Click += new System.EventHandler(this.btChooseFile_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(25, 28);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(516, 25);
            this.tbPath.TabIndex = 1;
            this.tbPath.TextChanged += new System.EventHandler(this.tbPath_TextChanged);
            // 
            // tbNotice
            // 
            this.tbNotice.Location = new System.Drawing.Point(25, 91);
            this.tbNotice.Name = "tbNotice";
            this.tbNotice.Size = new System.Drawing.Size(516, 25);
            this.tbNotice.TabIndex = 2;
            this.tbNotice.Text = "请输入要查询的类型，如“*.txt”,或指定文件。";
            this.tbNotice.TextChanged += new System.EventHandler(this.tbNotice_TextChanged);
            // 
            // FileList
            // 
            this.FileList.FormattingEnabled = true;
            this.FileList.ItemHeight = 15;
            this.FileList.Location = new System.Drawing.Point(25, 158);
            this.FileList.Name = "FileList";
            this.FileList.Size = new System.Drawing.Size(638, 214);
            this.FileList.TabIndex = 3;
            // 
            // btSiftFile
            // 
            this.btSiftFile.Location = new System.Drawing.Point(568, 90);
            this.btSiftFile.Name = "btSiftFile";
            this.btSiftFile.Size = new System.Drawing.Size(95, 26);
            this.btSiftFile.TabIndex = 4;
            this.btSiftFile.Text = "SiftFile";
            this.btSiftFile.UseVisualStyleBackColor = true;
            this.btSiftFile.Click += new System.EventHandler(this.btSiftFile_Click);
            // 
            // TimeBar
            // 
            this.TimeBar.Location = new System.Drawing.Point(25, 409);
            this.TimeBar.Name = "TimeBar";
            this.TimeBar.Size = new System.Drawing.Size(591, 23);
            this.TimeBar.TabIndex = 5;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(641, 417);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(37, 15);
            this.label.TabIndex = 6;
            this.label.Text = "进度";
            // 
            // FinalFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 483);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TimeBar);
            this.Controls.Add(this.btSiftFile);
            this.Controls.Add(this.FileList);
            this.Controls.Add(this.tbNotice);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btChooseFile);
            this.Name = "FinalFileForm";
            this.Text = "SearchFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChooseFile;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.TextBox tbNotice;
        private System.Windows.Forms.ListBox FileList;
        private System.Windows.Forms.Button btSiftFile;
        private System.Windows.Forms.ProgressBar TimeBar;
        private System.Windows.Forms.Label label;
    }
}

