namespace parctise
{
    partial class ouyyn
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
            this.btn_buttonTransform = new System.Windows.Forms.Button();
            this.lst_showSpecifyFiles = new System.Windows.Forms.ListBox();
            this.txt_filesName = new System.Windows.Forms.TextBox();
            this.btn_showOneFile = new System.Windows.Forms.Button();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_buttonTransform
            // 
            this.btn_buttonTransform.Location = new System.Drawing.Point(436, 23);
            this.btn_buttonTransform.Name = "btn_buttonTransform";
            this.btn_buttonTransform.Size = new System.Drawing.Size(114, 23);
            this.btn_buttonTransform.TabIndex = 1;
            this.btn_buttonTransform.Text = "展现指定文件夹";
            this.btn_buttonTransform.UseVisualStyleBackColor = true;
            this.btn_buttonTransform.Click += new System.EventHandler(this.Btn_buttonTransform_Click);
            // 
            // lst_showSpecifyFiles
            // 
            this.lst_showSpecifyFiles.FormattingEnabled = true;
            this.lst_showSpecifyFiles.ItemHeight = 12;
            this.lst_showSpecifyFiles.Location = new System.Drawing.Point(12, 161);
            this.lst_showSpecifyFiles.Name = "lst_showSpecifyFiles";
            this.lst_showSpecifyFiles.Size = new System.Drawing.Size(376, 124);
            this.lst_showSpecifyFiles.TabIndex = 2;
            this.lst_showSpecifyFiles.SelectedIndexChanged += new System.EventHandler(this.lst_showSpecifyFiles_SelectedIndexChanged);
            this.lst_showSpecifyFiles.DoubleClick += new System.EventHandler(this.lst_showSpecifyFiles_DoubleClick);
            // 
            // txt_filesName
            // 
            this.txt_filesName.Location = new System.Drawing.Point(12, 23);
            this.txt_filesName.Name = "txt_filesName";
            this.txt_filesName.Size = new System.Drawing.Size(376, 21);
            this.txt_filesName.TabIndex = 3;
            this.txt_filesName.TextChanged += new System.EventHandler(this.txt_filesName_TextChanged);
            // 
            // btn_showOneFile
            // 
            this.btn_showOneFile.Location = new System.Drawing.Point(436, 91);
            this.btn_showOneFile.Name = "btn_showOneFile";
            this.btn_showOneFile.Size = new System.Drawing.Size(114, 23);
            this.btn_showOneFile.TabIndex = 4;
            this.btn_showOneFile.Text = "指定一个文件后缀";
            this.btn_showOneFile.UseVisualStyleBackColor = true;
            this.btn_showOneFile.Click += new System.EventHandler(this.Btn_showOneFile_Click);
            // 
            // txt_fileName
            // 
            this.txt_fileName.Location = new System.Drawing.Point(12, 93);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.Size = new System.Drawing.Size(376, 21);
            this.txt_fileName.TabIndex = 5;
            // 
            // ouyyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_fileName);
            this.Controls.Add(this.btn_showOneFile);
            this.Controls.Add(this.txt_filesName);
            this.Controls.Add(this.lst_showSpecifyFiles);
            this.Controls.Add(this.btn_buttonTransform);
            this.Name = "ouyyn";
            this.Text = "ouyyn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_buttonTransform;
        private System.Windows.Forms.ListBox lst_showSpecifyFiles;
        private System.Windows.Forms.TextBox txt_filesName;
        private System.Windows.Forms.Button btn_showOneFile;
        private System.Windows.Forms.TextBox txt_fileName;
    }
}

