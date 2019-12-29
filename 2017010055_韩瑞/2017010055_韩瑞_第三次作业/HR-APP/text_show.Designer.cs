namespace HR_APP
{
    partial class text_show
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
            this.show_content = new System.Windows.Forms.TextBox();
            this.system_time = new System.Windows.Forms.Timer(this.components);
            this.show_time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // show_content
            // 
            this.show_content.Location = new System.Drawing.Point(-1, -4);
            this.show_content.Name = "show_content";
            this.show_content.Size = new System.Drawing.Size(292, 21);
            this.show_content.TabIndex = 0;
            // 
            // system_time
            // 
            this.system_time.Tick += new System.EventHandler(this.system_time_Tick);
            // 
            // show_time
            // 
            this.show_time.Location = new System.Drawing.Point(-1, 183);
            this.show_time.Name = "show_time";
            this.show_time.Size = new System.Drawing.Size(100, 21);
            this.show_time.TabIndex = 1;
            // 
            // text_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.show_time);
            this.Controls.Add(this.show_content);
            this.Name = "text_show";
            this.Text = "text_show";
            this.Load += new System.EventHandler(this.text_show_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox show_content;
        private System.Windows.Forms.Timer system_time;
        private System.Windows.Forms.TextBox show_time;
    }
}