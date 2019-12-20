namespace MttFirst
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
            this.file = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.show = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(602, 39);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(217, 75);
            this.file.TabIndex = 0;
            this.file.Text = "file";
            this.file.UseVisualStyleBackColor = true;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(8, 39);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(576, 74);
            this.path.TabIndex = 1;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(8, 171);
            this.show.Multiline = true;
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(811, 368);
            this.show.TabIndex = 2;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 577);
            this.Controls.Add(this.show);
            this.Controls.Add(this.path);
            this.Controls.Add(this.file);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button file;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox show;
    }
}

