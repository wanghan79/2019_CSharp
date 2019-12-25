namespace MyFiles
{
    partial class ShowCon
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
            this.ShCon = new System.Windows.Forms.TextBox();
            this.CurTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShCon
            // 
            this.ShCon.Location = new System.Drawing.Point(12, 13);
            this.ShCon.Multiline = true;
            this.ShCon.Name = "ShCon";
            this.ShCon.Size = new System.Drawing.Size(265, 191);
            this.ShCon.TabIndex = 0;
            this.ShCon.TextChanged += new System.EventHandler(this.ShCon_TextChanged);
            // 
            // CurTime
            // 
            this.CurTime.Location = new System.Drawing.Point(139, 230);
            this.CurTime.Name = "CurTime";
            this.CurTime.Size = new System.Drawing.Size(138, 21);
            this.CurTime.TabIndex = 1;
            this.CurTime.TextChanged += new System.EventHandler(this.CurTime_TextChanged);
            // 
            // ShowCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 274);
            this.Controls.Add(this.CurTime);
            this.Controls.Add(this.ShCon);
            this.Name = "ShowCon";
            this.Text = "ShowCon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox ShCon;
        public System.Windows.Forms.TextBox CurTime;
    }
}