namespace OpenAndSaveFilesFormsApp
{
    partial class OpenAndSaveFiles
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
            this.bt_OpenFiles = new System.Windows.Forms.Button();
            this.bt_SaveFiles = new System.Windows.Forms.Button();
            this.lb_FilePath = new System.Windows.Forms.Label();
            this.tb_FileContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_OpenFiles
            // 
            this.bt_OpenFiles.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_OpenFiles.Location = new System.Drawing.Point(504, 228);
            this.bt_OpenFiles.Name = "bt_OpenFiles";
            this.bt_OpenFiles.Size = new System.Drawing.Size(239, 61);
            this.bt_OpenFiles.TabIndex = 0;
            this.bt_OpenFiles.Text = "OpenFiles";
            this.bt_OpenFiles.UseVisualStyleBackColor = true;
            this.bt_OpenFiles.Click += new System.EventHandler(this.OpenFiles_Click);
            // 
            // bt_SaveFiles
            // 
            this.bt_SaveFiles.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_SaveFiles.Location = new System.Drawing.Point(504, 317);
            this.bt_SaveFiles.Name = "bt_SaveFiles";
            this.bt_SaveFiles.Size = new System.Drawing.Size(239, 61);
            this.bt_SaveFiles.TabIndex = 1;
            this.bt_SaveFiles.Text = "SaveFiles";
            this.bt_SaveFiles.UseVisualStyleBackColor = true;
            this.bt_SaveFiles.Click += new System.EventHandler(this.SaveFiles_Click);
            // 
            // lb_FilePath
            // 
            this.lb_FilePath.AutoSize = true;
            this.lb_FilePath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_FilePath.Location = new System.Drawing.Point(47, 37);
            this.lb_FilePath.Name = "lb_FilePath";
            this.lb_FilePath.Size = new System.Drawing.Size(93, 27);
            this.lb_FilePath.TabIndex = 2;
            this.lb_FilePath.Text = "FilePath";
            // 
            // tb_FileContent
            // 
            this.tb_FileContent.Location = new System.Drawing.Point(50, 67);
            this.tb_FileContent.Multiline = true;
            this.tb_FileContent.Name = "tb_FileContent";
            this.tb_FileContent.Size = new System.Drawing.Size(413, 311);
            this.tb_FileContent.TabIndex = 3;
            // 
            // OpenAndSaveFiles
            // 
            this.ClientSize = new System.Drawing.Size(755, 431);
            this.Controls.Add(this.tb_FileContent);
            this.Controls.Add(this.lb_FilePath);
            this.Controls.Add(this.bt_SaveFiles);
            this.Controls.Add(this.bt_OpenFiles);
            this.Name = "OpenAndSaveFiles";
            this.Text = "OpenAndSaveFiles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_OpenFiles;
        private System.Windows.Forms.Button bt_SaveFiles;
        private System.Windows.Forms.Label lb_FilePath;
        private System.Windows.Forms.TextBox tb_FileContent;
    }
}

