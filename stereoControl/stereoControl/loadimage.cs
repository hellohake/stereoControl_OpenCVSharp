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
    public partial class loadimage : Form
    {
        //定义变量
        private string imgPath = null;       
        //定义属性返回值
        public string Imgpath
        {
            get
            {
                return imgPath;
            }
        }
        public loadimage()
        {
            InitializeComponent();
        }
        //初始化相关参数
        private void loadimage_Load(object sender, EventArgs e)
        {
            this.openFileDialog_img.Filter = "jpg file|*.jpg|bmp file|*.bmp";
            this.openFileDialog_img.FilterIndex = 1;
            this.openFileDialog_img.RestoreDirectory = true;
            this.openFileDialog_img.CheckFileExists = true;
            this.openFileDialog_img.CheckPathExists = true;
        }
        //弹出文件选择对话框选择图像
        private void imgchoose_Btn_Click(object sender, EventArgs e)
        {
            this.openFileDialog_img.Title = "请选择用于目标识别实验的图片";
            if (this.openFileDialog_img.ShowDialog() == DialogResult.OK)
            {
                this.imgPath = this.openFileDialog_img.FileName;
                this.textBox_Img.Text = this.openFileDialog_img.FileName;
                ShareData.Log = "[msg] 目标识别实验图片加载成功";
            }
            else
            {
            }
        }
        //自动定位至末尾
        private void textBox_Img_TextChanged(object sender, EventArgs e)
        {
            this.textBox_Img.Select(this.textBox_Img.TextLength, 0);
            this.textBox_Img.ScrollToCaret();
        }
        //OK
        private void OKBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        //Cancel
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
