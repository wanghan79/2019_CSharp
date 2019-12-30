//using System.Drawing;
namespace FileManagement
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
            this.tboxFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labSearch = new System.Windows.Forms.Label();
            this.listVwFilelist = new System.Windows.Forms.ListView();
            this.labFilePath = new System.Windows.Forms.Label();
            this.comboxFileAtt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tboxFilePath
            // 
            this.tboxFilePath.ForeColor = System.Drawing.Color.Gray;
            this.tboxFilePath.Location = new System.Drawing.Point(85, 11);
            this.tboxFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxFilePath.Name = "tboxFilePath";
            this.tboxFilePath.Size = new System.Drawing.Size(1092, 25);
            this.tboxFilePath.TabIndex = 0;
            this.tboxFilePath.Text = " 请输入路径";
            this.tboxFilePath.Enter += new System.EventHandler(this.tboxFilePath_Enter);
            this.tboxFilePath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxFilePath_KeyDown);
            this.tboxFilePath.Leave += new System.EventHandler(this.tboxFilePath_Leave);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(1212, 11);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(101, 26);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "文件路径";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // tboxSearch
            // 
            this.tboxSearch.ForeColor = System.Drawing.Color.Gray;
            this.tboxSearch.Location = new System.Drawing.Point(85, 56);
            this.tboxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(941, 25);
            this.tboxSearch.TabIndex = 2;
            this.tboxSearch.Text = " 请输入搜索关键字";
            this.tboxSearch.Enter += new System.EventHandler(this.tboxSearch_Enter);
            this.tboxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxSearch_KeyDown);
            this.tboxSearch.Leave += new System.EventHandler(this.tboxFilePath_Leave);
            // 
            // FileName
            // 
            this.FileName.Text = "文件名称";
            this.FileName.Width = 200;
            // 
            // FileDate
            // 
            this.FileDate.Text = "修改日期";
            this.FileDate.Width = 150;
            // 
            // FileType
            // 
            this.FileType.Text = "文件类型";
            this.FileType.Width = 155;
            // 
            // FilePath
            // 
            this.FilePath.Text = "文件路径";
            this.FilePath.Width = 480;
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labSearch.Location = new System.Drawing.Point(15, 59);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(52, 15);
            this.labSearch.TabIndex = 8;
            this.labSearch.Text = "查找栏";
            // 
            // listVwFilelist
            // 
            this.listVwFilelist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilePath,
            this.FileType,
            this.FileName,
            this.FileDate});
            this.listVwFilelist.HideSelection = false;
            this.listVwFilelist.Location = new System.Drawing.Point(17, 99);
            this.listVwFilelist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listVwFilelist.Name = "listVwFilelist";
            this.listVwFilelist.Size = new System.Drawing.Size(1312, 653);
            this.listVwFilelist.TabIndex = 3;
            this.listVwFilelist.UseCompatibleStateImageBehavior = false;
            this.listVwFilelist.View = System.Windows.Forms.View.Details;
            this.listVwFilelist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listVwFilelist_MouseDoubleClick);
            // 
            // labFilePath
            // 
            this.labFilePath.AutoSize = true;
            this.labFilePath.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labFilePath.Location = new System.Drawing.Point(15, 16);
            this.labFilePath.Name = "labFilePath";
            this.labFilePath.Size = new System.Drawing.Size(52, 15);
            this.labFilePath.TabIndex = 7;
            this.labFilePath.Text = "地址栏";
            // 
            // comboxFileAtt
            // 
            this.comboxFileAtt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxFileAtt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboxFileAtt.FormatString = "选择文件类型";
            this.comboxFileAtt.FormattingEnabled = true;
            this.comboxFileAtt.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.comboxFileAtt.Items.AddRange(new object[] {
            "所有",
            "音频",
            "文本",
            "可执行文件",
            "图片",
            "视频"});
            this.comboxFileAtt.SelectedIndex = comboxFileAtt.Items.IndexOf("所有");
            this.comboxFileAtt.Location = new System.Drawing.Point(1055, 58);
            this.comboxFileAtt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboxFileAtt.Name = "comboxFileAtt";
            this.comboxFileAtt.Size = new System.Drawing.Size(123, 23);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 818);
            this.Controls.Add(this.listVwFilelist);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.labFilePath);
            this.Controls.Add(this.comboxFileAtt);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.tboxFilePath);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "文件查找筛选软件——C#课程作业（2019/12/09）";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxFilePath;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.ListView listVwFilelist;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FileDate;
        private System.Windows.Forms.ColumnHeader FileType;
        private System.Windows.Forms.ColumnHeader FilePath;
        private System.Windows.Forms.Label labFilePath;
        private System.Windows.Forms.ComboBox comboxFileAtt;

    }
}

