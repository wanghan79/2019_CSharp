namespace Open_Search_ListBox
{
    partial class FileShow
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
            this.components = new System.ComponentModel.Container();
            this.Timelabel = new System.Windows.Forms.Label();
            this.ShowFile = new System.Windows.Forms.TextBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Location = new System.Drawing.Point(27, 13);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(62, 18);
            this.Timelabel.TabIndex = 0;
            this.Timelabel.Text = "label1";
            // 
            // ShowFile
            // 
            this.ShowFile.Location = new System.Drawing.Point(39, 57);
            this.ShowFile.Multiline = true;
            this.ShowFile.Name = "ShowFile";
            this.ShowFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ShowFile.Size = new System.Drawing.Size(331, 280);
            this.ShowFile.TabIndex = 1;
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // FileShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 365);
            this.Controls.Add(this.ShowFile);
            this.Controls.Add(this.Timelabel);
            this.Name = "FileShow";
            this.Text = "FileShow";
            this.Load += new System.EventHandler(this.FileShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.TextBox ShowFile;
        private System.Windows.Forms.Timer clock;
    }
}