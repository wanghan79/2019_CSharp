namespace Files.lib
{
    partial class Myform
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
            this.richTextBox_show = new System.Windows.Forms.RichTextBox();
            this.lab_fileName = new System.Windows.Forms.Label();
            this.lab_opentime = new System.Windows.Forms.Label();
            this.lab_openfileName = new System.Windows.Forms.Label();
            this.lab_openfile_time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox_show
            // 
            this.richTextBox_show.Location = new System.Drawing.Point(12, 60);
            this.richTextBox_show.Name = "richTextBox_show";
            this.richTextBox_show.Size = new System.Drawing.Size(443, 289);
            this.richTextBox_show.TabIndex = 0;
            this.richTextBox_show.Text = "";
            // 
            // lab_fileName
            // 
            this.lab_fileName.AutoSize = true;
            this.lab_fileName.Location = new System.Drawing.Point(43, 9);
            this.lab_fileName.Name = "lab_fileName";
            this.lab_fileName.Size = new System.Drawing.Size(65, 12);
            this.lab_fileName.TabIndex = 1;
            this.lab_fileName.Text = "文件名称：";
            // 
            // lab_opentime
            // 
            this.lab_opentime.AutoSize = true;
            this.lab_opentime.Location = new System.Drawing.Point(43, 35);
            this.lab_opentime.Name = "lab_opentime";
            this.lab_opentime.Size = new System.Drawing.Size(65, 12);
            this.lab_opentime.TabIndex = 2;
            this.lab_opentime.Text = "打开时间：";
            // 
            // lab_openfileName
            // 
            this.lab_openfileName.AutoSize = true;
            this.lab_openfileName.Location = new System.Drawing.Point(115, 9);
            this.lab_openfileName.Name = "lab_openfileName";
            this.lab_openfileName.Size = new System.Drawing.Size(11, 12);
            this.lab_openfileName.TabIndex = 3;
            this.lab_openfileName.Text = "1";
            // 
            // lab_openfile_time
            // 
            this.lab_openfile_time.AutoSize = true;
            this.lab_openfile_time.Location = new System.Drawing.Point(115, 35);
            this.lab_openfile_time.Name = "lab_openfile_time";
            this.lab_openfile_time.Size = new System.Drawing.Size(11, 12);
            this.lab_openfile_time.TabIndex = 3;
            this.lab_openfile_time.Text = "1";
            // 
            // Myform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 361);
            this.Controls.Add(this.lab_openfile_time);
            this.Controls.Add(this.lab_openfileName);
            this.Controls.Add(this.lab_opentime);
            this.Controls.Add(this.lab_fileName);
            this.Controls.Add(this.richTextBox_show);
            this.Name = "Myform";
            this.Text = "文件信息";
            this.Load += new System.EventHandler(this.Myform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_show;
        private System.Windows.Forms.Label lab_fileName;
        private System.Windows.Forms.Label lab_opentime;
        private System.Windows.Forms.Label lab_openfileName;
        private System.Windows.Forms.Label lab_openfile_time;
    }
}