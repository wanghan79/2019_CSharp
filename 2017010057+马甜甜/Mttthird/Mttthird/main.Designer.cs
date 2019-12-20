namespace Mttthird
{
    partial class main
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
            this.btopenflie = new System.Windows.Forms.Button();
            this.btsavefile = new System.Windows.Forms.Button();
            this.txDir = new System.Windows.Forms.TextBox();
            this.txKeyWord = new System.Windows.Forms.TextBox();
            this.labfiles = new System.Windows.Forms.ListBox();
            this.labfilelist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btopenflie
            // 
            this.btopenflie.Location = new System.Drawing.Point(969, 65);
            this.btopenflie.Name = "btopenflie";
            this.btopenflie.Size = new System.Drawing.Size(249, 37);
            this.btopenflie.TabIndex = 0;
            this.btopenflie.Text = "directer to find";
            this.btopenflie.UseVisualStyleBackColor = true;
            this.btopenflie.Click += new System.EventHandler(this.btopenflie_Click);
            // 
            // btsavefile
            // 
            this.btsavefile.Location = new System.Drawing.Point(969, 141);
            this.btsavefile.Name = "btsavefile";
            this.btsavefile.Size = new System.Drawing.Size(249, 34);
            this.btsavefile.TabIndex = 1;
            this.btsavefile.Text = "Screen file using";
            this.btsavefile.UseVisualStyleBackColor = true;
            this.btsavefile.Click += new System.EventHandler(this.btsavefile_Click);
            // 
            // txDir
            // 
            this.txDir.Location = new System.Drawing.Point(12, 65);
            this.txDir.Multiline = true;
            this.txDir.Name = "txDir";
            this.txDir.Size = new System.Drawing.Size(930, 37);
            this.txDir.TabIndex = 2;
            // 
            // txKeyWord
            // 
            this.txKeyWord.Location = new System.Drawing.Point(12, 141);
            this.txKeyWord.Multiline = true;
            this.txKeyWord.Name = "txKeyWord";
            this.txKeyWord.Size = new System.Drawing.Size(930, 34);
            this.txKeyWord.TabIndex = 3;
            // 
            // labfiles
            // 
            this.labfiles.FormattingEnabled = true;
            this.labfiles.ItemHeight = 18;
            this.labfiles.Location = new System.Drawing.Point(12, 273);
            this.labfiles.Name = "labfiles";
            this.labfiles.Size = new System.Drawing.Size(1206, 454);
            this.labfiles.TabIndex = 4;
            this.labfiles.SelectedIndexChanged += new System.EventHandler(this.labfiles_SelectedIndexChanged);
            // 
            // labfilelist
            // 
            this.labfilelist.AutoSize = true;
            this.labfilelist.Location = new System.Drawing.Point(56, 234);
            this.labfilelist.Name = "labfilelist";
            this.labfilelist.Size = new System.Drawing.Size(332, 18);
            this.labfilelist.TabIndex = 5;
            this.labfilelist.Text = "The Following Files Are Searched Out";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 681);
            this.Controls.Add(this.labfilelist);
            this.Controls.Add(this.labfiles);
            this.Controls.Add(this.txKeyWord);
            this.Controls.Add(this.txDir);
            this.Controls.Add(this.btsavefile);
            this.Controls.Add(this.btopenflie);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btopenflie;
        private System.Windows.Forms.Button btsavefile;
        private System.Windows.Forms.TextBox txDir;
        private System.Windows.Forms.TextBox txKeyWord;
        private System.Windows.Forms.ListBox labfiles;
        private System.Windows.Forms.Label labfilelist;
    }
}

