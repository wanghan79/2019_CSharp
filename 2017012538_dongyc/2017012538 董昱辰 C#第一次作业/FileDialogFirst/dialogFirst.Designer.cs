namespace FileDialogFirst
{
    partial class dialogFirst
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.打开文件 = new System.Windows.Forms.Button();
            this.存储文件 = new System.Windows.Forms.Button();
            this.textenter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // 打开文件
            // 
            this.打开文件.Location = new System.Drawing.Point(80, 65);
            this.打开文件.Name = "打开文件";
            this.打开文件.Size = new System.Drawing.Size(150, 52);
            this.打开文件.TabIndex = 0;
            this.打开文件.Text = "打开文件";
            this.打开文件.UseVisualStyleBackColor = true;
            this.打开文件.Click += new System.EventHandler(this.打开文件_Click);
            // 
            // 存储文件
            // 
            this.存储文件.Location = new System.Drawing.Point(396, 65);
            this.存储文件.Name = "存储文件";
            this.存储文件.Size = new System.Drawing.Size(135, 52);
            this.存储文件.TabIndex = 1;
            this.存储文件.Text = "存储文件";
            this.存储文件.UseVisualStyleBackColor = true;
            this.存储文件.Click += new System.EventHandler(this.存储文件_Click);
            // 
            // textenter
            // 
            this.textenter.Location = new System.Drawing.Point(80, 143);
            this.textenter.Multiline = true;
            this.textenter.Name = "textenter";
            this.textenter.Size = new System.Drawing.Size(460, 233);
            this.textenter.TabIndex = 2;
            this.textenter.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // dialogFirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.textenter);
            this.Controls.Add(this.存储文件);
            this.Controls.Add(this.打开文件);
            this.Name = "dialogFirst";
            this.Text = "DLFirst";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button 打开文件;
        private System.Windows.Forms.Button 存储文件;
        private System.Windows.Forms.TextBox textenter;
    }
}

