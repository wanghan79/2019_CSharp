namespace SearchFileApplication
{
    partial class SearchFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchFile));
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.ChooseButton1 = new CCWin.SkinControl.SkinButton();
            this.OpenButton1 = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox1 = new CCWin.SkinControl.SkinComboBox();
            this.ClearButton1 = new CCWin.SkinControl.SkinButton();
            this.OpenSrcButton1 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // PathTextBox
            // 
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PathTextBox.Location = new System.Drawing.Point(33, 54);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(463, 18);
            this.PathTextBox.TabIndex = 0;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // ListBox
            // 
            this.ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListBox.FormattingEnabled = true;
            this.ListBox.HorizontalScrollbar = true;
            this.ListBox.ItemHeight = 15;
            this.ListBox.Location = new System.Drawing.Point(33, 220);
            this.ListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(463, 270);
            this.ListBox.TabIndex = 4;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(29, 20);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(84, 20);
            this.skinLabel1.TabIndex = 7;
            this.skinLabel1.Text = "自定义路径";
            this.skinLabel1.Click += new System.EventHandler(this.skinLabel1_Click);
            // 
            // ChooseButton1
            // 
            this.ChooseButton1.BackColor = System.Drawing.Color.Transparent;
            this.ChooseButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ChooseButton1.DownBack = null;
            this.ChooseButton1.Location = new System.Drawing.Point(383, 83);
            this.ChooseButton1.MouseBack = null;
            this.ChooseButton1.Name = "ChooseButton1";
            this.ChooseButton1.NormlBack = null;
            this.ChooseButton1.Size = new System.Drawing.Size(113, 37);
            this.ChooseButton1.TabIndex = 9;
            this.ChooseButton1.Text = "选择后缀搜索";
            this.ChooseButton1.UseVisualStyleBackColor = false;
            this.ChooseButton1.Click += new System.EventHandler(this.ChooseButton1_Click);
            // 
            // OpenButton1
            // 
            this.OpenButton1.BackColor = System.Drawing.Color.Transparent;
            this.OpenButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.OpenButton1.DownBack = null;
            this.OpenButton1.Location = new System.Drawing.Point(383, 178);
            this.OpenButton1.MouseBack = null;
            this.OpenButton1.Name = "OpenButton1";
            this.OpenButton1.NormlBack = null;
            this.OpenButton1.Size = new System.Drawing.Size(113, 37);
            this.OpenButton1.TabIndex = 10;
            this.OpenButton1.Text = "打开";
            this.OpenButton1.UseVisualStyleBackColor = false;
            this.OpenButton1.Click += new System.EventHandler(this.OpenButton1_Click);
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(29, 91);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(69, 20);
            this.skinLabel2.TabIndex = 11;
            this.skinLabel2.Text = "后缀选项";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(29, 186);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(69, 20);
            this.skinLabel3.TabIndex = 12;
            this.skinLabel3.Text = "文件列表";
            // 
            // skinComboBox1
            // 
            this.skinComboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.skinComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.skinComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.skinComboBox1.FormattingEnabled = true;
            this.skinComboBox1.ItemHeight = 20;
            this.skinComboBox1.Items.AddRange(new object[] {
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
            this.skinComboBox1.Location = new System.Drawing.Point(33, 126);
            this.skinComboBox1.Name = "skinComboBox1";
            this.skinComboBox1.Size = new System.Drawing.Size(463, 26);
            this.skinComboBox1.TabIndex = 13;
            this.skinComboBox1.WaterText = "";
            this.skinComboBox1.SelectedIndexChanged += new System.EventHandler(this.skinComboBox1_SelectedIndexChanged);
            // 
            // ClearButton1
            // 
            this.ClearButton1.BackColor = System.Drawing.Color.Transparent;
            this.ClearButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ClearButton1.DownBack = null;
            this.ClearButton1.Location = new System.Drawing.Point(383, 12);
            this.ClearButton1.MouseBack = null;
            this.ClearButton1.Name = "ClearButton1";
            this.ClearButton1.NormlBack = null;
            this.ClearButton1.Size = new System.Drawing.Size(113, 37);
            this.ClearButton1.TabIndex = 14;
            this.ClearButton1.Text = "清空路径";
            this.ClearButton1.UseVisualStyleBackColor = false;
            this.ClearButton1.Click += new System.EventHandler(this.ClearButton1_Click);
            // 
            // OpenSrcButton1
            // 
            this.OpenSrcButton1.BackColor = System.Drawing.Color.Transparent;
            this.OpenSrcButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.OpenSrcButton1.DownBack = null;
            this.OpenSrcButton1.Location = new System.Drawing.Point(264, 12);
            this.OpenSrcButton1.MouseBack = null;
            this.OpenSrcButton1.Name = "OpenSrcButton1";
            this.OpenSrcButton1.NormlBack = null;
            this.OpenSrcButton1.Size = new System.Drawing.Size(113, 37);
            this.OpenSrcButton1.TabIndex = 15;
            this.OpenSrcButton1.Text = "资源管理器";
            this.OpenSrcButton1.UseVisualStyleBackColor = false;
            this.OpenSrcButton1.Click += new System.EventHandler(this.OpenSrcButton1_Click);
            // 
            // SearchFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(532, 499);
            this.Controls.Add(this.OpenSrcButton1);
            this.Controls.Add(this.ClearButton1);
            this.Controls.Add(this.skinComboBox1);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.OpenButton1);
            this.Controls.Add(this.ChooseButton1);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.PathTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SearchFile";
            this.Text = "SearchFileWindow";
            this.Load += new System.EventHandler(this.SearchFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.ListBox ListBox;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton ChooseButton1;
        private CCWin.SkinControl.SkinButton OpenButton1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinComboBox skinComboBox1;
        private CCWin.SkinControl.SkinButton ClearButton1;
        private CCWin.SkinControl.SkinButton OpenSrcButton1;
    }
}

