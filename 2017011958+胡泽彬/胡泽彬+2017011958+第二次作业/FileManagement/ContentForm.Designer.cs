namespace FileManagement
{
    partial class ContentForm
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
            this.tboxContent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tboxContent
            // 
            this.tboxContent.Location = new System.Drawing.Point(3, 3);
            this.tboxContent.Multiline = true;
            this.tboxContent.Name = "tboxContent";
            this.tboxContent.Size = new System.Drawing.Size(664, 617);
            this.tboxContent.TabIndex = 0;
            // 
            // contentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 622);
            this.Controls.Add(this.tboxContent);
            this.Name = "contentForm";
            this.Text = "contentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxContent;
    }
}