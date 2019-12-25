namespace MyFiles
{
    partial class ryyThread
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
            this.ChsFolder = new System.Windows.Forms.Button();
            this.ShowFolder = new System.Windows.Forms.TextBox();
            this.FileType = new System.Windows.Forms.TextBox();
            this.ShowFile = new System.Windows.Forms.ListBox();
            this.btRunFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChsFolder
            // 
            this.ChsFolder.Location = new System.Drawing.Point(286, 44);
            this.ChsFolder.Name = "ChsFolder";
            this.ChsFolder.Size = new System.Drawing.Size(89, 25);
            this.ChsFolder.TabIndex = 0;
            this.ChsFolder.Text = "ChsFolder";
            this.ChsFolder.UseVisualStyleBackColor = true;
            this.ChsFolder.Click += new System.EventHandler(this.ChsFolder_Click);
            // 
            // ShowFolder
            // 
            this.ShowFolder.Location = new System.Drawing.Point(30, 44);
            this.ShowFolder.Name = "ShowFolder";
            this.ShowFolder.Size = new System.Drawing.Size(194, 21);
            this.ShowFolder.TabIndex = 1;
            this.ShowFolder.TextChanged += new System.EventHandler(this.ShowFolder_TextChanged);
            // 
            // FileType
            // 
            this.FileType.Location = new System.Drawing.Point(30, 114);
            this.FileType.Name = "FileType";
            this.FileType.Size = new System.Drawing.Size(194, 21);
            this.FileType.TabIndex = 2;
            this.FileType.TextChanged += new System.EventHandler(this.FileType_TextChanged);
            this.FileType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FileType_KeyPress);
            // 
            // ShowFile
            // 
            this.ShowFile.FormattingEnabled = true;
            this.ShowFile.ItemHeight = 12;
            this.ShowFile.Location = new System.Drawing.Point(30, 181);
            this.ShowFile.Name = "ShowFile";
            this.ShowFile.Size = new System.Drawing.Size(194, 136);
            this.ShowFile.TabIndex = 3;
            this.ShowFile.SelectedIndexChanged += new System.EventHandler(this.ShowFile_SelectedIndexChanged);
            this.ShowFile.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ShowFile_MouseDoubleClick);
            // 
            // btRunFile
            // 
            this.btRunFile.Location = new System.Drawing.Point(286, 294);
            this.btRunFile.Name = "btRunFile";
            this.btRunFile.Size = new System.Drawing.Size(89, 23);
            this.btRunFile.TabIndex = 4;
            this.btRunFile.Text = "btRunFile";
            this.btRunFile.UseVisualStyleBackColor = true;
            this.btRunFile.Click += new System.EventHandler(this.btRunFile_Click);
            // 
            // ryyThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 356);
            this.Controls.Add(this.btRunFile);
            this.Controls.Add(this.ShowFile);
            this.Controls.Add(this.FileType);
            this.Controls.Add(this.ShowFolder);
            this.Controls.Add(this.ChsFolder);
            this.Name = "ryyThread";
            this.Text = "MyFiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChsFolder;
        private System.Windows.Forms.TextBox ShowFolder;
        private System.Windows.Forms.TextBox FileType;
        private System.Windows.Forms.ListBox ShowFile;
        private System.Windows.Forms.Button btRunFile;
    }
}

