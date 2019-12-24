namespace SearchFileApplication_V1
{
    partial class SearchFileApplication_V1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFileApplication_V1));
            this.PathLabel1 = new CCWin.SkinControl.SkinLabel();
            this.PathTextBox1 = new CCWin.SkinControl.SkinWaterTextBox();
            this.SearchButton1 = new CCWin.SkinControl.SkinButton();
            this.ChoseLabel1 = new CCWin.SkinControl.SkinLabel();
            this.FileTypeComboBox1 = new CCWin.SkinControl.SkinComboBox();
            this.ChoseButton1 = new CCWin.SkinControl.SkinButton();
            this.FileListLabel1 = new CCWin.SkinControl.SkinLabel();
            this.OpenButton1 = new CCWin.SkinControl.SkinButton();
            this.FileDetailTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.FilelistBox1 = new System.Windows.Forms.ListBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.FileSizeLabel2 = new CCWin.SkinControl.SkinLabel();
            this.FileSizeTextBox1 = new CCWin.SkinControl.SkinWaterTextBox();
            this.LastVisTimeLabel4 = new CCWin.SkinControl.SkinLabel();
            this.CurrVisTextBox3 = new CCWin.SkinControl.SkinWaterTextBox();
            this.ClearPathButton1 = new CCWin.SkinControl.SkinButton();
            this.ClearFileButton1 = new CCWin.SkinControl.SkinButton();
            this.SaveButton2 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // PathLabel1
            // 
            this.PathLabel1.AutoSize = true;
            this.PathLabel1.BackColor = System.Drawing.Color.Transparent;
            this.PathLabel1.BorderColor = System.Drawing.Color.White;
            this.PathLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PathLabel1.Location = new System.Drawing.Point(36, 35);
            this.PathLabel1.Name = "PathLabel1";
            this.PathLabel1.Size = new System.Drawing.Size(84, 20);
            this.PathLabel1.TabIndex = 0;
            this.PathLabel1.Text = "自定义路径";
            this.PathLabel1.Click += new System.EventHandler(this.PathLabel1_Click);
            // 
            // PathTextBox1
            // 
            this.PathTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PathTextBox1.Location = new System.Drawing.Point(40, 61);
            this.PathTextBox1.Name = "PathTextBox1";
            this.PathTextBox1.Size = new System.Drawing.Size(521, 18);
            this.PathTextBox1.TabIndex = 1;
            this.PathTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.PathTextBox1.WaterText = "";
            this.PathTextBox1.TextChanged += new System.EventHandler(this.PathTextBox1_TextChanged);
            // 
            // SearchButton1
            // 
            this.SearchButton1.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.SearchButton1.DownBack = null;
            this.SearchButton1.Location = new System.Drawing.Point(375, 21);
            this.SearchButton1.MouseBack = null;
            this.SearchButton1.Name = "SearchButton1";
            this.SearchButton1.NormlBack = null;
            this.SearchButton1.Size = new System.Drawing.Size(91, 34);
            this.SearchButton1.TabIndex = 2;
            this.SearchButton1.Text = "搜索";
            this.SearchButton1.UseVisualStyleBackColor = false;
            this.SearchButton1.Click += new System.EventHandler(this.SearchButton1_Click);
            // 
            // ChoseLabel1
            // 
            this.ChoseLabel1.AutoSize = true;
            this.ChoseLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ChoseLabel1.BorderColor = System.Drawing.Color.White;
            this.ChoseLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ChoseLabel1.Location = new System.Drawing.Point(37, 102);
            this.ChoseLabel1.Name = "ChoseLabel1";
            this.ChoseLabel1.Size = new System.Drawing.Size(69, 20);
            this.ChoseLabel1.TabIndex = 3;
            this.ChoseLabel1.Text = "后缀选项";
            this.ChoseLabel1.Click += new System.EventHandler(this.ChoseLabel1_Click);
            // 
            // FileTypeComboBox1
            // 
            this.FileTypeComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FileTypeComboBox1.FormattingEnabled = true;
            this.FileTypeComboBox1.Items.AddRange(new object[] {
            "adt  ",
            "arj   ",
            "avi      ",
            "bat  ",
            "bmp    ",
            "com",
            "dll",
            "doc",
            "exe",
            "gif",
            "html",
            "int",
            "jpeg",
            "jpg",
            "mov   ",
            "mp3",
            "mpg",
            "pdf",
            "png",
            "ppt",
            "rar",
            "txt",
            "zip"});
            this.FileTypeComboBox1.Location = new System.Drawing.Point(40, 135);
            this.FileTypeComboBox1.Name = "FileTypeComboBox1";
            this.FileTypeComboBox1.Size = new System.Drawing.Size(521, 26);
            this.FileTypeComboBox1.TabIndex = 4;
            this.FileTypeComboBox1.WaterText = "";
            this.FileTypeComboBox1.SelectedIndexChanged += new System.EventHandler(this.FileTypeComboBox1_SelectedIndexChanged);
            // 
            // ChoseButton1
            // 
            this.ChoseButton1.BackColor = System.Drawing.Color.Transparent;
            this.ChoseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ChoseButton1.DownBack = null;
            this.ChoseButton1.Location = new System.Drawing.Point(470, 95);
            this.ChoseButton1.MouseBack = null;
            this.ChoseButton1.Name = "ChoseButton1";
            this.ChoseButton1.NormlBack = null;
            this.ChoseButton1.Size = new System.Drawing.Size(91, 34);
            this.ChoseButton1.TabIndex = 5;
            this.ChoseButton1.Text = "后缀搜索";
            this.ChoseButton1.UseVisualStyleBackColor = false;
            this.ChoseButton1.Click += new System.EventHandler(this.ChoseButton1_Click);
            // 
            // FileListLabel1
            // 
            this.FileListLabel1.AutoSize = true;
            this.FileListLabel1.BackColor = System.Drawing.Color.Transparent;
            this.FileListLabel1.BorderColor = System.Drawing.Color.White;
            this.FileListLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileListLabel1.Location = new System.Drawing.Point(36, 173);
            this.FileListLabel1.Name = "FileListLabel1";
            this.FileListLabel1.Size = new System.Drawing.Size(69, 20);
            this.FileListLabel1.TabIndex = 6;
            this.FileListLabel1.Text = "文件列表";
            this.FileListLabel1.Click += new System.EventHandler(this.FileListLabel1_Click);
            // 
            // OpenButton1
            // 
            this.OpenButton1.BackColor = System.Drawing.Color.Transparent;
            this.OpenButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.OpenButton1.DownBack = null;
            this.OpenButton1.Location = new System.Drawing.Point(278, 375);
            this.OpenButton1.MouseBack = null;
            this.OpenButton1.Name = "OpenButton1";
            this.OpenButton1.NormlBack = null;
            this.OpenButton1.Size = new System.Drawing.Size(91, 34);
            this.OpenButton1.TabIndex = 8;
            this.OpenButton1.Text = "打开";
            this.OpenButton1.UseVisualStyleBackColor = false;
            this.OpenButton1.Click += new System.EventHandler(this.OpenButton1_Click);
            // 
            // FileDetailTextBox1
            // 
            this.FileDetailTextBox1.AutoScroll = true;
            this.FileDetailTextBox1.BackColor = System.Drawing.Color.White;
            this.FileDetailTextBox1.DownBack = null;
            this.FileDetailTextBox1.Icon = null;
            this.FileDetailTextBox1.IconIsButton = false;
            this.FileDetailTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.FileDetailTextBox1.IsPasswordChat = '\0';
            this.FileDetailTextBox1.IsSystemPasswordChar = false;
            this.FileDetailTextBox1.Lines = new string[] {
        "文件详情"};
            this.FileDetailTextBox1.Location = new System.Drawing.Point(41, 412);
            this.FileDetailTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.FileDetailTextBox1.MaxLength = 32767;
            this.FileDetailTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.FileDetailTextBox1.MouseBack = null;
            this.FileDetailTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.FileDetailTextBox1.Multiline = true;
            this.FileDetailTextBox1.Name = "FileDetailTextBox1";
            this.FileDetailTextBox1.NormlBack = null;
            this.FileDetailTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.FileDetailTextBox1.ReadOnly = false;
            this.FileDetailTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FileDetailTextBox1.Size = new System.Drawing.Size(520, 211);
            // 
            // 
            // 
            this.FileDetailTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileDetailTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileDetailTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.FileDetailTextBox1.SkinTxt.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FileDetailTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.FileDetailTextBox1.SkinTxt.Multiline = true;
            this.FileDetailTextBox1.SkinTxt.Name = "BaseText";
            this.FileDetailTextBox1.SkinTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.FileDetailTextBox1.SkinTxt.Size = new System.Drawing.Size(510, 201);
            this.FileDetailTextBox1.SkinTxt.TabIndex = 0;
            this.FileDetailTextBox1.SkinTxt.Text = "文件详情";
            this.FileDetailTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.FileDetailTextBox1.SkinTxt.WaterText = "";
            this.FileDetailTextBox1.TabIndex = 10;
            this.FileDetailTextBox1.Text = "文件详情";
            this.FileDetailTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FileDetailTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.FileDetailTextBox1.WaterText = "";
            this.FileDetailTextBox1.WordWrap = true;
            this.FileDetailTextBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.FileDetailTextBox1_Paint);
            // 
            // FilelistBox1
            // 
            this.FilelistBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilelistBox1.FormattingEnabled = true;
            this.FilelistBox1.HorizontalScrollbar = true;
            this.FilelistBox1.ItemHeight = 15;
            this.FilelistBox1.Location = new System.Drawing.Point(40, 197);
            this.FilelistBox1.Name = "FilelistBox1";
            this.FilelistBox1.Size = new System.Drawing.Size(521, 165);
            this.FilelistBox1.TabIndex = 11;
            this.FilelistBox1.SelectedIndexChanged += new System.EventHandler(this.FilelistBox1_SelectedIndexChanged);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(37, 382);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(69, 20);
            this.skinLabel1.TabIndex = 12;
            this.skinLabel1.Text = "文件详情";
            this.skinLabel1.Click += new System.EventHandler(this.skinLabel1_Click);
            // 
            // FileSizeLabel2
            // 
            this.FileSizeLabel2.AutoSize = true;
            this.FileSizeLabel2.BackColor = System.Drawing.Color.Transparent;
            this.FileSizeLabel2.BorderColor = System.Drawing.Color.White;
            this.FileSizeLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileSizeLabel2.Location = new System.Drawing.Point(37, 631);
            this.FileSizeLabel2.Name = "FileSizeLabel2";
            this.FileSizeLabel2.Size = new System.Drawing.Size(69, 20);
            this.FileSizeLabel2.TabIndex = 13;
            this.FileSizeLabel2.Text = "文件大小";
            // 
            // FileSizeTextBox1
            // 
            this.FileSizeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileSizeTextBox1.Location = new System.Drawing.Point(112, 633);
            this.FileSizeTextBox1.Name = "FileSizeTextBox1";
            this.FileSizeTextBox1.Size = new System.Drawing.Size(154, 18);
            this.FileSizeTextBox1.TabIndex = 14;
            this.FileSizeTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.FileSizeTextBox1.WaterText = "";
            this.FileSizeTextBox1.TextChanged += new System.EventHandler(this.FileSizeTextBox1_TextChanged);
            // 
            // LastVisTimeLabel4
            // 
            this.LastVisTimeLabel4.AutoSize = true;
            this.LastVisTimeLabel4.BackColor = System.Drawing.Color.Transparent;
            this.LastVisTimeLabel4.BorderColor = System.Drawing.Color.White;
            this.LastVisTimeLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LastVisTimeLabel4.Location = new System.Drawing.Point(288, 631);
            this.LastVisTimeLabel4.Name = "LastVisTimeLabel4";
            this.LastVisTimeLabel4.Size = new System.Drawing.Size(99, 20);
            this.LastVisTimeLabel4.TabIndex = 17;
            this.LastVisTimeLabel4.Text = "当前访问时间";
            // 
            // CurrVisTextBox3
            // 
            this.CurrVisTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.CurrVisTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CurrVisTextBox3.Location = new System.Drawing.Point(398, 633);
            this.CurrVisTextBox3.Name = "CurrVisTextBox3";
            this.CurrVisTextBox3.Size = new System.Drawing.Size(163, 18);
            this.CurrVisTextBox3.TabIndex = 20;
            this.CurrVisTextBox3.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.CurrVisTextBox3.WaterText = "";
            this.CurrVisTextBox3.TextChanged += new System.EventHandler(this.CurrVisTextBox3_TextChanged);
            // 
            // ClearPathButton1
            // 
            this.ClearPathButton1.BackColor = System.Drawing.Color.Transparent;
            this.ClearPathButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ClearPathButton1.DownBack = null;
            this.ClearPathButton1.Location = new System.Drawing.Point(470, 21);
            this.ClearPathButton1.MouseBack = null;
            this.ClearPathButton1.Name = "ClearPathButton1";
            this.ClearPathButton1.NormlBack = null;
            this.ClearPathButton1.Size = new System.Drawing.Size(91, 34);
            this.ClearPathButton1.TabIndex = 21;
            this.ClearPathButton1.Text = "清空路径";
            this.ClearPathButton1.UseVisualStyleBackColor = false;
            this.ClearPathButton1.Click += new System.EventHandler(this.ClearPathButton1_Click);
            // 
            // ClearFileButton1
            // 
            this.ClearFileButton1.BackColor = System.Drawing.Color.Transparent;
            this.ClearFileButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ClearFileButton1.DownBack = null;
            this.ClearFileButton1.Location = new System.Drawing.Point(375, 375);
            this.ClearFileButton1.MouseBack = null;
            this.ClearFileButton1.Name = "ClearFileButton1";
            this.ClearFileButton1.NormlBack = null;
            this.ClearFileButton1.Size = new System.Drawing.Size(91, 34);
            this.ClearFileButton1.TabIndex = 22;
            this.ClearFileButton1.Text = "清空";
            this.ClearFileButton1.UseVisualStyleBackColor = false;
            this.ClearFileButton1.Click += new System.EventHandler(this.ClearFileButton1_Click);
            // 
            // SaveButton2
            // 
            this.SaveButton2.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.SaveButton2.DownBack = null;
            this.SaveButton2.Location = new System.Drawing.Point(470, 375);
            this.SaveButton2.MouseBack = null;
            this.SaveButton2.Name = "SaveButton2";
            this.SaveButton2.NormlBack = null;
            this.SaveButton2.Size = new System.Drawing.Size(91, 34);
            this.SaveButton2.TabIndex = 23;
            this.SaveButton2.Text = "保存";
            this.SaveButton2.UseVisualStyleBackColor = false;
            this.SaveButton2.Click += new System.EventHandler(this.SaveButton2_Click);
            // 
            // SearchFileApplication_V1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(604, 677);
            this.Controls.Add(this.SaveButton2);
            this.Controls.Add(this.ClearFileButton1);
            this.Controls.Add(this.ClearPathButton1);
            this.Controls.Add(this.CurrVisTextBox3);
            this.Controls.Add(this.LastVisTimeLabel4);
            this.Controls.Add(this.FileSizeTextBox1);
            this.Controls.Add(this.FileSizeLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.FilelistBox1);
            this.Controls.Add(this.FileDetailTextBox1);
            this.Controls.Add(this.OpenButton1);
            this.Controls.Add(this.FileListLabel1);
            this.Controls.Add(this.ChoseButton1);
            this.Controls.Add(this.FileTypeComboBox1);
            this.Controls.Add(this.ChoseLabel1);
            this.Controls.Add(this.SearchButton1);
            this.Controls.Add(this.PathTextBox1);
            this.Controls.Add(this.PathLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchFileApplication_V1";
            this.Text = "SearchFileWindow";
            this.Load += new System.EventHandler(this.SearchFileApplication_V1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel PathLabel1;
        private CCWin.SkinControl.SkinWaterTextBox PathTextBox1;
        private CCWin.SkinControl.SkinButton SearchButton1;
        private CCWin.SkinControl.SkinLabel ChoseLabel1;
        private CCWin.SkinControl.SkinComboBox FileTypeComboBox1;
        private CCWin.SkinControl.SkinButton ChoseButton1;
        private CCWin.SkinControl.SkinLabel FileListLabel1;
        private CCWin.SkinControl.SkinButton OpenButton1;
        private CCWin.SkinControl.SkinTextBox FileDetailTextBox1;
        private System.Windows.Forms.ListBox FilelistBox1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel FileSizeLabel2;
        private CCWin.SkinControl.SkinWaterTextBox FileSizeTextBox1;
        private CCWin.SkinControl.SkinLabel LastVisTimeLabel4;
        private CCWin.SkinControl.SkinWaterTextBox CurrVisTextBox3;
        private CCWin.SkinControl.SkinButton ClearPathButton1;
        private CCWin.SkinControl.SkinButton ClearFileButton1;
        private CCWin.SkinControl.SkinButton SaveButton2;

    }
}

