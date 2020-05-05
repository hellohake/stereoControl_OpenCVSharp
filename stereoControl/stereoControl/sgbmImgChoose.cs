using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stereoControl
{
    public partial class sgbmImgChoose : Form
    {
        //定义变量
        private string leftImgpath = null;
        private string rightImgpath = null;
        //定义属性返回值
        public string LeftImgpath
        {
            get
            {
                return leftImgpath;
            }
        }
        public string RightImgPath
        {
            get
            {
                return rightImgpath;
            }
        }
        public sgbmImgChoose()
        {
            InitializeComponent();
        }
        private void sgbmImgChoose_Load(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "jpg file|*.jpg|bmp file|*.bmp";
            this.openFileDialog1.FilterIndex = 1;
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.CheckFileExists = true;
            this.openFileDialog1.CheckPathExists = true;
        }
        //获取左相机图片文件路径
        private void leftImgBrowse_Btn_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "请选择左相机拍摄图片";
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.leftImgpath = this.openFileDialog1.FileName;
                this.textBox_leftImg.Text = this.openFileDialog1.FileName;
                ShareData.Log = "[msg] 左相机图片加载成功";
            }
            else
            {
            }
        }
        //获取右相机图片文件路径
        private void rightImgBrowse_Btn_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Title = "请选择右相机拍摄图片";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.rightImgpath = this.openFileDialog1.FileName;
                this.textBox_rightImg.Text = this.openFileDialog1.FileName;
                ShareData.Log = "[msg] 右相机图片加载成功";
            }
            else
            {
            }
        }
        //OK
        private void btn_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        //Cancel
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }       
    }
}
