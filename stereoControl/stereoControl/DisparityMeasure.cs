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
using System.Threading;

namespace stereoControl
{
    public partial class DisparityMeasure : Form
    {
        //定义变量
        private static StereoBM bmMatch = StereoBM.Create();
        private StereoSGBM sgbmMatch;
        private static Mat tLeftImg = new Mat();
        private static Mat tRightImg = new Mat();
        private static Mat tLeftImg_g = new Mat();
        private static Mat tRightImg_g = new Mat();

        private static Mat bmDisImg = new Mat();
        private Mat bmDisImg_true = new Mat();
        private Mat bmDist8U = new Mat();
        private Mat bmDist24U = new Mat();
        private Mat sgbmDisImg = new Mat();
        //有效视差
        private Rect validDisROI = new Rect();
        //窗体
        private sgbmImgChoose sgbmImgChooseWin;
        private System.Threading.Timer dmTimer;

        //标志位
        private bool BM_IMG_FLAG = false;
        private bool BM_DIS_CAL_FLAG = false;
        private bool IS_SHOW_BM_DISPARITY_FLAG = false;
        private bool IS_ALLOWED_MEASURE = false;
        private bool IS_IMG_SHOW_PAUSE = false;

        //BM算法参数值--参考OpenCV源文档
        private int bm_preFilterSize    = 15;   //5--21，必须奇数
        private int bm_preFilterCap     = 31;   //1--31
        private int bm_SADWinSize       = 15;   //5--21，必须为奇数      
        private int bm_minDisparity     = 0;    //可以为负
        private int bm_numOfDisparities = 64;   //必须为16倍数：16、32、48、64、80.....
        private int bm_uniquenessRatio  = 15;   //5--15,不能为负
        private int bm_textureThreshold = 10;   //不能为负
        private int bm_speckleWinSize   = 100;  //取0则取消检查
        private int bm_speckleRange     = 32;   //视差清0阈值
        private int bm_disp12MaxDiff    = 1;    //左右视差图最大容许差异

        public DisparityMeasure()
        {
            InitializeComponent();
        }
        
        //窗体初始化
        private void DisparityMeasure_Load(object sender, EventArgs e)
        {
            //初始化定时器
            //dmTimer = new System.Threading.Timer(disparitymeTime, null, -1, 50);
            timer_disparityMeasure.Enabled = true;
            timer_disparityMeasure.Stop();
            //计算有效视差区
            //初始化BM参数
            this.ucTrackBar_preFilterSize.Value = bm_preFilterSize;
            this.textBox_preFilterSize.Text = bm_preFilterSize.ToString();
            this.ucTrackBar_preFilterCap.Value = bm_preFilterCap;
            this.textBox_preFilterCap.Text = bm_preFilterCap.ToString();
            this.ucTrackBar_SADWinSize.Value = bm_SADWinSize;
            this.textBox_SADWinSize.Text = bm_SADWinSize.ToString();
            this.ucTrackBar_minDIsparity.Value = bm_minDisparity;
            this.textBox_minDisparity.Text = bm_minDisparity.ToString();
            //16倍倍数关系
            this.ucTrackBar_numOfDis.Value = bm_numOfDisparities/16;
            this.textBox_numOfDis.Text = bm_numOfDisparities.ToString();

            this.ucTrackBar_uniquenessRatio.Value = bm_uniquenessRatio;
            this.textBox_uniquenessRatio.Text = bm_uniquenessRatio.ToString();
            this.ucTrackBar_textureThre.Value = bm_textureThreshold;
            this.textBox_textureThreshold.Text = bm_textureThreshold.ToString();
            this.ucTrackBar_speckleWinSize.Value = bm_speckleWinSize;
            this.textBox_speckleWinSize.Text = bm_speckleWinSize.ToString();
            this.ucTrackBar_speckleRange.Value = bm_speckleRange;
            this.textBox_speckleRange.Text = bm_speckleRange.ToString();
            this.ucTrackBar_disp12MaxDiff.Value = bm_disp12MaxDiff;
            this.textBox_disp12MaxDiff.Text = bm_disp12MaxDiff.ToString();
        }
        //使用Winform定时器
        private void timer_disparityMeasure_Tick(object sender, EventArgs e)
        {
            if (BM_IMG_FLAG)
            {
                //防止垃圾回收器自动回收释放变量
                //GC.KeepAlive(tLeftImg);
                //GC.KeepAlive(tRightImg);
                //GC.KeepAlive(tLeftImg_g);
                //GC.KeepAlive(tRightImg_g);               
                //控制是否从主窗体中读取图像
                if (!IS_IMG_SHOW_PAUSE)
                {
                    tLeftImg = ShareData.LeftImg;
                    tRightImg = ShareData.RightImg;
                }                
                if (BM_DIS_CAL_FLAG && !IS_IMG_SHOW_PAUSE)
                {
                    validDisROI = Cv2.GetValidDisparityROI(ShareData.PixROI1, ShareData.PixROI2, bm_minDisparity, bm_numOfDisparities, bm_SADWinSize);
                    //转换为灰度图
                    Cv2.CvtColor(tLeftImg, tLeftImg_g, ColorConversionCodes.BGR2GRAY);
                    Cv2.CvtColor(tRightImg, tRightImg_g, ColorConversionCodes.BGR2GRAY);
                    //bmDisImg = new Mat(tLeftImg_g.Size(), MatType.CV_16SC1);
                    //BM计算视差图                    
                    bmMatch.Compute(tLeftImg_g, tRightImg_g, bmDisImg);             //计算视差图                                       
                    //转换为真正的视差图
                    bmDisImg.ConvertTo(bmDisImg_true, MatType.CV_8UC1, 255 / (bm_numOfDisparities * 16));
                    //转换为8位图用于显示
                    bmDist8U = new Mat(bmDisImg.Size(), MatType.CV_8UC1);
                    Cv2.Normalize(bmDisImg, bmDist8U, 0, 255, NormTypes.MinMax,0);    //归一化
                    //bmDist24U = new Mat(bmDisImg.Size(), MatType.CV_8UC3);
                    //Cv2.ApplyColorMap(bmDist8U, bmDist24U, ColormapTypes.Rainbow);  //转换为伪彩色图
                }                                
            }
            //控制图像显示            
            if (IS_SHOW_BM_DISPARITY_FLAG)
            {
                Cv2.Rectangle(bmDist8U, validDisROI, new Scalar(255), 1);
                this.pictureBoxIpl_Img.ImageIpl = bmDist8U;
            }
            else
            {
                Cv2.Rectangle(tLeftImg, validDisROI, new Scalar(0, 0, 255), 1);
                this.pictureBoxIpl_Img.ImageIpl = tLeftImg;    //显示左视图
            }

            validDisROI = new Rect();
        }

