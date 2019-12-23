namespace Windows窗体事件
{
    partial class FormOne
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
            this.txBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txBox
            // 
            this.txBox.Location = new System.Drawing.Point(109, 144);
            this.txBox.Name = "txBox";
            this.txBox.Size = new System.Drawing.Size(100, 25);
            this.txBox.TabIndex = 0;
            this.txBox.Click += new System.EventHandler(this.textBox1_Click);
            this.txBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.txBox);
            this.Name = "FormOne";
            this.Text = "FormOne";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBox;
    }
}

