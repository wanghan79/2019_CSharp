using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveFile.Models
{
    class FrmFileOperation
    {
        /// <summary>
        /// 打开文件夹并选择其中的某些文件，返回选中文件的名称
        /// </summary>
        /// <returns></returns>
        public string path { get; set; }//存储选中文件夹的路径
        public List<string> OpenFilePath = new List<string>();//存储文件名称
        private string openpath;
        private string savepath;
        public bool OpenFolder()
        {
            OpenFileDialog opFDag = new OpenFileDialog
            {
                Multiselect = true
            };
            opFDag.ShowDialog();
            
            if (opFDag.FileName.Length == 0)
            {
                return false;
            }
            openpath = opFDag.FileName.Substring(0, opFDag.FileName.LastIndexOf("\\"));
            foreach (string file in opFDag.FileNames)
            {
                //string strFileName = file.Substring(file.LastIndexOf("\\") + 1, file.Length - file.LastIndexOf("\\") - 1);
                OpenFilePath.Add(file);//循环的加入取得的文件名称
            }
            return true;
        }

        /// <summary>
        /// 将取得文件存入到
        /// </summary>
        public bool SaveFile()
        {
            //List<string> SaveFilePath = new List<string>();
            SaveFileDialog SaveFD = new SaveFileDialog();

            if (SaveFD.ShowDialog() == DialogResult.Cancel)
            {
                return false;//判断是否点击保存按钮
            }
            String dir = SaveFD.FileName;
            savepath = dir;
            System.IO.Directory.CreateDirectory(dir);
             foreach (string file in OpenFilePath)
             {
                string strFileName = file.Substring(file.LastIndexOf("\\") +
                    1, file.Length - file.LastIndexOf("\\") - 1);
                 System.IO.File.Copy(file,dir+"\\"+strFileName);

             }
            return true;
        }
        public string openFilelabel()
        {
            string LabelOpen = "你打开了文件夹"+openpath+"下的：\n\n";
            int count = 0;
            foreach(string file in OpenFilePath)
            {
                count++;
                string strFileName = file.Substring(file.LastIndexOf("\\") +
                    1, file.Length - file.LastIndexOf("\\") - 1);
                LabelOpen += "第"+count+"个文件:"+strFileName + "\n"+"\n";
            }
            LabelOpen += "一共" + count + "个文件";
            return LabelOpen;
        }
        public string SaveFilelabel()
        {
            string LabelSave = "你将以下文件存在了" + savepath + "下：\n\n";
            int count = 0;
            foreach (string file in OpenFilePath)
            {
                count++;
                string strFileName = file.Substring(file.LastIndexOf("\\") +
                    1, file.Length - file.LastIndexOf("\\") - 1);
                LabelSave += "第" + count + "个文件:" + strFileName + "\n" + "\n";
            }
            LabelSave += "一共" + count + "个文件";
            return LabelSave;
        }
    }
   
}
