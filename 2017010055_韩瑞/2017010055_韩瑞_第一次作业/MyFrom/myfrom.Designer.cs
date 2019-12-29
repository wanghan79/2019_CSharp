namespace MyFrom
{
    partial class myform
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
            this.open_click = new System.Windows.Forms.Button();
            this.save_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // open_click
            // 
            this.open_click.Location = new System.Drawing.Point(37, 12);
            this.open_click.Name = "open_click";
            this.open_click.Size = new System.Drawing.Size(75, 23);
            this.open_click.TabIndex = 0;
            this.open_click.Text = "open_click";
            this.open_click.UseVisualStyleBackColor = true;
            this.open_click.Click += new System.EventHandler(this.open_click_Click);
            // 
            // save_click
            // 
            this.save_click.Location = new System.Drawing.Point(47, 79);
            this.save_click.Name = "save_click";
            this.save_click.Size = new System.Drawing.Size(75, 23);
            this.save_click.TabIndex = 1;
            this.save_click.Text = "save_click";
            this.save_click.UseVisualStyleBackColor = true;
            this.save_click.Click += new System.EventHandler(this.save_click_Click);
            // 
            // myform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.save_click);
            this.Controls.Add(this.open_click);
            this.Name = "myform";
            this.Text = "myform";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_click;
        private System.Windows.Forms.Button save_click;
    }
}

