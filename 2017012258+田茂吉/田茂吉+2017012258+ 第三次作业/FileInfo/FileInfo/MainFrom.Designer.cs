namespace FileInfo
{
    partial class MainFrom
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
            this.btOpen = new System.Windows.Forms.Button();
            this.txDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(168, 186);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(102, 55);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // txDir
            // 
            this.txDir.Location = new System.Drawing.Point(12, 32);
            this.txDir.Multiline = true;
            this.txDir.Name = "txDir";
            this.txDir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txDir.Size = new System.Drawing.Size(241, 25);
            this.txDir.TabIndex = 1;
            this.txDir.WordWrap = false;
            this.txDir.TextChanged += new System.EventHandler(this.txDir_TextChanged);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txDir);
            this.Controls.Add(this.btOpen);
            this.Name = "MainFrom";
            this.Text = "MainFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox txDir;
    }
}

