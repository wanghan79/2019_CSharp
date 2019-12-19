namespace 线程_第三次作业_
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
            this.txbFilePath = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lsbFile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txbFilePath
            // 
            this.txbFilePath.Location = new System.Drawing.Point(32, 23);
            this.txbFilePath.Name = "txbFilePath";
            this.txbFilePath.Size = new System.Drawing.Size(334, 28);
            this.txbFilePath.TabIndex = 0;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(388, 18);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(114, 34);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "打开文件夹";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lsbFile
            // 
            this.lsbFile.FormattingEnabled = true;
            this.lsbFile.ItemHeight = 18;
            this.lsbFile.Location = new System.Drawing.Point(32, 81);
            this.lsbFile.Name = "lsbFile";
            this.lsbFile.Size = new System.Drawing.Size(444, 328);
            this.lsbFile.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 437);
            this.Controls.Add(this.lsbFile);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txbFilePath);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbFilePath;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.ListBox lsbFile;
    }
}

