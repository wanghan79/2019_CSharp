namespace FirstClass
{
    partial class saveFile
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
            this.btn_openFiles = new System.Windows.Forms.Button();
            this.btn_saveFiles = new System.Windows.Forms.Button();
            this.txt_showFiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_openFiles
            // 
            this.btn_openFiles.Location = new System.Drawing.Point(94, 30);
            this.btn_openFiles.Name = "btn_openFiles";
            this.btn_openFiles.Size = new System.Drawing.Size(105, 36);
            this.btn_openFiles.TabIndex = 0;
            this.btn_openFiles.Text = "openFiles";
            this.btn_openFiles.UseVisualStyleBackColor = true;
            this.btn_openFiles.Click += new System.EventHandler(this.btn_openFiles_Click);
            // 
            // btn_saveFiles
            // 
            this.btn_saveFiles.Location = new System.Drawing.Point(693, 244);
            this.btn_saveFiles.Name = "btn_saveFiles";
            this.btn_saveFiles.Size = new System.Drawing.Size(86, 39);
            this.btn_saveFiles.TabIndex = 1;
            this.btn_saveFiles.Text = "saveFiles";
            this.btn_saveFiles.UseVisualStyleBackColor = true;
            this.btn_saveFiles.Click += new System.EventHandler(this.btn_saveFiles_Click);
            // 
            // txt_showFiles
            // 
            this.txt_showFiles.Location = new System.Drawing.Point(94, 72);
            this.txt_showFiles.Multiline = true;
            this.txt_showFiles.Name = "txt_showFiles";
            this.txt_showFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_showFiles.Size = new System.Drawing.Size(479, 242);
            this.txt_showFiles.TabIndex = 2;
            // 
            // saveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_showFiles);
            this.Controls.Add(this.btn_saveFiles);
            this.Controls.Add(this.btn_openFiles);
            this.Name = "saveFile";
            this.Text = "saveFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_openFiles;
        private System.Windows.Forms.Button btn_saveFiles;
        private System.Windows.Forms.TextBox txt_showFiles;
    }
}