namespace MttSecond2
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
            this.Content = new System.Windows.Forms.TextBox();
            this.time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(719, 91);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(120, 57);
            this.file.TabIndex = 0;
            this.file.Text = "file";
            this.file.UseVisualStyleBackColor = true;
            this.file.Click += new System.EventHandler(this.file_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(12, 91);
            this.path.Multiline = true;
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(593, 57);
            this.path.TabIndex = 1;
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(12, 196);
            this.Content.Multiline = true;
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(827, 378);
            this.Content.TabIndex = 2;
            // 
            // time
            // 
            this.time.Location = new System.Drawing.Point(483, 624);
            this.time.Multiline = true;
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(356, 35);
            this.time.TabIndex = 3;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 681);
            this.Controls.Add(this.time);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.path);
            this.Controls.Add(this.file);
            this.Name = "main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button file;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.TextBox time;
    }
}

