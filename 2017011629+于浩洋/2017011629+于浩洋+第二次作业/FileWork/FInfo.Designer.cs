namespace FileWork
{
    partial class FileInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Time = new System.Windows.Forms.Label();
            this.FileContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Location = new System.Drawing.Point(125, 70);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(55, 15);
            this.lb_Time.TabIndex = 0;
            this.lb_Time.Text = "label1";
            // 
            // FileContent
            // 
            this.FileContent.Location = new System.Drawing.Point(128, 131);
            this.FileContent.Multiline = true;
            this.FileContent.Name = "FileContent";
            this.FileContent.Size = new System.Drawing.Size(498, 235);
            this.FileContent.TabIndex = 1;
            // 
            // FileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FileContent);
            this.Controls.Add(this.lb_Time);
            this.Name = "FileInfo";
            this.Text = "文件详情";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.TextBox FileContent;
    }
}