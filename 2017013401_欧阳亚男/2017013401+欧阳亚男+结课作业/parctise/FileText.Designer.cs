namespace parctise
{
    partial class FileText
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
            this.ttxt_fileText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ttxt_fileText
            // 
            this.ttxt_fileText.Location = new System.Drawing.Point(12, 7);
            this.ttxt_fileText.Multiline = true;
            this.ttxt_fileText.Name = "ttxt_fileText";
            this.ttxt_fileText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ttxt_fileText.Size = new System.Drawing.Size(776, 317);
            this.ttxt_fileText.TabIndex = 0;
            this.ttxt_fileText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FileText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ttxt_fileText);
            this.Name = "FileText";
            this.Text = "FileText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ttxt_fileText;
    }
}