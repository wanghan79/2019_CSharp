namespace fileCopy
{
    partial class MainForm
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
            this.btn_pickFile = new System.Windows.Forms.Button();
            this.btn_copyTo = new System.Windows.Forms.Button();
            this.lab_pickFileName = new System.Windows.Forms.Label();
            this.lab_savePath = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_pickFile
            // 
            this.btn_pickFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_pickFile.AutoSize = true;
            this.btn_pickFile.Location = new System.Drawing.Point(12, 119);
            this.btn_pickFile.Name = "btn_pickFile";
            this.btn_pickFile.Size = new System.Drawing.Size(135, 23);
            this.btn_pickFile.TabIndex = 0;
            this.btn_pickFile.Text = "选择文件";
            this.btn_pickFile.UseVisualStyleBackColor = true;
            this.btn_pickFile.Click += new System.EventHandler(this.btn_pickFile_Click);
            // 
            // btn_copyTo
            // 
            this.btn_copyTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_copyTo.AutoSize = true;
            this.btn_copyTo.Location = new System.Drawing.Point(12, 175);
            this.btn_copyTo.Name = "btn_copyTo";
            this.btn_copyTo.Size = new System.Drawing.Size(135, 23);
            this.btn_copyTo.TabIndex = 1;
            this.btn_copyTo.Text = "复制到";
            this.btn_copyTo.UseVisualStyleBackColor = true;
            this.btn_copyTo.Click += new System.EventHandler(this.btn_copyTo_click);
            // 
            // lab_pickFileName
            // 
            this.lab_pickFileName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_pickFileName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_pickFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_pickFileName.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_pickFileName.Location = new System.Drawing.Point(153, 119);
            this.lab_pickFileName.Name = "lab_pickFileName";
            this.lab_pickFileName.Size = new System.Drawing.Size(469, 23);
            this.lab_pickFileName.TabIndex = 2;
            this.lab_pickFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_pickFileName.Click += new System.EventHandler(this.lab_pickFileName_Click);
            // 
            // lab_savePath
            // 
            this.lab_savePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lab_savePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_savePath.Font = new System.Drawing.Font("宋体", 12F);
            this.lab_savePath.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lab_savePath.Location = new System.Drawing.Point(153, 175);
            this.lab_savePath.Name = "lab_savePath";
            this.lab_savePath.Size = new System.Drawing.Size(469, 23);
            this.lab_savePath.TabIndex = 3;
            this.lab_savePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lab_savePath.Click += new System.EventHandler(this.lab_savePath_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_submit.Location = new System.Drawing.Point(487, 233);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(135, 23);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "确定";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_reset.Location = new System.Drawing.Point(346, 233);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(135, 23);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "重置";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 379);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lab_savePath);
            this.Controls.Add(this.lab_pickFileName);
            this.Controls.Add(this.btn_copyTo);
            this.Controls.Add(this.btn_pickFile);
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "MainForm";
            this.Text = "2017011827胡顺航";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_pickFile;
        private System.Windows.Forms.Button btn_copyTo;
        private System.Windows.Forms.Label lab_pickFileName;
        private System.Windows.Forms.Label lab_savePath;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_reset;
    }
}

