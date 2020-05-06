using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;

namespace stereoControl
{
    public partial class ImageProcess : Form
    {
        //定义变量
        private Mat srcImg = new Mat();
        private string strpath_Img = null;

        public ImageProcess()
        {
            InitializeComponent();
        }
        //初始化相关变量
        private void ImageProcess_Load(object sender, EventArgs e)
        {
            this.openFileDialog.Title = "请选择图像处理使用图片";
            this.openFileDialog.Filter = "jpg file|*.jpg|bmp file|*.bmp";
            this.openFileDialog.FilterIndex = 1;
            this.openFileDialog.RestoreDirectory = true;
        }
        //加载图像显示
        private void ucBtnExt_load_BtnClick(object sender, EventArgs e)
        {
            if(this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strpath_Img = this.openFileDialog.FileName;
                //读入图像
                srcImg = Cv2.ImRead(strpath_Img, ImreadModes.Color);
                //显示图像
                this.pictureBoxIpl_img.ImageIpl = srcImg;
                ShareData.Log = "[msg] 图像显示成功";
            }
            else
            {
                ShareData.Log = "[msg] 请选择图像~";
            }
        }
        //关闭图像显示
        private void ucBtnExt_close_BtnClick(object sender, EventArgs e)
        {
            //清空图像显示
            this.pictureBoxIpl_img.Image = null;
        }
        
    }
}
