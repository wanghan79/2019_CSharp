namespace CopyFile
{
    partial class CopyFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyFiles));
            this.btnOpenFiles = new System.Windows.Forms.Button();
            this.ckListBoxFileName = new System.Windows.Forms.CheckedListBox();
            this.btnSaveFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFiles
            // 
            resources.ApplyResources(this.btnOpenFiles, "btnOpenFiles");
            this.btnOpenFiles.Name = "btnOpenFiles";
            this.btnOpenFiles.UseVisualStyleBackColor = true;
            this.btnOpenFiles.Click += new System.EventHandler(this.btnOpenFiles_Click);
            // 
            // ckListBoxFileName
            // 
            this.ckListBoxFileName.FormattingEnabled = true;
            this.ckListBoxFileName.Items.AddRange(new object[] {
            resources.GetString("ckListBoxFileName.Items")});
            resources.ApplyResources(this.ckListBoxFileName, "ckListBoxFileName");
            this.ckListBoxFileName.Name = "ckListBoxFileName";
            // 
            // btnSaveFiles
            // 
            resources.ApplyResources(this.btnSaveFiles, "btnSaveFiles");
            this.btnSaveFiles.Name = "btnSaveFiles";
            this.btnSaveFiles.UseVisualStyleBackColor = true;
            this.btnSaveFiles.Click += new System.EventHandler(this.btnSaveFiles_Click);
            // 
            // CopyFiles
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckListBoxFileName);
            this.Controls.Add(this.btnSaveFiles);
            this.Controls.Add(this.btnOpenFiles);
            this.MaximizeBox = false;
            this.Name = "CopyFiles";
            this.Load += new System.EventHandler(this.CopyFiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFiles;
        private System.Windows.Forms.CheckedListBox ckListBoxFileName;
        private System.Windows.Forms.Button btnSaveFiles;
    }
}

