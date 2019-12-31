namespace Final_Homework
{
    partial class Files_Manager
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Files_Manager));
            this.directoryTree = new System.Windows.Forms.TreeView();
            this.directoryicons = new System.Windows.Forms.ImageList(this.components);
            this.fileslist = new System.Windows.Forms.ListView();
            this.fileslisticons = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open_toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tBX_Show = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.tBX_control = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.timer_check = new System.Windows.Forms.Timer(this.components);
            this.btn_counting = new System.Windows.Forms.Button();
            this.timer_count_Message = new System.Windows.Forms.Timer(this.components);
            this.btn_end = new System.Windows.Forms.Button();
            this.lbl_FilePath = new System.Windows.Forms.Label();
            this.lbl_file_check = new System.Windows.Forms.Label();
            this.lbl_SystemName = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // directoryTree
            // 
            this.directoryTree.ImageIndex = 0;
            this.directoryTree.ImageList = this.directoryicons;
            this.directoryTree.Location = new System.Drawing.Point(29, 187);
            this.directoryTree.Name = "directoryTree";
            this.directoryTree.SelectedImageIndex = 0;
            this.directoryTree.Size = new System.Drawing.Size(373, 468);
            this.directoryTree.TabIndex = 0;
            this.directoryTree.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.directoryTree_BeforeExpand);
            this.directoryTree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.directoryTree_AfterExpand);
            this.directoryTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.directoryTree_AfterSelect_1);
            // 
            // directoryicons
            // 
            this.directoryicons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("directoryicons.ImageStream")));
            this.directoryicons.TransparentColor = System.Drawing.Color.Transparent;
            this.directoryicons.Images.SetKeyName(0, "My Computer.ico");
            this.directoryicons.Images.SetKeyName(1, "Folder empty.ico");
            this.directoryicons.Images.SetKeyName(2, "Folder.ico");
            this.directoryicons.Images.SetKeyName(3, "HDD.ico");
            this.directoryicons.Images.SetKeyName(4, "My documents.ico");
            // 
            // fileslist
            // 
            this.fileslist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fileslist.Location = new System.Drawing.Point(452, 187);
            this.fileslist.Name = "fileslist";
            this.fileslist.Size = new System.Drawing.Size(655, 468);
            this.fileslist.SmallImageList = this.fileslisticons;
            this.fileslist.TabIndex = 1;
            this.fileslist.UseCompatibleStateImageBehavior = false;
            this.fileslist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fileslist_MouseClick);
            // 
            // fileslisticons
            // 
            this.fileslisticons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileslisticons.ImageStream")));
            this.fileslisticons.TransparentColor = System.Drawing.Color.Transparent;
            this.fileslisticons.Images.SetKeyName(0, "Folder empty.ico");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_toolStripMenuItem1,
            this.delete_toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 52);
            // 
            // open_toolStripMenuItem1
            // 
            this.open_toolStripMenuItem1.Name = "open_toolStripMenuItem1";
            this.open_toolStripMenuItem1.Size = new System.Drawing.Size(138, 24);
            this.open_toolStripMenuItem1.Text = "打开文件";
            this.open_toolStripMenuItem1.Click += new System.EventHandler(this.open_toolStripMenuItem1_Click);
            // 
            // delete_toolStripMenuItem2
            // 
            this.delete_toolStripMenuItem2.Name = "delete_toolStripMenuItem2";
            this.delete_toolStripMenuItem2.Size = new System.Drawing.Size(138, 24);
            this.delete_toolStripMenuItem2.Text = "删除文件";
            this.delete_toolStripMenuItem2.Click += new System.EventHandler(this.deleteFileToolStripMenuItem_Click);
            // 
            // tBX_Show
            // 
            this.tBX_Show.Location = new System.Drawing.Point(228, 111);
            this.tBX_Show.Multiline = true;
            this.tBX_Show.Name = "tBX_Show";
            this.tBX_Show.ReadOnly = true;
            this.tBX_Show.Size = new System.Drawing.Size(174, 58);
            this.tBX_Show.TabIndex = 2;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(822, 109);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 59);
            this.btn_select.TabIndex = 3;
            this.btn_select.Text = "选择文件夹";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(920, 109);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 59);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "清空";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // tBX_control
            // 
            this.tBX_control.Location = new System.Drawing.Point(590, 110);
            this.tBX_control.Multiline = true;
            this.tBX_control.Name = "tBX_control";
            this.tBX_control.ReadOnly = true;
            this.tBX_control.Size = new System.Drawing.Size(207, 59);
            this.tBX_control.TabIndex = 5;
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            this.fileSystemWatcher.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Changed);
            this.fileSystemWatcher.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Created);
            this.fileSystemWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher_Deleted);
            this.fileSystemWatcher.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher_Renamed);
            // 
            // timer_check
            // 
            this.timer_check.Interval = 10000;
            this.timer_check.Tick += new System.EventHandler(this.timer_check_Tick);
            // 
            // btn_counting
            // 
            this.btn_counting.Location = new System.Drawing.Point(1010, 104);
            this.btn_counting.Name = "btn_counting";
            this.btn_counting.Size = new System.Drawing.Size(97, 32);
            this.btn_counting.TabIndex = 6;
            this.btn_counting.Text = "开始计时";
            this.btn_counting.UseVisualStyleBackColor = true;
            this.btn_counting.Click += new System.EventHandler(this.btn_counting_Click);
            // 
            // timer_count_Message
            // 
            this.timer_count_Message.Interval = 3000;
            this.timer_count_Message.Tick += new System.EventHandler(this.timer_count_Message_Tick);
            // 
            // btn_end
            // 
            this.btn_end.Location = new System.Drawing.Point(1010, 142);
            this.btn_end.Name = "btn_end";
            this.btn_end.Size = new System.Drawing.Size(97, 32);
            this.btn_end.TabIndex = 7;
            this.btn_end.Text = "结束计时";
            this.btn_end.UseVisualStyleBackColor = true;
            this.btn_end.Click += new System.EventHandler(this.btn_end_Click);
            // 
            // lbl_FilePath
            // 
            this.lbl_FilePath.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_FilePath.Location = new System.Drawing.Point(25, 127);
            this.lbl_FilePath.Name = "lbl_FilePath";
            this.lbl_FilePath.Size = new System.Drawing.Size(176, 33);
            this.lbl_FilePath.TabIndex = 8;
            this.lbl_FilePath.Text = "文件夹路径：";
            // 
            // lbl_file_check
            // 
            this.lbl_file_check.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_file_check.Location = new System.Drawing.Point(448, 125);
            this.lbl_file_check.Name = "lbl_file_check";
            this.lbl_file_check.Size = new System.Drawing.Size(136, 29);
            this.lbl_file_check.TabIndex = 9;
            this.lbl_file_check.Text = "文件检测：";
            // 
            // lbl_SystemName
            // 
            this.lbl_SystemName.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_SystemName.Location = new System.Drawing.Point(417, 30);
            this.lbl_SystemName.Name = "lbl_SystemName";
            this.lbl_SystemName.Size = new System.Drawing.Size(327, 39);
            this.lbl_SystemName.TabIndex = 10;
            this.lbl_SystemName.Text = "简易文件管理监测系统";
            // 
            // Files_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 683);
            this.Controls.Add(this.lbl_SystemName);
            this.Controls.Add(this.lbl_file_check);
            this.Controls.Add(this.lbl_FilePath);
            this.Controls.Add(this.btn_end);
            this.Controls.Add(this.btn_counting);
            this.Controls.Add(this.tBX_control);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.tBX_Show);
            this.Controls.Add(this.fileslist);
            this.Controls.Add(this.directoryTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Files_Manager";
            this.Text = "Files_Manager";
            this.Load += new System.EventHandler(this.Files_Manager_Load_1);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView directoryTree;
        private System.Windows.Forms.ListView fileslist;
        private System.Windows.Forms.ImageList directoryicons;
        private System.Windows.Forms.ImageList fileslisticons;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem open_toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem delete_toolStripMenuItem2;
        private System.Windows.Forms.TextBox tBX_Show;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox tBX_control;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        private System.Windows.Forms.Timer timer_check;
        private System.Windows.Forms.Button btn_counting;
        private System.Windows.Forms.Timer timer_count_Message;
        private System.Windows.Forms.Button btn_end;
        private System.Windows.Forms.Label lbl_file_check;
        private System.Windows.Forms.Label lbl_FilePath;
        private System.Windows.Forms.Label lbl_SystemName;
    }
}