        private void disparitymeTime(object state)
        {
            if(BM_IMG_FLAG)
            {
                //防止垃圾回收器自动回收释放变量
                GC.KeepAlive(tLeftImg);
                GC.KeepAlive(tRightImg);
                GC.KeepAlive(tLeftImg_g);
                GC.KeepAlive(tRightImg_g);
                GC.KeepAlive(bmDisImg);
                GC.KeepAlive(bmDisImg_true);
                GC.KeepAlive(bmDist8U);
                GC.KeepAlive(bmDist24U);
                GC.KeepAlive(sgbmDisImg);
                //获取图像
                tLeftImg = ShareData.LeftImg;
                tRightImg = ShareData.RightImg;
                if (BM_DIS_CAL_FLAG)
                {
                    //转换为灰度图
                    Cv2.CvtColor(tLeftImg, tLeftImg_g, ColorConversionCodes.BGR2GRAY);
                    Cv2.CvtColor(tRightImg, tRightImg_g, ColorConversionCodes.BGR2GRAY);
                    //bmDisImg = new Mat(tLeftImg_g.Size(), MatType.CV_16SC1);
                    //BM计算视差图                    
                    bmMatch.Compute(tLeftImg_g, tRightImg_g, bmDisImg);             //计算视差图                                       
                    //除16得到真正视差图
                    bmDisImg.ConvertTo(bmDisImg_true, MatType.CV_32FC1, 1.0 / 16);
                    //转换为8位图用于显示
                    bmDist8U = new Mat(bmDisImg.Size(), MatType.CV_8UC1);
                    Cv2.Normalize(bmDisImg, bmDist8U, 0, 255, NormTypes.MinMax, 0);    //归一化
                    //bmDist24U = new Mat(bmDisImg.Size(), MatType.CV_8UC3);
                    //Cv2.ApplyColorMap(bmDist8U, bmDist24U, ColormapTypes.Rainbow);  //转换为伪彩色图
                }
            }            
            //控制图像显示
            if (IS_SHOW_BM_DISPARITY_FLAG)          
            {
                this.pictureBoxIpl_Img.ImageIpl = bmDist8U;    
            }
            else
            {
                this.pictureBoxIpl_Img.ImageIpl = tLeftImg;    //显示左视图
            }

        }
        //显示左相机视图
        private void ucBtnExt_bmImg_BtnClick(object sender, EventArgs e)
        {
            //设置标志位并启动定时器
            BM_IMG_FLAG = true;
            //dmTimer.Change(0, 50);
            timer_disparityMeasure.Start(); //启动winform定时器
            ShareData.Log = "[msg] 左视图显示成功";
        }
        //BM算法视差图计算
        private void ucBtnExt_bmDisCal_BtnClick(object sender, EventArgs e)
        {
            //设置BM参数
            bmMatch.BlockSize         = bm_SADWinSize;
            bmMatch.MinDisparity      = bm_minDisparity;
            bmMatch.NumDisparities    = bm_numOfDisparities;
            bmMatch.UniquenessRatio   = bm_uniquenessRatio;
            bmMatch.Disp12MaxDiff     = bm_disp12MaxDiff;
            bmMatch.SpeckleWindowSize = bm_speckleWinSize;
            bmMatch.SpeckleRange      = bm_speckleRange;
            bmMatch.TextureThreshold  = bm_textureThreshold;
            bmMatch.PreFilterCap      = bm_preFilterCap;
            bmMatch.PreFilterSize     = bm_preFilterSize;           
            bmMatch.ROI1 = ShareData.PixROI1;
            bmMatch.ROI2 = ShareData.PixROI2;
            //设置标志位
            BM_DIS_CAL_FLAG = true;
            IS_ALLOWED_MEASURE = true;
            ShareData.Log = "[msg] BM视差参数设置成功，可以显示并计算像素空间坐标点了~";
        }
        ///BM滑动条事件///////////////////////////
        private void ucTrackBar_preFilterSize_ValueChanged(object sender, EventArgs e)
        {
            this.textBox_preFilterSize.Text = this.ucTrackBar_preFilterSize.Value.ToString();
        }

