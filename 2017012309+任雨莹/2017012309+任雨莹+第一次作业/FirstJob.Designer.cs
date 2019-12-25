namespace WindowsForms
{
    partial class FirstJob
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
            this.btOpenFile = new System.Windows.Forms.Button();
            this.btSaveFile = new System.Windows.Forms.Button();
            this.txShow = new System.Windows.Forms.TextBox();
            this.btChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(155, 149);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btOpenFile.TabIndex = 0;
            this.btOpenFile.Text = "Open File";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // btSaveFile
            // 
            this.btSaveFile.Location = new System.Drawing.Point(260, 149);
            this.btSaveFile.Name = "btSaveFile";
            this.btSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btSaveFile.TabIndex = 1;
            this.btSaveFile.Text = "Save File";
            this.btSaveFile.UseVisualStyleBackColor = true;
            this.btSaveFile.Click += new System.EventHandler(this.btSaveFile_Click);
            // 
            // txShow
            // 
            this.txShow.Location = new System.Drawing.Point(12, 12);
            this.txShow.Multiline = true;
            this.txShow.Name = "txShow";
            this.txShow.Size = new System.Drawing.Size(323, 118);
            this.txShow.TabIndex = 2;
            this.txShow.Text = "\tMonday\tTuesday\tWednesday\r\nCourse\tEnglish\tMath\tChinese";
            this.txShow.TextChanged += new System.EventHandler(this.txShow_TextChanged);
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(12, 149);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(107, 23);
            this.btChange.TabIndex = 3;
            this.btChange.Text = "Change Word";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 198);
            this.Controls.Add(this.btChange);
            this.Controls.Add(this.txShow);
            this.Controls.Add(this.btSaveFile);
            this.Controls.Add(this.btOpenFile);
            this.Name = "MainForm";
            this.Text = "FirstJob";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Button btSaveFile;
        private System.Windows.Forms.TextBox txShow;
        private System.Windows.Forms.Button btChange;
    }
}

