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
            this.lbl_Time = new System.Windows.Forms.Label();
            this.tb_FileContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Location = new System.Drawing.Point(125, 70);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(55, 15);
            this.lbl_Time.TabIndex = 0;
            this.lbl_Time.Text = "label1";
            // 
            // tb_FileContent
            // 
            this.tb_FileContent.Location = new System.Drawing.Point(128, 131);
            this.tb_FileContent.Multiline = true;
            this.tb_FileContent.Name = "tb_FileContent";
            this.tb_FileContent.Size = new System.Drawing.Size(498, 235);
            this.tb_FileContent.TabIndex = 1;
            // 
            // FileInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_FileContent);
            this.Controls.Add(this.lbl_Time);
            this.Name = "FileInfo";
            this.Text = "文件详情";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.TextBox tb_FileContent;
    }
}