        private void ucTrackBar_preFilterCap_ValueChanged(object sender, EventArgs e)
        {
            this.textBox_preFilterCap.Text = this.ucTrackBar_preFilterCap.Value.ToString();
        }

        private void ucTrackBar_SADWinSize_ValueChanged(object sender, EventArgs e)
        {
            this.textBox_SADWinSize.Text = this.ucTrackBar_SADWinSize.Value.ToString();
        }
        private void ucTrackBar_minDIsparity_ValueChanged(object sender, EventArgs e)
        {
            this.textBox_minDisparity.Text = this.ucTrackBar_minDIsparity.Value.ToString();
        }
        private void ucTrackBar_numOfDis_ValueChanged(object sender, EventArgs e)
        {
            //16倍倍数关系
            this.textBox_numOfDis.Text = (this.ucTrackBar_numOfDis.Value * 16).ToString();
        }

        private void ucTrackBar_uniquenessRatio_ValueChanged(object sender, EventArgs e)
        {
            this.textBox_uniquenessRatio.Text = this.ucTrackBar_uniquenessRatio.Value.ToString();
        }

        private void ucTrackBar_textureThre_ValueChanged(object sender, EventArgs e)
        {
            this.textBox_textureThreshold.Text = this.ucTrackBar_textureThre.Value.ToString();
        }
        private void ucTrackBar_speckleWinSize_ValueChanged(object sender, EventArgs e)
        {
            this.textBox_speckleWinSize.Text = this.ucTrackBar_speckleWinSize.Value.ToString();
        }

        private void ucTrackBar_speckleRange_ValueChanged(object sender, EventArgs e)
        {
            this.textBox_speckleRange.Text = this.ucTrackBar_speckleRange.Value.ToString();
        }

