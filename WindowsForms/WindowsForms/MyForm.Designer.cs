namespace WindowsForms
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
        /// 设计器支持所需的方法 - 不要
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
            this.btOpenFile.Location = new System.Drawing.Point(120, 435);
            this.btOpenFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(231, 80);
            this.btOpenFile.TabIndex = 0;
            this.btOpenFile.Text = "OpenFile";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // btSaveFile
            // 
            this.btSaveFile.Location = new System.Drawing.Point(679, 435);
            this.btSaveFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSaveFile.Name = "btSaveFile";
            this.btSaveFile.Size = new System.Drawing.Size(233, 80);
            this.btSaveFile.TabIndex = 1;
            this.btSaveFile.Text = "SaveFile";
            this.btSaveFile.UseVisualStyleBackColor = true;
            this.btSaveFile.Click += new System.EventHandler(this.btSaveFile_Click);
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 568);
            this.Controls.Add(this.btSaveFile);
            this.Controls.Add(this.btOpenFile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MyForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btSaveFile;
        private System.Windows.Forms.Button btOpenFile;
    }
}

