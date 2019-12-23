namespace wangyh_work
{
    partial class main_form
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
            this.folder_path = new System.Windows.Forms.TextBox();
            this.chose_folder = new System.Windows.Forms.Button();
            this.chose_types = new System.Windows.Forms.TextBox();
            this.bt_run_file = new System.Windows.Forms.Button();
            this.search_result = new System.Windows.Forms.ListBox();
            this.pb_searching = new System.Windows.Forms.ProgressBar();
            this.timer_searching = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // folder_path
            // 
            this.folder_path.Location = new System.Drawing.Point(57, 47);
            this.folder_path.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.folder_path.Name = "folder_path";
            this.folder_path.Size = new System.Drawing.Size(616, 28);
            this.folder_path.TabIndex = 0;
            this.folder_path.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.folder_path_KeyPress);
            // 
            // chose_folder
            // 
            this.chose_folder.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chose_folder.Location = new System.Drawing.Point(744, 42);
            this.chose_folder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chose_folder.Name = "chose_folder";
            this.chose_folder.Size = new System.Drawing.Size(84, 35);
            this.chose_folder.TabIndex = 1;
            this.chose_folder.Text = "...";
            this.chose_folder.UseVisualStyleBackColor = true;
            this.chose_folder.Click += new System.EventHandler(this.chose_folder_Click);
            // 
            // chose_types
            // 
            this.chose_types.Location = new System.Drawing.Point(57, 125);
            this.chose_types.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chose_types.Name = "chose_types";
            this.chose_types.Size = new System.Drawing.Size(615, 28);
            this.chose_types.TabIndex = 2;
            this.chose_types.Text = "请输入要查询的类型，如“*.txt”,或指定文件，如“xxx.docx”回车结束";
            this.chose_types.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chose_types_KeyPress);
            // 
            // bt_run_file
            // 
            this.bt_run_file.Location = new System.Drawing.Point(937, 582);
            this.bt_run_file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_run_file.Name = "bt_run_file";
            this.bt_run_file.Size = new System.Drawing.Size(112, 49);
            this.bt_run_file.TabIndex = 4;
            this.bt_run_file.Text = "打开";
            this.bt_run_file.UseVisualStyleBackColor = true;
            this.bt_run_file.Click += new System.EventHandler(this.bt_run_file_Click);
            // 
            // search_result
            // 
            this.search_result.FormattingEnabled = true;
            this.search_result.HorizontalScrollbar = true;
            this.search_result.ItemHeight = 18;
            this.search_result.Location = new System.Drawing.Point(57, 227);
            this.search_result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_result.Name = "search_result";
            this.search_result.Size = new System.Drawing.Size(616, 328);
            this.search_result.TabIndex = 9;
            this.search_result.DoubleClick += new System.EventHandler(this.search_result_DoubleClick);
            // 
            // pb_searching
            // 
            this.pb_searching.Location = new System.Drawing.Point(58, 83);
            this.pb_searching.Name = "pb_searching";
            this.pb_searching.Size = new System.Drawing.Size(614, 22);
            this.pb_searching.TabIndex = 10;
            // 
            // timer_searching
            // 
            this.timer_searching.Interval = 10;
            this.timer_searching.Tick += new System.EventHandler(this.timer_searching_Tick);
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 650);
            this.Controls.Add(this.pb_searching);
            this.Controls.Add(this.search_result);
            this.Controls.Add(this.bt_run_file);
            this.Controls.Add(this.chose_types);
            this.Controls.Add(this.chose_folder);
            this.Controls.Add(this.folder_path);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main_form";
            this.Text = "main_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox folder_path;
        private System.Windows.Forms.Button chose_folder;
        private System.Windows.Forms.TextBox chose_types;
        private System.Windows.Forms.Button bt_run_file;
        private System.Windows.Forms.ListBox search_result;
        private System.Windows.Forms.ProgressBar pb_searching;
        private System.Windows.Forms.Timer timer_searching;
    }
}