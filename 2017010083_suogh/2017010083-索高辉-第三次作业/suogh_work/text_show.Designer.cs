namespace suogh_work
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
            this.text_box = new System.Windows.Forms.TextBox();
            this.system_time = new System.Windows.Forms.Timer(this.components);
            this.tx_time = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_box
            // 
            this.text_box.Location = new System.Drawing.Point(2, 2);
            this.text_box.Multiline = true;
            this.text_box.Name = "text_box";
            this.text_box.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_box.Size = new System.Drawing.Size(660, 469);
            this.text_box.TabIndex = 0;
            // 
            // system_time
            // 
            this.system_time.Tick += new System.EventHandler(this.system_time_Tick);
            // 
            // tx_time
            // 
            this.tx_time.Location = new System.Drawing.Point(2, 473);
            this.tx_time.Name = "tx_time";
            this.tx_time.Size = new System.Drawing.Size(659, 25);
            this.tx_time.TabIndex = 1;
            // 
            // text_show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 501);
            this.Controls.Add(this.tx_time);
            this.Controls.Add(this.text_box);
            this.Name = "text_show";
            this.Text = "text_show";
            this.Load += new System.EventHandler(this.text_show_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_box;
        private System.Windows.Forms.Timer system_time;
        private System.Windows.Forms.TextBox tx_time;
    }
}