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

namespace rename
{
    public partial class form_main : Form
    {
        public form_main()
        {
            InitializeComponent();
        }

        private void btn_selectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择需要批量序号命名的所在文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                String path = dialog.SelectedPath;
                txtBox_showPath.Text = path;
            }
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            String prefix = txtBox_prefix.Text.ToString();
            int beginNumber = int.Parse(txtxBox_beginNumber.Text.ToString());
            bool beginchecked = radioBtn_begin.Checked;
            bool endChecked = radioBtn_end.Checked;
            bool backup = chkBox_isBack.Checked; //是否备份

            string dir = txtBox_showPath.Text;

            string listShowStates = "";
            richTxtBox_result.Text = listShowStates;

            if (dir.Trim(" ".ToCharArray()).Equals(""))
            {
                MessageBox.Show(this, "文件夹不能为空,请重新选择", "提示");
                return;
            }

            //找到目录
            DirectoryInfo mainDirInfo = new DirectoryInfo(dir);
            if (!mainDirInfo.Exists)
            {
                MessageBox.Show(this, "文件夹不存在,请重新选择", "提示");
                return;
            }
            string parentDir = mainDirInfo.Parent.FullName.ToString();
            string backupDir = Path.Combine(parentDir, mainDirInfo.Name + "_backup");
            DirectoryInfo backupDirInfo = new DirectoryInfo(backupDir);
            if (backup)
            {//若备份 创建备份目录
                if (!backupDirInfo.Exists)
                {
                    Directory.CreateDirectory(backupDir);
                }
            }

            int i = beginNumber; //设置起始数字
            int count = 1;
            string oldNameNoExtension = txtBox_mainName.Text;
            //读取当前目录文件信息
            foreach (var item in mainDirInfo.GetFiles())
            {
                //备份源文件到backup文件夹
                string origin = item.FullName;
                string backupPath = Path.Combine(backupDirInfo.FullName, item.Name);
                File.Copy(origin, backupPath, true);

                if (oldNameNoExtension.Equals("文件主名"))
                {
                    oldNameNoExtension = Path.GetFileNameWithoutExtension(item.FullName);
                }
   
                string newNameNoExtension = getNewName(oldNameNoExtension,i);
                string newName = newNameNoExtension + item.Extension;
                string destPath = Path.Combine(dir, newName);
                listShowStates += showPath(destPath,count);
                //判断是否重名
                if (!File.Exists(destPath))
                {
                    item.MoveTo(destPath);
                }
                
                i++;
                count++;
                richTxtBox_result.Text = listShowStates;
            }
            MessageBox.Show(this, "转换完成", "提示");
        }

        private void copyDir(DirectoryInfo origin,DirectoryInfo dest) {

        }
        private string previecChanged()
        {
            string oldNameNoExtension = txtBox_mainName.Text;
            if (oldNameNoExtension.Trim(" ".ToCharArray()).Equals(""))
                oldNameNoExtension = "文件主名";
            lbl_showPreview.Text = getNewName(oldNameNoExtension);
            string newName = lbl_showPreview.Text;
            return newName;
        }
        private string getNewName(string oldNameNoExtension, int num = -1) {
            string newName = "";
            string prefix = txtBox_prefix.Text.ToString();
            int beginNumber = int.Parse(txtxBox_beginNumber.Text.ToString());
            if (num != -1)
                beginNumber = num;
            string split = txtBox_split.Text;
            bool beginchecked = radioBtn_begin.Checked;
            bool endChecked = radioBtn_end.Checked;
            if (beginchecked)
            {
                if (prefix.Equals(""))
                {
                    newName = beginNumber + split + oldNameNoExtension;
                }
                else
                {
                    newName = txtBox_prefix.Text + split + beginNumber + split + oldNameNoExtension;
                }
            }
            else
            {
                if (prefix.Equals(""))
                {
                    newName = oldNameNoExtension + split + beginNumber;
                }
                else
                {
                    newName = oldNameNoExtension + split + txtBox_prefix.Text + split + beginNumber;
                }
            }
            //newName = lbl_showPreview.Text;
            return newName;
        }
        private string showPath(string destPath,int num) {
            return  "文件序号"+num+"---"+destPath + "\n";
        }


        private void txtBox_prefix_TextChanged(object sender, EventArgs e)
        {
            previecChanged();
        }

        private void txtxBox_beginNumber_ValueChanged(object sender, EventArgs e)
        {
            previecChanged();
        }

        private void txtBox_split_TextChanged(object sender, EventArgs e)
        {
            previecChanged();
        }

        private void radioBtn_begin_CheckedChanged(object sender, EventArgs e)
        {
            previecChanged();
        }

        private void radioBtn_end_CheckedChanged(object sender, EventArgs e)
        {
            previecChanged();
        }
    }
}
