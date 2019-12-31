using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace Final_Homework
{
    public partial class Files_Manager : Form
    {
        public Files_Manager()
        {
            InitializeComponent();
        }
        /// <summary>
        /// IconIndexs类 对应ImageList中5张图片的序列
        /// </summary>
        private class IconIndexes
        {
            public const int MyComputer = 0;      //我的电脑
            public const int ClosedFolder = 1;    //文件夹关闭
            public const int OpenFolder = 2;      //文件夹打开
            public const int FixedDrive = 3;      //磁盘盘符
            public const int MyDocuments = 4;     //我的文档
        }
        /*--------------------------------------*/
        /// <summary>
        /// 窗体加载Load事件 初始化
        /// </summary>
        /// private void Files_Manager_Load_1(object sender, EventArgs e)
        private void Files_Manager_Load_1(object sender, EventArgs e)
        {
            SetListView();
            //实例化TreeNode类 TreeNode(string text,int imageIndex,int selectImageIndex)            
            TreeNode rootNode = new TreeNode("我的电脑",
                IconIndexes.MyComputer, IconIndexes.MyComputer);  //载入显示 选择显示
            rootNode.Tag = "我的电脑";                            //树节点数据
            rootNode.Text = "我的电脑";                           //树节点标签内容
            this.directoryTree.Nodes.Add(rootNode);               //树中添加根目录

            //显示MyDocuments(我的文档)结点
            var myDocuments = Environment.GetFolderPath           //获取计算机我的文档文件夹
                (Environment.SpecialFolder.MyDocuments);
            TreeNode DocNode = new TreeNode(myDocuments);
            DocNode.Tag = "我的文档";                            //设置结点名称
            DocNode.Text = "我的文档";
            DocNode.ImageIndex = IconIndexes.MyDocuments;         //设置获取结点显示图片
            DocNode.SelectedImageIndex = IconIndexes.MyDocuments; //设置选择显示图片
            rootNode.Nodes.Add(DocNode);                          //rootNode目录下加载节点
            DocNode.Nodes.Add("");

            //循环遍历计算机所有逻辑驱动器名称(盘符)
            foreach (string drive in Environment.GetLogicalDrives())
            {
                //实例化DriveInfo对象 命名空间System.IO
                var dir = new DriveInfo(drive);
                switch (dir.DriveType)           //判断驱动器类型
                {
                    case DriveType.Fixed:        //仅取固定磁盘盘符 Removable-U盘 
                        {
                            //Split仅获取盘符字母
                            TreeNode tNode = new TreeNode(dir.Name.Split(':')[0]);
                            tNode.Name = dir.Name;
                            tNode.Tag = tNode.Name;
                            tNode.ImageIndex = IconIndexes.FixedDrive;         //获取结点显示图片
                            tNode.SelectedImageIndex = IconIndexes.FixedDrive; //选择显示图片
                            directoryTree.Nodes.Add(tNode);                    //加载驱动节点
                            tNode.Nodes.Add("");
                        }
                        break;
                }
            }
            rootNode.Expand();                  //展开树状视图
        }
        /*--------------------------------------*/
        /// <summary>
        /// 在结点展开后发生 展开子结点
        /// </summary>
        /// 
        /// 
        private void directoryTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            e.Node.Expand();
        }
        private void directoryTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Expand();
        }
        /*--------------------------------------*/
        /// <summary>
        /// 在将要展开结点时发生 加载子结点
        /// </summary>
        private void directoryTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            TreeViewItems.Add(e.Node);
        }
        private void directoryTree_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeViewItems.Add(e.Node);
        }
        /*--------------------------------------*/
        /// <summary>
        /// 自定义类TreeViewItems 调用其Add(TreeNode e)方法加载子目录
        /// </summary>
        ///  
        public static class TreeViewItems
        {
            public static void Add(TreeNode e)
            {
                //try..catch异常处理
                try
                {
                    //判断"我的电脑"Tag 上面加载的该结点没指定其路径
                    if (e.Tag.ToString() != "我的电脑")
                    {
                        e.Nodes.Clear();                               //清除空节点再加载子节点
                        TreeNode tNode = e;                            //获取选中\展开\折叠结点
                        string path = tNode.Name;                      //路径  

                        //获取"我的文档"路径
                        if (e.Tag.ToString() == "我的文档")
                        {
                            path = Environment.GetFolderPath           //获取计算机我的文档文件夹
                                (Environment.SpecialFolder.MyDocuments);
                        }

                        //获取指定目录中的子目录名称并加载结点
                        string[] dics = Directory.GetDirectories(path);
                        foreach (string dic in dics)
                        {
                            TreeNode subNode = new TreeNode(new DirectoryInfo(dic).Name); //实例化
                            subNode.Name = new DirectoryInfo(dic).FullName;               //完整目录
                            subNode.Tag = subNode.Name;
                            subNode.ImageIndex = IconIndexes.ClosedFolder;       //获取节点显示图片
                            subNode.SelectedImageIndex = IconIndexes.OpenFolder; //选择节点显示图片
                            tNode.Nodes.Add(subNode);
                            subNode.Nodes.Add("");                               //加载空节点 实现+号
                        }
                    }
                }
                catch (Exception msg)
                {
                    MessageBox.Show(msg.Message);                   //异常处理
                }
            }
        }
        /*--------------------------------------*/
        private void SetListView()
        {
            //行和列是否显示网格线
            this.fileslist.GridLines = false;
            //显示方式(注意View是Details详细显示)
            this.fileslist.View = View.Details;
            //是否可编辑
            this.fileslist.LabelEdit = true;
            //没有足够的空间显示时,是否添加滚动条
            this.fileslist.Scrollable = true;
            //对表头进行设置
            this.fileslist.HeaderStyle = ColumnHeaderStyle.Clickable;
            //是否可以选择行
            this.fileslist.FullRowSelect = true;

            //设置listView列标题头 宽度为9/13 2/13 2/13 
            //其中设置标题头自动适应宽度,-1根据内容设置宽度,-2根据标题设置宽度
            this.fileslist.Columns.Add("名称", 6 * fileslist.Width / 16);
            this.fileslist.Columns.Add("修改时间", 4 * fileslist.Width / 16);
            this.fileslist.Columns.Add("大小", 3 * fileslist.Width / 16);
            this.fileslist.Columns.Add("类型", 3 * fileslist.Width / 16);
        }
        /*--------------------------------------*/
        #region ListView显示选中文件夹中文件内容
        /// <summary>
        /// 获取节点的路径:递归调用产生节点对应文件夹的路径
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private string GetPathFromNode(TreeNode node)
        {
            //注意:树形控件中我只赋值Tag\Name,使用Text时赋值即可使用
            if (node.Parent == null)
            {
                return node.Name;
            }
            //Path.Combine组合产生路径 如 Path.Combine("A","B")则生成"A\\B"
            return Path.Combine(GetPathFromNode(node.Parent), node.Name);
        }

        /// <summary>
        /// 更改选定内容后发生 后去当前节点名字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void directoryTree_AfterSelect_1(object sender, TreeViewEventArgs e)

        {
            try
            {
                //定义变量
                long length;                        //文件大小
                string path;                        //文件路径
                TreeNode clickedNode = e.Node;      //获取当前选中结点

                //移除ListView所有项 
                this.fileslist.Items.Clear();

                //获取路径赋值path              
                if (clickedNode.Tag.ToString() == "我的文档")
                {
                    //获取计算机我的文档文件夹
                    path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
                else
                {
                    //通过自定义函数GetPathFromNode获取结点路径
                    path = GetPathFromNode(clickedNode);
                }

                //由于"我的电脑"为空结点,无需处理,否则会出现路径获取错误或没有找到"我的电脑"路径
                if (clickedNode.Tag.ToString() != "我的电脑")
                {
                    //数据更新 UI暂时挂起直到EndUpdate绘制控件,可以有效避免闪烁并大大提高加载速度
                    this.fileslist.BeginUpdate();
                    //实例目录与子目录
                    DirectoryInfo dir = new DirectoryInfo(path);
                    //获取当前目录文件列表
                    FileInfo[] fileInfo = dir.GetFiles();
                    //循环输出获取文件信息
                    for (int i = 0; i < fileInfo.Length; i++)
                    {
                        ListViewItem listItem = new ListViewItem();
                        //listItem.SubItems[0].Text = fileInfo[i].Name;             //文件名(方法二)
                        listItem.Text = fileInfo[i].Name;    //显示文件名
                        listItem.ForeColor = Color.Blue;                            //设置行颜色
                        //获取文件最后访问时间
                        listItem.SubItems.Add(fileInfo[i].LastWriteTime.ToString());
                        //length/1024转换为KB字节数整数值 Ceiling返回最小整数值 Divide除法
                        length = fileInfo[i].Length;                                //获取当前文件大小
                        listItem.SubItems.Add(Math.Ceiling(decimal.Divide(length, 1024)) + " KB");
                        //获取文件扩展名时可用Substring除去点 否则显示".txt文件"
                        listItem.SubItems.Add(fileInfo[i].Extension + "文件");
                        //加载数据至fileslist
                        this.fileslist.Items.Add(listItem);
                    }

                    //结束数据处理,UI界面一次性绘制 否则可能出现闪动情况
                    this.fileslist.EndUpdate();
                }
                filePathPublic = path;
                pathName = filePathPublic;
                tBX_Show.Text = pathName;
            }
            catch (Exception msg)  //异常处理
            {
                MessageBox.Show(msg.Message);
            }
        }

        #endregion
        /*--------------------------------------*/
        /*定义全局变量*/
        //全局变量
        public string fileNamePublic = ""; //文件名
        public string filePathPublic = ""; //文件路径
        public string fileName;
        public string pathName;
        private void fileslist_MouseClick(object sender, MouseEventArgs e)
        {
            fileslist.MultiSelect = false;
            //鼠标右键
            if (e.Button == MouseButtons.Right)
            {
                //fileslist.ContextMenuStrip = contextMenuStrip1;
                //选中列表中数据才显示 空白处不显示
                fileName = fileslist.SelectedItems[0].Text; //获取选中文件名
                Point p = new Point(e.X, e.Y);
                contextMenuStrip1.Show(fileslist, p);
            }
            if (e.Button == MouseButtons.Left)
            {
                pathName = filePathPublic;
                tBX_Show.Text = pathName;
            }
        }
        private void directoryTree_MouseClick(object sender, MouseEventArgs e)
        {
            //directoryTree.MultiSelect = false;
            //鼠标右键
            /*fileslist.MultiSelect = false;
            //鼠标右键
            if (e.Button == MouseButtons.Right)
            {
                //fileslist.ContextMenuStrip = contextMenuStrip1;
                //选中列表中数据才显示 空白处不显示
                fileName = fileslist.SelectedItems[0].Text; //获取选中文件名
                Point p = new Point(e.X, e.Y);
                contextMenuStrip1.Show(fileslist, p);
            }
            if (e.Button == MouseButtons.Left)
            {
                pathName = filePathPublic;
                tBX_Show.Text = pathName;
            }*/

        }
        /*--------------------------------------*/

        #region 打开文件操作
        //设置contextMenuStrip1控件中"打开文件"Name为openFile
        private void open_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.fileslist.SelectedItems.Count == 0)
                return;
            //获取选中文件
            var selectedItem = this.fileslist.SelectedItems[0];
            //全局变量文件名 SubItems[1]表示文件名
            fileNamePublic = filePathPublic + "\\" + fileName;
            //MessageBox.Show(fileNamePublic);            显示文件路径！！！
            try
            {
                //实例化一个新的Process类 命名空间using System.Diagnostics;
                using (Process p = new Process())
                {
                    p.StartInfo.FileName = fileNamePublic; //指定要启动的文件路径
                    p.StartInfo.CreateNoWindow = false; //在当前窗口启动程序
                                                        //指定窗口的显示样式
                    p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal;
                    p.StartInfo.UseShellExecute = true; //使用操作系统的shell启动进程
                    p.Start(); //开始打开文件
                }
            }
            catch (Exception msg) //异常处理
            {
                MessageBox.Show(msg.Message);
            }

        }
        #endregion
        /*--------------------------------------------*/

        #region 删除文件
        //删除文件
        //文件删除到回收站中
        private const int FO_DELETE = 3;               //删除
        private const int FOF_SILENT = 0x0004;         //不显示进度条提示框
        private const int FOF_NOCONFIRMATION = 0x0010; //不出现任何对话框
        private const int FOF_ALLOWUNDO = 0x0040;      //允许撤销
        private const int FOF_NOCONFIRMMKDIR = 0x0200; //创建文件夹的时候不用确认

        //添加命名空间using System.Runtime.InteropServices;
        [StructLayout(LayoutKind.Sequential)]
        private struct SHFILEOPSTRUCT
        {
            public int hwnd;                     //父窗口句柄,0为桌面
            public int wFunc;                    //功能标志 FO_COPY复制 FO_DELETE删除 FO_MOVE移动 FO_RENAME重命名
            public string pFrom;                 //source file源文件或者源文件夹
            public string pTo;                   //destination目的文件或文件夹
            public int fFlags;                   //控制文件的标志位 FOF_ALLOWUNDO 准许撤销 FOF_CONFIRMMOUSE 没有被使用
            public bool fAnyOperationsAborted;
            public int hNameMappings;
            public string lpszProgressTitle;
        }

        //SHFileOperation外壳函数 实现文件操作 参数SHFILEOPSTRUCT结构
        [DllImport("shell32.dll")]
        private static extern int SHFileOperation(ref SHFILEOPSTRUCT FileOp);

        /// <summary>
        /// 删除文件 Delete("c:\\test.txt",true) 把"c:/test.text"删除到回收箱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static int Delete(string sPath, bool recycle)
        {
            SHFILEOPSTRUCT FileOp = new SHFILEOPSTRUCT();
            FileOp.hwnd = 0;
            FileOp.wFunc = FO_DELETE;      //实现操作是删除文件
            FileOp.fFlags = 0;
            FileOp.fFlags = FileOp.fFlags | FOF_SILENT;
            FileOp.fFlags = FileOp.fFlags | FOF_NOCONFIRMATION;
            FileOp.fFlags = FileOp.fFlags | FOF_NOCONFIRMMKDIR;
            if (recycle)
            {
                FileOp.fFlags = FileOp.fFlags | FOF_ALLOWUNDO;
            }
            FileOp.pFrom = sPath + "\0";
            return SHFileOperation(ref FileOp);
        }

        //设置contextMenuStrip1控件中"删除文件"Name为deleteFile
        private void deleteFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //文件没有选中
            if (this.fileslist.SelectedItems.Count == 0)
                return;
            //获取选中文件
            //var selectedItem = this.fileslist.SelectedItems[0];

            //全局变量文件名 SubItems[1]表示文件名
            fileNamePublic = filePathPublic + "\\" + fileName;
            //MessageBox.Show(fileNamePublic);
            try
            {
                if (MessageBox.Show("确认要删除该最近浏览文件信息?", "提示",
                            System.Windows.Forms.MessageBoxButtons.YesNo,
                            System.Windows.Forms.MessageBoxIcon.Question) ==
                            System.Windows.Forms.DialogResult.Yes)
                {
                    //删除文件
                    Delete(fileNamePublic, true);
                    //移除文件
                    foreach (ListViewItem item in this.fileslist.SelectedItems)
                    {
                        this.fileslist.Items.Remove(item);
                    }
                    MessageBox.Show(this, "成功删除了文件！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception msg) //异常处理
            {
                MessageBox.Show(msg.Message);
            }
        }
        #endregion

        private void directoryTree_Click(object sender, EventArgs e)
        {

        }
        /*--------------------------------------------------------------------*/



        private void btn_select_Click(object sender, EventArgs e)
        {

            //tBX_Show.Text = pathName;
            btn_select.Enabled = true;
            fileSystemWatcher.Path = tBX_Show.Text;//这里我们将需要监控的文件夹的路径赋给文件监控控件
            fileSystemWatcher.EnableRaisingEvents = true;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            //tBX_Show.Text = "";
            tBX_control.Text = "";

        }

        private void fileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            tBX_control.AppendText(e.Name + "被删除！");//我们这样就可以把监控到的内容显示在文本框中
                                                    //MessageBox.Show("1");
        }

        private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            tBX_control.AppendText(e.Name + "被创建！");
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            tBX_control.AppendText(e.Name + "被改变！");
        }

        private void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            tBX_control.AppendText(e.Name + "重命名！");
        }

        private void timer_check_Tick(object sender, EventArgs e)
        {
            if (tBX_control.Text == "")
            {
                timer_count_Message.Start();
                MessageBox.Show("There is no change");
            }
            else
            {
                timer_count_Message.Start();
                MessageBox.Show(tBX_control.Text);
            }

        }

        private void btn_counting_Click(object sender, EventArgs e)
        {
            timer_check.Start();
        }

        private void timer_count_Message_Tick(object sender, EventArgs e)
        {
            timer_count_Message.Stop();
            //MessageBox.Show("*****");
            // 向对话框发送按键 Enter
            SendKeys.Send(" "); //模拟键盘输入空格即可关掉当前窗口！！  
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            timer_check.Stop();
        }


    }
}