        private void ucTrackBar_disp12MaxDiff_ValueChanged(object sender, EventArgs e)
        {
            this.textBox_disp12MaxDiff.Text = this.ucTrackBar_disp12MaxDiff.Value.ToString();
        }
        //写入BM参数
        private void ucBtnExt_writeBMParm_BtnClick(object sender, EventArgs e)
        {
            //获取值
            bm_preFilterSize = (int)this.ucTrackBar_preFilterSize.Value;
            bm_preFilterCap = (int)this.ucTrackBar_preFilterCap.Value;
            bm_SADWinSize = (int)this.ucTrackBar_SADWinSize.Value;
            bm_minDisparity = (int)this.ucTrackBar_minDIsparity.Value;
            //16倍倍数关系
            bm_numOfDisparities = (int)(this.ucTrackBar_numOfDis.Value * 16);

            bm_uniquenessRatio = (int)this.ucTrackBar_uniquenessRatio.Value;
            bm_textureThreshold = (int)this.ucTrackBar_textureThre.Value;
            bm_speckleWinSize = (int)this.ucTrackBar_speckleWinSize.Value;
            bm_speckleRange = (int)this.ucTrackBar_speckleRange.Value;
            bm_disp12MaxDiff = (int)this.ucTrackBar_disp12MaxDiff.Value;
            //写入BM对象
            bmMatch.BlockSize = bm_SADWinSize;
            bmMatch.MinDisparity = bm_minDisparity;
            bmMatch.NumDisparities = bm_numOfDisparities;
            bmMatch.UniquenessRatio = bm_uniquenessRatio;
            bmMatch.Disp12MaxDiff = bm_disp12MaxDiff;
            bmMatch.SpeckleWindowSize = bm_speckleWinSize;
            bmMatch.SpeckleRange = bm_speckleRange;
            bmMatch.TextureThreshold = bm_textureThreshold;
            bmMatch.PreFilterCap = bm_preFilterCap;
            bmMatch.PreFilterSize = bm_preFilterSize;
            bmMatch.ROI1 = ShareData.PixROI1;
            bmMatch.ROI2 = ShareData.PixROI2;
            ShareData.Log = "[msg] BM参数写入成功";
        }
        //设置默认参数
        private void ucBtnExt_parmdefault_BtnClick(object sender, EventArgs e)
        {
            this.ucTrackBar_preFilterSize.Value = 15;
            this.ucTrackBar_preFilterCap.Value  = 31;
            this.ucTrackBar_SADWinSize.Value    = 15;
            this.ucTrackBar_minDIsparity.Value  = 0;
            //16倍倍数关系
            this.ucTrackBar_numOfDis.Value = 64/16;

            this.ucTrackBar_uniquenessRatio.Value = 15;
            this.ucTrackBar_textureThre.Value = 10;
            this.ucTrackBar_speckleWinSize.Value = 100;
            this.ucTrackBar_speckleRange.Value = 32;
            this.ucTrackBar_disp12MaxDiff.Value = 1;
            ShareData.Log = "[msg] 设置默认参数成功";
        }
        //BM切换画面  ， 在视差图与左相机视图之间切换
        private void ucBtnExt_bmchangeImg_BtnClick(object sender, EventArgs e)
        {
            if (!IS_SHOW_BM_DISPARITY_FLAG)
            {
                IS_SHOW_BM_DISPARITY_FLAG = true;
            }
            else
            {
                IS_SHOW_BM_DISPARITY_FLAG = false;
            }
        }
        //暂停当前图像显示
        private void ucBtnExt_pause_BtnClick(object sender, EventArgs e)
        {
            if(!IS_IMG_SHOW_PAUSE)
            {
                IS_IMG_SHOW_PAUSE = true;
                ShareData.Log = "[msg] 图像显示已暂停";
            }
            else
            {
                ShareData.Log = "[msg] 图像显示已暂停";
            }
        }
        //重启当前图像显示
        private void ucBtnExt_restart_BtnClick(object sender, EventArgs e)
        {
            if(IS_IMG_SHOW_PAUSE)
            {
                IS_IMG_SHOW_PAUSE = false;
                ShareData.Log = "[msg] 图像显示已启动";
            }
            else
            {
                ShareData.Log = "[msg] 图像显示已启动";
            }
        }
        //视差图鼠标点击测量
        private void pictureBoxIpl_Img_MouseDown(object sender, MouseEventArgs e)
        {
            //ShareData.Log = "(" + e.X.ToString() + " , " + e.Y.ToString() + ")";
            if(IS_ALLOWED_MEASURE)
            {
                //获取鼠标处（x,y,d）值
                //Mat imgPoint = new Mat(3, 1, MatType.CV_32FC1);
                //var imgIndexer = imgPoint.GetGenericIndexer<float>();
                //imgIndexer[0, 0] = e.X;
                //imgIndexer[1, 0] = e.Y;
                //imgIndexer[2, 0] = bmDisImg_true.Get<float>(e.Y, e.X);
                //存储鼠标点三维坐标
                Point3f xyzP = new Point3f();
                Mat _3DImage = new Mat();
                Cv2.ReprojectImageTo3D(bmDisImg, _3DImage, ShareData.Q, true, -1);
                var _3DImgIndexer = _3DImage.GetGenericIndexer<Vec3f>();
                //_3DImage = _3DImage * 16;           //真实视差值
                //转换空间点坐标
                Vec3f temp = _3DImgIndexer[e.Y, e.X];
                xyzP.X = temp.Item0 * 16;             //转换真实视差值
                xyzP.Y = temp.Item1 * 16;
                xyzP.Z = temp.Item2 * 16;
                if(xyzP.Z == 160000)
                {
                    ShareData.Log = "像素坐标：(" + e.X.ToString() + " , " + e.Y.ToString() + ")深度测量失败~，请重新选择像素点";
                    this.textBox_xpos.ForeColor = Color.Red;
                    this.textBox_ypos.ForeColor = Color.Red;
                    this.textBox_zpos.ForeColor = Color.Red;
                    this.textBox_xpos.Text = xyzP.X.ToString();
                    this.textBox_ypos.Text = xyzP.Y.ToString();
                    this.textBox_zpos.Text = xyzP.Z.ToString();
                }
                else
                {
                    ShareData.Log = "像素坐标：(" + e.X.ToString() + " , " + e.Y.ToString() + ")对应的空间坐标为" + xyzP.X.ToString()
                                + " , " + xyzP.Y.ToString() + " , " + xyzP.Z.ToString() + ")";
                    this.textBox_xpos.ForeColor = Color.Black;
                    this.textBox_ypos.ForeColor = Color.Black;
                    this.textBox_zpos.ForeColor = Color.Black;
                    this.textBox_xpos.Text = xyzP.X.ToString();
                    this.textBox_ypos.Text = xyzP.Y.ToString();
                    this.textBox_zpos.Text = xyzP.Z.ToString();
                }                               
            }
        }
        //选择加载SGBM计算图像
        private void ucBtnExt_sgbmLoadImg_BtnClick(object sender, EventArgs e)
        {
            sgbmImgChooseWin = GenericSingleton<sgbmImgChoose>.CreateInstance();
            sgbmImgChooseWin.StartPosition = FormStartPosition.CenterParent;
            if(sgbmImgChooseWin.ShowDialog()== DialogResult.OK)
            {
                //加载显示图像
                string leftImg_ = sgbmImgChooseWin.LeftImgpath;
                string RightImg_ = sgbmImgChooseWin.RightImgPath;
                Console.WriteLine("left:" + leftImg_);
                Console.WriteLine("right:" + RightImg_);
                //释放窗体资源
                sgbmImgChooseWin.Close();
            }
        }
    }
}

