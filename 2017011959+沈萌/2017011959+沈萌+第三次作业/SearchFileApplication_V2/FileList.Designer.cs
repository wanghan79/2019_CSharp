namespace SearchFileApplication
{
    partial class FileList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileList));
            this.Timelabel = new System.Windows.Forms.Label();
            this.DetailFile = new System.Windows.Forms.TextBox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Location = new System.Drawing.Point(76, 18);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(55, 15);
            this.Timelabel.TabIndex = 0;
            this.Timelabel.Text = "label1";
            // 
            // DetailFile
            // 
            this.DetailFile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DetailFile.Location = new System.Drawing.Point(25, 53);
            this.DetailFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DetailFile.Multiline = true;
            this.DetailFile.Name = "DetailFile";
            this.DetailFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DetailFile.Size = new System.Drawing.Size(299, 248);
            this.DetailFile.TabIndex = 1;
            this.DetailFile.TextChanged += new System.EventHandler(this.FileList_TextChanged);
            // 
            // clock
            // 
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(21, 15);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(39, 20);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "时钟";
            // 
            // FileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(364, 312);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.DetailFile);
            this.Controls.Add(this.Timelabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FileList";
            this.Text = "FileList";
            this.Load += new System.EventHandler(this.FileList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FileList_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.TextBox DetailFile;
        private System.Windows.Forms.Timer clock;
        private CCWin.SkinControl.SkinLabel skinLabel1;
    }
}