namespace FileWork
{
    partial class FileWorkMain
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
            this.tb_FilePath = new System.Windows.Forms.TextBox();
            this.btn_FolderBrowser = new System.Windows.Forms.Button();
            this.lvw_FileList = new System.Windows.Forms.ListView();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_GoTo = new System.Windows.Forms.Button();
            this.tb_SearchFile = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_FilePath
            // 
            this.tb_FilePath.Location = new System.Drawing.Point(67, 40);
            this.tb_FilePath.Name = "tb_FilePath";
            this.tb_FilePath.Size = new System.Drawing.Size(197, 25);
            this.tb_FilePath.TabIndex = 1;
            this.tb_FilePath.Enter += new System.EventHandler(this.tb_FilePath_Enter);
            this.tb_FilePath.Leave += new System.EventHandler(this.tb_FilePath_Leave);
            // 
            // btn_FolderBrowser
            // 
            this.btn_FolderBrowser.Location = new System.Drawing.Point(353, 40);
            this.btn_FolderBrowser.Name = "btn_FolderBrowser";
            this.btn_FolderBrowser.Size = new System.Drawing.Size(174, 25);
            this.btn_FolderBrowser.TabIndex = 2;
            this.btn_FolderBrowser.Text = "打开文件资源管理器";
            this.btn_FolderBrowser.UseVisualStyleBackColor = true;
            this.btn_FolderBrowser.Click += new System.EventHandler(this.bt_FolderBrowser_Click);
            // 
            // lvw_FileList
            // 
            this.lvw_FileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FileDate,
            this.FileType});
            this.lvw_FileList.HideSelection = false;
            this.lvw_FileList.Location = new System.Drawing.Point(67, 162);
            this.lvw_FileList.Name = "lvw_FileList";
            this.lvw_FileList.Size = new System.Drawing.Size(679, 276);
            this.lvw_FileList.TabIndex = 3;
            this.lvw_FileList.UseCompatibleStateImageBehavior = false;
            this.lvw_FileList.View = System.Windows.Forms.View.Details;
            // 
            // FileName
            // 
            this.FileName.Text = "文件名称";
            this.FileName.Width = 267;
            // 
            // FileDate
            // 
            this.FileDate.Text = "修改日期";
            this.FileDate.Width = 164;
            // 
            // FileType
            // 
            this.FileType.Text = "文件类型";
            this.FileType.Width = 96;
            // 
            // btn_GoTo
            // 
            this.btn_GoTo.Location = new System.Drawing.Point(270, 40);
            this.btn_GoTo.Name = "btn_GoTo";
            this.btn_GoTo.Size = new System.Drawing.Size(77, 25);
            this.btn_GoTo.TabIndex = 0;
            this.btn_GoTo.Text = "转到";
            this.btn_GoTo.UseVisualStyleBackColor = true;
            this.btn_GoTo.Click += new System.EventHandler(this.bt_Goto_Click);
            // 
            // tb_SearchFile
            // 
            this.tb_SearchFile.Location = new System.Drawing.Point(67, 97);
            this.tb_SearchFile.Name = "tb_SearchFile";
            this.tb_SearchFile.Size = new System.Drawing.Size(197, 25);
            this.tb_SearchFile.TabIndex = 4;
            this.tb_SearchFile.Enter += new System.EventHandler(this.tb_SearchFile_Enter);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(314, 97);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(81, 25);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "查找";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(787, 306);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(97, 39);
            this.btn_OpenFile.TabIndex = 6;
            this.btn_OpenFile.Text = "打开文件";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.bt_OpenFile_Click);
            // 
            // FileWorkMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 487);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.tb_SearchFile);
            this.Controls.Add(this.btn_GoTo);
            this.Controls.Add(this.lvw_FileList);
            this.Controls.Add(this.btn_FolderBrowser);
            this.Controls.Add(this.tb_FilePath);
            this.Name = "FileWorkMain";
            this.Text = "文件操作";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_FilePath;
        private System.Windows.Forms.Button btn_FolderBrowser;
        public  System.Windows.Forms.ListView lvw_FileList;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FileDate;
        private System.Windows.Forms.ColumnHeader FileType;
        private System.Windows.Forms.Button btn_GoTo;
        private System.Windows.Forms.TextBox tb_SearchFile;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_OpenFile;
    }
}

