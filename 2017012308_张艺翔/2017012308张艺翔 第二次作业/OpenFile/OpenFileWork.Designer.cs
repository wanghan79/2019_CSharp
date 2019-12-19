namespace OpenFile
{
    partial class OpenFileWork
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
            this.OpenFile = new System.Windows.Forms.Button();
            this.ReadTime = new System.Windows.Forms.Label();
            this.tbFileContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(84, 48);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(270, 90);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "OpenFile";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // ReadTime
            // 
            this.ReadTime.AutoSize = true;
            this.ReadTime.Location = new System.Drawing.Point(81, 185);
            this.ReadTime.Name = "ReadTime";
            this.ReadTime.Size = new System.Drawing.Size(71, 15);
            this.ReadTime.TabIndex = 1;
            this.ReadTime.Text = "ReadTime";
            this.ReadTime.Click += new System.EventHandler(this.ReadTime_Click);
            // 
            // tbFileContent
            // 
            this.tbFileContent.Location = new System.Drawing.Point(449, 48);
            this.tbFileContent.Multiline = true;
            this.tbFileContent.Name = "tbFileContent";
            this.tbFileContent.Size = new System.Drawing.Size(486, 381);
            this.tbFileContent.TabIndex = 2;
            this.tbFileContent.TextChanged += new System.EventHandler(this.tbFileContent_TextChanged);
            // 
            // OpenFileWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 482);
            this.Controls.Add(this.tbFileContent);
            this.Controls.Add(this.ReadTime);
            this.Controls.Add(this.OpenFile);
            this.Name = "OpenFileWork";
            this.Text = "OpenFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Label ReadTime;
        private System.Windows.Forms.TextBox tbFileContent;
    }
}

