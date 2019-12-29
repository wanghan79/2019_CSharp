namespace HR_APP
{
    partial class hr
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.show_file = new System.Windows.Forms.ListBox();
            this.open_file = new System.Windows.Forms.Button();
            this.select_file = new System.Windows.Forms.TextBox();
            this.find_file = new System.Windows.Forms.TextBox();
            this.button_read = new System.Windows.Forms.Button();
            this.searching = new System.Windows.Forms.ProgressBar();
            this.searching_time = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // show_file
            // 
            this.show_file.FormattingEnabled = true;
            this.show_file.ItemHeight = 12;
            this.show_file.Location = new System.Drawing.Point(22, 134);
            this.show_file.Name = "show_file";
            this.show_file.Size = new System.Drawing.Size(277, 88);
            this.show_file.TabIndex = 0;
            this.show_file.SelectedIndexChanged += new System.EventHandler(this.show_file_SelectedIndexChanged);
            // 
            // open_file
            // 
            this.open_file.Location = new System.Drawing.Point(438, 211);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(75, 23);
            this.open_file.TabIndex = 2;
            this.open_file.Text = "打开";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.open_file_Click);
            // 
            // select_file
            // 
            this.select_file.Location = new System.Drawing.Point(22, 80);
            this.select_file.Name = "select_file";
            this.select_file.Size = new System.Drawing.Size(277, 21);
            this.select_file.TabIndex = 3;
            this.select_file.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.select_file_KeyPress);
            // 
            // find_file
            // 
            this.find_file.Location = new System.Drawing.Point(22, 12);
            this.find_file.Name = "find_file";
            this.find_file.Size = new System.Drawing.Size(277, 21);
            this.find_file.TabIndex = 4;
            this.find_file.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.find_file_KeyPress);
            // 
            // button_read
            // 
            this.button_read.Location = new System.Drawing.Point(329, 12);
            this.button_read.Name = "button_read";
            this.button_read.Size = new System.Drawing.Size(75, 23);
            this.button_read.TabIndex = 1;
            this.button_read.Text = ". . .";
            this.button_read.UseVisualStyleBackColor = true;
            this.button_read.Click += new System.EventHandler(this.button_read_Click);
            // 
            // searching
            // 
            this.searching.Location = new System.Drawing.Point(22, 39);
            this.searching.Name = "searching";
            this.searching.Size = new System.Drawing.Size(277, 23);
            this.searching.TabIndex = 5;
            // 
            // searching_time
            // 
            this.searching_time.Tick += new System.EventHandler(this.searching_time_Tick);
            // 
            // hr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 261);
            this.Controls.Add(this.searching);
            this.Controls.Add(this.find_file);
            this.Controls.Add(this.select_file);
            this.Controls.Add(this.open_file);
            this.Controls.Add(this.button_read);
            this.Controls.Add(this.show_file);
            this.Name = "hr";
            this.Text = "direction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox show_file;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.TextBox select_file;
        private System.Windows.Forms.TextBox find_file;
        private System.Windows.Forms.Button button_read;
        private System.Windows.Forms.ProgressBar searching;
        private System.Windows.Forms.Timer searching_time;
    }
}

