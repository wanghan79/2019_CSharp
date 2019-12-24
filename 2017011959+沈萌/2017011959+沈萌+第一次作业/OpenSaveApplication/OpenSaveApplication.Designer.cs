using System.Drawing;
namespace DelegateTest
{
    partial class CopyFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CopyFiles));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new CCWin.SkinControl.SkinButton();
            this.DstFolder = new CCWin.SkinControl.SkinButton();
            this.CpyButton = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.ClearButton1 = new CCWin.SkinControl.SkinButton();
            this.ClearButton2 = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(26, 353);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(444, 18);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(27, 424);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(443, 135);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(26, 56);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(444, 240);
            this.listBox2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button1.DownBack = null;
            this.button1.Location = new System.Drawing.Point(288, 13);
            this.button1.MouseBack = null;
            this.button1.Name = "button1";
            this.button1.NormlBack = null;
            this.button1.Size = new System.Drawing.Size(88, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "选取文件";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DstFolder
            // 
            this.DstFolder.BackColor = System.Drawing.Color.Transparent;
            this.DstFolder.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.DstFolder.DownBack = null;
            this.DstFolder.Location = new System.Drawing.Point(289, 309);
            this.DstFolder.MouseBack = null;
            this.DstFolder.Name = "DstFolder";
            this.DstFolder.NormlBack = null;
            this.DstFolder.Size = new System.Drawing.Size(87, 38);
            this.DstFolder.TabIndex = 8;
            this.DstFolder.Text = "选择目录";
            this.DstFolder.UseVisualStyleBackColor = false;
            this.DstFolder.Click += new System.EventHandler(this.DstFolder_Click);
            // 
            // CpyButton
            // 
            this.CpyButton.BackColor = System.Drawing.Color.Transparent;
            this.CpyButton.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.CpyButton.DownBack = null;
            this.CpyButton.Location = new System.Drawing.Point(381, 380);
            this.CpyButton.MouseBack = null;
            this.CpyButton.Name = "CpyButton";
            this.CpyButton.NormlBack = null;
            this.CpyButton.Size = new System.Drawing.Size(89, 37);
            this.CpyButton.TabIndex = 9;
            this.CpyButton.Text = "开始复制";
            this.CpyButton.UseVisualStyleBackColor = false;
            this.CpyButton.Click += new System.EventHandler(this.CpyButton_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(23, 388);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(69, 20);
            this.skinLabel1.TabIndex = 10;
            this.skinLabel1.Text = "拷贝进度";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(23, 317);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(69, 20);
            this.skinLabel2.TabIndex = 11;
            this.skinLabel2.Text = "目标目录";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(23, 22);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(84, 20);
            this.skinLabel3.TabIndex = 12;
            this.skinLabel3.Text = "源文件列表";
            // 
            // ClearButton1
            // 
            this.ClearButton1.BackColor = System.Drawing.Color.Transparent;
            this.ClearButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ClearButton1.DownBack = null;
            this.ClearButton1.Location = new System.Drawing.Point(382, 13);
            this.ClearButton1.MouseBack = null;
            this.ClearButton1.Name = "ClearButton1";
            this.ClearButton1.NormlBack = null;
            this.ClearButton1.Size = new System.Drawing.Size(88, 38);
            this.ClearButton1.TabIndex = 14;
            this.ClearButton1.Text = "清空列表";
            this.ClearButton1.UseVisualStyleBackColor = false;
            this.ClearButton1.Click += new System.EventHandler(this.ClearButton1_Click);
            // 
            // ClearButton2
            // 
            this.ClearButton2.BackColor = System.Drawing.Color.Transparent;
            this.ClearButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ClearButton2.DownBack = null;
            this.ClearButton2.Location = new System.Drawing.Point(381, 309);
            this.ClearButton2.MouseBack = null;
            this.ClearButton2.Name = "ClearButton2";
            this.ClearButton2.NormlBack = null;
            this.ClearButton2.Size = new System.Drawing.Size(89, 37);
            this.ClearButton2.TabIndex = 15;
            this.ClearButton2.Text = "清空目录";
            this.ClearButton2.UseVisualStyleBackColor = false;
            this.ClearButton2.Click += new System.EventHandler(this.ClearButton2_Click);
            // 
            // CopyFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(498, 574);
            this.Controls.Add(this.ClearButton2);
            this.Controls.Add(this.ClearButton1);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.CpyButton);
            this.Controls.Add(this.DstFolder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CopyFiles";
            this.Text = "CopyFilesWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private CCWin.SkinControl.SkinButton button1;
        private CCWin.SkinControl.SkinButton DstFolder;
        private CCWin.SkinControl.SkinButton CpyButton;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton ClearButton1;
        private CCWin.SkinControl.SkinButton ClearButton2;
    }
}

