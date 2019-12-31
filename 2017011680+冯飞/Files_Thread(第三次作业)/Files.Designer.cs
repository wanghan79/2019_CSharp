namespace Files
{
    partial class listBoxFile
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
            this.watchFile = new System.Windows.Forms.Button();
            this.openfile = new System.Windows.Forms.TextBox();
            this.openfiles = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // watchFile
            // 
            this.watchFile.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.watchFile.Location = new System.Drawing.Point(340, 12);
            this.watchFile.Name = "watchFile";
            this.watchFile.Size = new System.Drawing.Size(75, 31);
            this.watchFile.TabIndex = 0;
            this.watchFile.Text = "...";
            this.watchFile.UseVisualStyleBackColor = true;
            this.watchFile.Click += new System.EventHandler(this.watchFile_Click);
            // 
            // openfile
            // 
            this.openfile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.openfile.Location = new System.Drawing.Point(39, 12);
            this.openfile.Multiline = true;
            this.openfile.Name = "openfile";
            this.openfile.Size = new System.Drawing.Size(282, 31);
            this.openfile.TabIndex = 1;
            this.openfile.TextChanged += new System.EventHandler(this.openfile_TextChanged);
            // 
            // openfiles
            // 
            this.openfiles.Location = new System.Drawing.Point(340, 367);
            this.openfiles.Name = "openfiles";
            this.openfiles.Size = new System.Drawing.Size(75, 39);
            this.openfiles.TabIndex = 2;
            this.openfiles.Text = "Open";
            this.openfiles.UseVisualStyleBackColor = true;
            this.openfiles.Click += new System.EventHandler(this.openfiles_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSearch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSearch.Location = new System.Drawing.Point(39, 55);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(282, 23);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(39, 102);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(282, 304);
            this.listBox.TabIndex = 5;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            this.listBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDoubleClick);
            // 
            // listBoxFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 432);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.openfiles);
            this.Controls.Add(this.openfile);
            this.Controls.Add(this.watchFile);
            this.Name = "listBoxFile";
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.listBoxFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button watchFile;
        private System.Windows.Forms.TextBox openfile;
        private System.Windows.Forms.Button openfiles;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBox;
    }
}

