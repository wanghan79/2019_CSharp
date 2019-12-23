namespace CommonDialog
{
    partial class Form1
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
            this.OpenFile = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.FileFont = new System.Windows.Forms.Button();
            this.FileExit = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(21, 58);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(98, 43);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "OpenFile";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(150, 58);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(91, 43);
            this.SaveFile.TabIndex = 1;
            this.SaveFile.Text = "SaveFile";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // FileFont
            // 
            this.FileFont.Location = new System.Drawing.Point(32, 117);
            this.FileFont.Name = "FileFont";
            this.FileFont.Size = new System.Drawing.Size(75, 50);
            this.FileFont.TabIndex = 2;
            this.FileFont.Text = "字体";
            this.FileFont.UseVisualStyleBackColor = true;
            this.FileFont.Click += new System.EventHandler(this.FileFont_Click);
            // 
            // FileExit
            // 
            this.FileExit.Location = new System.Drawing.Point(163, 127);
            this.FileExit.Name = "FileExit";
            this.FileExit.Size = new System.Drawing.Size(107, 40);
            this.FileExit.TabIndex = 3;
            this.FileExit.Text = "退出";
            this.FileExit.UseVisualStyleBackColor = true;
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(57, 197);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 30);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.FileExit);
            this.Controls.Add(this.FileFont);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.OpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.Button FileFont;
        private System.Windows.Forms.Button FileExit;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