//图像像素操作、注意: 先y(row)后x(col)
//注意：  这里需要保证数据类型相同，必须为CV_64FC1类型，因为ShareData.Q为CV_64FC1
//Mat imgPoint = new Mat(4, 1, MatType.CV_64FC1);
//Mat objPoint = new Mat(4, 1, MatType.CV_64FC1);
//Point3d xyzP = new Point3d();
//var imgIndexer = imgPoint.GetGenericIndexer<double>();
//var objIndexer = imgPoint.GetGenericIndexer<double>();
////设置矩阵元素
//imgIndexer[0, 0] = e.X;
//imgIndexer[1, 0] = e.Y;                
//imgIndexer[2, 0] = bmDisImg_true.Get<float>(e.Y, e.X);
//imgIndexer[3, 0] = 1;
//像素坐标重映射计算(左乘)
//objPoint = ShareData.Q * imgPoint;
//objIndexer[0, 0] = ShareData.Q.Get<double>(0, 0) * imgIndexer[0, 0] + ShareData.Q.Get<double>(0, 1) * imgIndexer[1, 0]
//                   + ShareData.Q.Get<double>(0, 2) * imgIndexer[2, 0] + ShareData.Q.Get<double>(0, 3) * imgIndexer[3, 0];
//objIndexer[1, 0] = ShareData.Q.Get<double>(1, 0) * imgIndexer[0, 0] + ShareData.Q.Get<double>(1, 1) * imgIndexer[1, 0]
//                   + ShareData.Q.Get<double>(1, 2) * imgIndexer[2, 0] + ShareData.Q.Get<double>(1, 3) * imgIndexer[3, 0];
//objIndexer[2, 0] = ShareData.Q.Get<double>(2, 0) * imgIndexer[0, 0] + ShareData.Q.Get<double>(2, 1) * imgIndexer[1, 0]
//                   + ShareData.Q.Get<double>(2, 2) * imgIndexer[2, 0] + ShareData.Q.Get<double>(2, 3) * imgIndexer[3, 0];
//objIndexer[3, 0] = ShareData.Q.Get<double>(3, 0) * imgIndexer[0, 0] + ShareData.Q.Get<double>(3, 1) * imgIndexer[1, 0]
//                   + ShareData.Q.Get<double>(3, 2) * imgIndexer[2, 0] + ShareData.Q.Get<double>(3, 3) * imgIndexer[3, 0];
//xyzP.X = objIndexer[0, 0] / objIndexer[3, 0];
//xyzP.Y = objIndexer[1, 0] / objIndexer[3, 0];
//xyzP.Z = objIndexer[2, 0] / objIndexer[3, 0];