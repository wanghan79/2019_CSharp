namespace SaveFiles
{
    partial class MyForm
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
            this.btOpenFile = new System.Windows.Forms.Button();
            this.btSaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(118, 394);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(250, 101);
            this.btOpenFile.TabIndex = 0;
            this.btOpenFile.Text = "Openfiles";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // btSaveFile
            // 
            this.btSaveFile.Location = new System.Drawing.Point(624, 394);
            this.btSaveFile.Name = "btSaveFile";
            this.btSaveFile.Size = new System.Drawing.Size(245, 105);
            this.btSaveFile.TabIndex = 1;
            this.btSaveFile.Text = "SaveFiles";
            this.btSaveFile.UseVisualStyleBackColor = true;
            this.btSaveFile.Click += new System.EventHandler(this.btSaveFile_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.btSaveFile);
            this.Controls.Add(this.btOpenFile);
            this.Name = "MyForm";
            this.Text = "MyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Button btSaveFile;
    }
}

