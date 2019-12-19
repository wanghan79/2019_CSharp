namespace 多线程list文件夹下的文件
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
            this.components = new System.ComponentModel.Container();
            this.txbFilePath = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lsbFile = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.txChoseFile = new System.Windows.Forms.TextBox();
            this.btChose = new System.Windows.Forms.Button();
            this.btOpenFile = new System.Windows.Forms.Button();
            this.ProcessBarTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txbFilePath
            // 
            this.txbFilePath.Location = new System.Drawing.Point(39, 38);
            this.txbFilePath.Name = "txbFilePath";
            this.txbFilePath.Size = new System.Drawing.Size(357, 28);
            this.txbFilePath.TabIndex = 0;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(420, 32);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(150, 36);
            this.btSearch.TabIndex = 1;
            this.btSearch.Text = "Dir to Find";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lsbFile
            // 
            this.lsbFile.FormattingEnabled = true;
            this.lsbFile.ItemHeight = 18;
            this.lsbFile.Location = new System.Drawing.Point(39, 169);
            this.lsbFile.Name = "lsbFile";
            this.lsbFile.Size = new System.Drawing.Size(531, 256);
            this.lsbFile.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "The Following Files are Searched out";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 134);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(579, 11);
            this.progressBar.TabIndex = 4;
            // 
            // txChoseFile
            // 
            this.txChoseFile.Location = new System.Drawing.Point(39, 91);
            this.txChoseFile.Name = "txChoseFile";
            this.txChoseFile.Size = new System.Drawing.Size(357, 28);
            this.txChoseFile.TabIndex = 5;
            // 
            // btChose
            // 
            this.btChose.Location = new System.Drawing.Point(420, 82);
            this.btChose.Name = "btChose";
            this.btChose.Size = new System.Drawing.Size(150, 37);
            this.btChose.TabIndex = 6;
            this.btChose.Text = "Chose";
            this.btChose.UseVisualStyleBackColor = true;
            this.btChose.Click += new System.EventHandler(this.btChose_Click_1);
            // 
            // btOpenFile
            // 
            this.btOpenFile.Location = new System.Drawing.Point(479, 440);
            this.btOpenFile.Name = "btOpenFile";
            this.btOpenFile.Size = new System.Drawing.Size(113, 46);
            this.btOpenFile.TabIndex = 7;
            this.btOpenFile.Text = "Open File";
            this.btOpenFile.UseVisualStyleBackColor = true;
            this.btOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // ProcessBarTimer
            // 
            this.ProcessBarTimer.Interval = 3;
            this.ProcessBarTimer.Tick += new System.EventHandler(this.ProcessBarTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 509);
            this.Controls.Add(this.btOpenFile);
            this.Controls.Add(this.btChose);
            this.Controls.Add(this.txChoseFile);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbFile);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.txbFilePath);
            this.Name = "MainForm";
            this.Text = "多线程list文件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbFilePath;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.ListBox lsbFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TextBox txChoseFile;
        private System.Windows.Forms.Button btChose;
        private System.Windows.Forms.Button btOpenFile;
        private System.Windows.Forms.Timer ProcessBarTimer;
    }
}

