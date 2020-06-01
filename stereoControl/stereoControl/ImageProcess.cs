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
        //定义窗体
        private loadimage lloadimg;
        //定义变量
        private Mat srcImg = new Mat();
        private Mat beifenImg = new Mat();
        private string strImgpath = null;
        private int medKSize = 5;
        private string imgProLog = null;
        private string newLog = null;

        private Mat hsvImg = new Mat();
        //苹果HSV颜色特征
        double apple_h_min_1 = 160, apple_s_min = 130, apple_v_min = 90;
        double apple_h_max_1 = 180, apple_s_max = 255, apple_v_max = 255;
        double apple_h_min_2 = 0, apple_h_max_2 = 10;
        //梨子HSV颜色特征
        double pear_h_min = 20, pear_s_min = 43, pear_v_min = 110;
        double pear_h_max = 30, pear_s_max = 255, pear_v_max = 255;        

        private Mat apple_1 = new Mat();
        private Mat apple_2 = new Mat();
        private Mat apple_mask = new Mat();
        private Mat pear_mask = new Mat();
        private Mat fruit_mask = new Mat();
        private Mat background_mask;
        //边缘检测      
        OpenCvSharp.Point[][] apple_contours;
        HierarchyIndex[] apple_hierarchy;
        OpenCvSharp.Point[][] pear_contours;
        HierarchyIndex[] pear_hierarchy;

        private Rect apple_rect = new Rect();
        private Rect pear_rect = new Rect();
        private OpenCvSharp.Point apple_center = new OpenCvSharp.Point();
        private OpenCvSharp.Point pear_center = new OpenCvSharp.Point();
        private Moments apple_moment;
        private Moments pear_moment;
        string apple_coordinate = null, pear_coordinate = null;
        private Mat resultImage = new Mat();

        private OpenCvSharp.Point[]

        public ImageProcess()
        {
            InitializeComponent();
        }
        //初始化相关变量
        private void ImageProcess_Load(object sender, EventArgs e)
        {
            //启动定时器
            this.timer1.Start();
        }
        //显示目标识别结果
        private void ucBtnExt_A5_BtnClick(object sender, EventArgs e)
        {
            //计算最小外接矩形
            apple_rect = Cv2.BoundingRect(apple_contours[0]);
            for(int i = 0; i < pear_contours.Length; i++)
            {
                if (Cv2.ArcLength(pear_contours[i], true) > 40)   //轮廓周长大于40时绘制
                {
                    pear_rect = Cv2.BoundingRect(pear_contours[i]);
                }
            }
            //绘制结果
            beifenImg.CopyTo(resultImage);
            Cv2.Rectangle(resultImage, apple_rect, new Scalar(255, 0, 0), 2);
            Cv2.Rectangle(resultImage, pear_rect, new Scalar(255, 0, 0), 2);
            Cv2.Circle(resultImage, apple_center, 7, new Scalar(0, 0, 0), -1);
            Cv2.Circle(resultImage, pear_center, 7, new Scalar(0, 0, 0), -1);
            this.pictureBoxIpl_img.ImageIpl = resultImage;
            newLog = "[msg] 目标识别成功~";
        }

        //加载图像
        private void ucBtnExt_load_BtnClick(object sender, EventArgs e)
        {
            lloadimg = GenericSingleton<loadimage>.CreateInstance();
            if(lloadimg.ShowDialog()==DialogResult.OK)
            {
                //获取文件路径
                strImgpath = lloadimg.Imgpath;
                //读取图像 一定要选择校正后的图像
                srcImg = Cv2.ImRead(strImgpath, ImreadModes.Color);
                //备份
                srcImg.CopyTo(beifenImg);
                //显示图像
                this.pictureBoxIpl_img.ImageIpl = srcImg;
                newLog = "[msg] 图像加载成功";
            }
        }
        //关闭图像
        private void ucBtnExt_close_BtnClick(object sender, EventArgs e)
        {
            //清空图像显示
            this.pictureBoxIpl_img.Image = null;
            newLog = "[msg] 图像显示关闭";
        }
        //控制是否使用图像滤波
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //当有图片显示时这样显示
            if(this.pictureBoxIpl_img.Image != null)
            {
                if(this.radioButton1.Checked)           //不滤波
                {
                    srcImg = beifenImg;
                    this.pictureBoxIpl_img.ImageIpl = srcImg;
                    newLog = "[msg] 图像未使用滤波";
                }
                else if(this.radioButton2.Checked)    //中值滤波
                {
                    medKSize = int.Parse(this.textBox1.Text);
                    Cv2.MedianBlur(srcImg, srcImg, medKSize);
                    this.pictureBoxIpl_img.ImageIpl = srcImg;
                    newLog = "[msg] 图像使用中值滤波，中值滤波核为5";
                }
                else { }
            }
            else
            {
            }
        }
        //更新图像处理Log   100ms1次
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(imgProLog != newLog)
            {
                //更新Log
                imgProLog = newLog;
                //追加文本
                this.richTextBox1.AppendText(imgProLog + "\r\n");
            }
        }
        //自动定位Log最底部
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }
        //图像分割
        private void ucBtnExt_A1_BtnClick(object sender, EventArgs e)
        {
            Scalar apple_hsv_min_1 = new Scalar(apple_h_min_1, apple_s_min, apple_v_min);
            Scalar apple_hsv_max_1 = new Scalar(apple_h_max_1, apple_s_max, apple_v_max);
            Scalar apple_hsv_min_2 = new Scalar(apple_h_min_2, apple_s_min, apple_v_min);
            Scalar apple_hsv_max_2 = new Scalar(apple_h_max_2, apple_s_max, apple_v_max);

            Scalar pear_hsv_min = new Scalar(pear_h_min, pear_s_min, pear_v_min);
            Scalar pear_hsv_max = new Scalar(pear_h_max, pear_s_max, pear_v_max);

            Cv2.CvtColor(srcImg, hsvImg, ColorConversionCodes.BGR2HSV);
            this.pictureBoxIpl_img.ImageIpl = hsvImg;
            //输出Log
            newLog = "[msg] 显示HSV图像";
            //等待1s
            Cv2.WaitKey(1000);
            //计算苹果掩膜
            Cv2.InRange(hsvImg, apple_hsv_min_1, apple_hsv_max_1, apple_1);
            Cv2.InRange(hsvImg, apple_hsv_min_2, apple_hsv_max_2, apple_2);
            //合并掩膜
            Cv2.Add(apple_1, apple_2, apple_mask);
            //膨胀腐蚀
            Mat apple_element = Cv2.GetStructuringElement(MorphShapes.Rect,
                            new OpenCvSharp.Size(3, 3), new OpenCvSharp.Point(-1, -1));
            Cv2.Dilate(apple_mask, apple_mask, apple_element, new OpenCvSharp.Point(-1, -1), 1);
            Cv2.Erode(apple_mask, apple_mask, apple_element, new OpenCvSharp.Point(-1, -1), 1);
            //计算梨子掩膜
            Cv2.InRange(hsvImg, pear_hsv_min, pear_hsv_max, pear_mask);
            //膨胀腐蚀   注意核大小取值
            Mat pear_element_erode = Cv2.GetStructuringElement(MorphShapes.Rect,
                            new OpenCvSharp.Size(7, 7), new OpenCvSharp.Point(-1, -1));
            Mat pear_element_dilate = Cv2.GetStructuringElement(MorphShapes.Rect,
                            new OpenCvSharp.Size(7, 7), new OpenCvSharp.Point(-1, -1));
            Cv2.Erode(pear_mask, pear_mask, pear_element_erode, new OpenCvSharp.Point(-1, -1), 1);
            Cv2.Dilate(pear_mask, pear_mask, pear_element_dilate, new OpenCvSharp.Point(-1, -1), 1);
            Cv2.Add(apple_mask, pear_mask, fruit_mask);
            //显示图像分割效果
            this.pictureBoxIpl_img.ImageIpl = fruit_mask;
            //输出日志
            newLog = "[msg] 图像分割完毕";

        }
        //边缘检测
        private void ucBtnExt_A2_BtnClick(object sender, EventArgs e)
        {
            //提取苹果轮廓
            Cv2.FindContours(apple_mask, out apple_contours, out apple_hierarchy,
                RetrievalModes.External, ContourApproximationModes.ApproxNone);
            background_mask = new Mat(fruit_mask.Size(), MatType.CV_8UC1,new Scalar(0));
            //绘制苹果轮廓
            Cv2.DrawContours(background_mask, apple_contours, -1, new Scalar(255), 2,
                LineTypes.Link8, apple_hierarchy);
            //提取梨子轮廓
            Cv2.FindContours(pear_mask, out pear_contours, out pear_hierarchy, RetrievalModes.External,
                ContourApproximationModes.ApproxNone);
            //绘制梨子轮廓
            for(int i = 0; i < pear_contours.Length; i++)
            {
                if(Cv2.ArcLength(pear_contours[i],true) > 40)   //轮廓周长大于40时绘制
                {
                    Cv2.DrawContours(background_mask, pear_contours, i, new Scalar(255), 2, LineTypes.Link8,
                        pear_hierarchy);
                }
            }
            this.pictureBoxIpl_img.ImageIpl = background_mask;
            //输出日志
            newLog = "[msg] 边缘检测完毕";
        }        
        //目标质心坐标点计算
        private void ucBtnExt_A4_BtnClick(object sender, EventArgs e)
        {
            //计算苹果质心
            apple_moment = Cv2.Moments(apple_contours[0]);
            apple_center.X = (int)(apple_moment.M10 / apple_moment.M00);
            apple_center.Y = (int)(apple_moment.M01 / apple_moment.M00);
            //绘制出来
            Cv2.Circle(background_mask, apple_center, 3, new Scalar(255), -1);
            //计算梨子质心
            for(int i = 0; i < pear_contours.Length; i++)
            {
                if (Cv2.ArcLength(pear_contours[i], true) > 40)   //轮廓周长大于40时计算
                {
                    pear_moment = Cv2.Moments(pear_contours[i]);
                    pear_center.X = (int)(pear_moment.M10 / pear_moment.M00);
                    pear_center.Y = (int)(pear_moment.M01 / pear_moment.M00);
                    //绘制出来
                    Cv2.Circle(background_mask, pear_center, 3, new Scalar(255), -1);
                }
            }
            this.pictureBoxIpl_img.ImageIpl = background_mask;
            //输出日志
            newLog = "[msg] 苹果在图像中的质心：(" + apple_center.X.ToString() + ","
                      + apple_center.Y.ToString() + "), " + "梨子在图像中的质心：("
                      + pear_center.X.ToString() + "," + pear_center.Y.ToString() + ")";
        }
        //轮廓像素坐标点计算
        private void ucBtnExt_A3_BtnClick(object sender, EventArgs e)
        {            
            //输出苹果所有像素坐标点
            for(int i = 0; i < apple_contours[0].Length;i++)
            {
                apple_coordinate += " (" + apple_contours[0][i].X.ToString() + ","
                                    + apple_contours[0][i].Y.ToString() + "), ";
            }
            //存储苹果二维坐标点
            ShareData.Apple_contour = apple_contours[0];
            newLog = "[msg] 苹果所有轮廓坐标点：" + apple_coordinate;
            Cv2.WaitKey(200);
            //输出梨子所有像素坐标点
            for (int i = 0; i < pear_contours.Length; i++)
            {
                //轮廓周长大于40时计算
                if (Cv2.ArcLength(pear_contours[i],true) > 40)
                {
                    for(int j = 0; j < pear_contours[i].Length; j++)
                    {
                        pear_coordinate += " (" + pear_contours[i][j].X.ToString() + ","
                                   + pear_contours[i][j].Y.ToString() + ") ";
                    }
                    //存储梨子二维坐标点
                    ShareData.Pear_contour = pear_contours[i];
                }
            }
            newLog = "[msg] 梨子所有轮廓坐标点：" + pear_coordinate;
           
        }
    }
}
