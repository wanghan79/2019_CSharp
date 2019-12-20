namespace fileList
{
    partial class mainForm
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
            this.lab_pickPath = new System.Windows.Forms.Label();
            this.cbb_pickFormat = new System.Windows.Forms.ComboBox();
            this.lab_formatLabel = new System.Windows.Forms.Label();
            this.lsb_fileList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lab_pickPath
            // 
            this.lab_pickPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_pickPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_pickPath.Location = new System.Drawing.Point(90, 35);
            this.lab_pickPath.Name = "lab_pickPath";
            this.lab_pickPath.Size = new System.Drawing.Size(627, 23);
            this.lab_pickPath.TabIndex = 0;
            this.lab_pickPath.Text = "请选择文件路径";
            this.lab_pickPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_pickPath.Click += new System.EventHandler(this.lab_pickPath_Click);
            // 
            // cbb_pickFormat
            // 
            this.cbb_pickFormat.AllowDrop = true;
            this.cbb_pickFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbb_pickFormat.FormattingEnabled = true;
            this.cbb_pickFormat.Location = new System.Drawing.Point(147, 63);
            this.cbb_pickFormat.Name = "cbb_pickFormat";
            this.cbb_pickFormat.Size = new System.Drawing.Size(147, 20);
            this.cbb_pickFormat.TabIndex = 1;
            this.cbb_pickFormat.SelectedIndexChanged += new System.EventHandler(this.cbb_pickFormat_SelectedIndexChanged);
            // 
            // lab_formatLabel
            // 
            this.lab_formatLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_formatLabel.AutoSize = true;
            this.lab_formatLabel.Location = new System.Drawing.Point(88, 66);
            this.lab_formatLabel.Name = "lab_formatLabel";
            this.lab_formatLabel.Size = new System.Drawing.Size(53, 12);
            this.lab_formatLabel.TabIndex = 3;
            this.lab_formatLabel.Text = "文件格式";
            // 
            // lsb_fileList
            // 
            this.lsb_fileList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lsb_fileList.FormattingEnabled = true;
            this.lsb_fileList.ItemHeight = 12;
            this.lsb_fileList.Items.AddRange(new object[] {
            "单击列表中的文件以打开。"});
            this.lsb_fileList.Location = new System.Drawing.Point(90, 88);
            this.lsb_fileList.Name = "lsb_fileList";
            this.lsb_fileList.Size = new System.Drawing.Size(627, 316);
            this.lsb_fileList.TabIndex = 4;
            this.lsb_fileList.SelectedIndexChanged += new System.EventHandler(this.lsb_fileList_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsb_fileList);
            this.Controls.Add(this.lab_formatLabel);
            this.Controls.Add(this.cbb_pickFormat);
            this.Controls.Add(this.lab_pickPath);
            this.Name = "mainForm";
            this.Text = "2017011827胡顺航";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.Label lab_pickPath;
        public  System.Windows.Forms.ComboBox cbb_pickFormat;
        public  System.Windows.Forms.Label lab_formatLabel;
        public  System.Windows.Forms.ListBox lsb_fileList;
    }
}

