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
        private StereoBM bmMatch;
        private StereoSGBM sgbmMatch;
        private Mat tLeftImg = new Mat();
        private Mat tRightImg = new Mat();
        private Mat tLeftImg_g = new Mat();
        private Mat tRightImg_g = new Mat();

        private Mat bmDisImg = new Mat();
        private Mat bmDisImg_true = new Mat();
        private Mat bmDist8U = new Mat();
        private Mat bmDist24U = new Mat();
        private Mat sgbmDisImg = new Mat();

        private System.Threading.Timer dmTimer;

        //标志位
        private bool BM_IMG_FLAG = false;
        private bool BM_DIS_CAL_FLAG = false;

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
            dmTimer = new System.Threading.Timer(disparitymeTime, null, -1, 500);
            //初始化BM
            bmMatch = StereoBM.Create();
            //初始化BM参数
            this.ucTrackBar_preFilterSize.Value = bm_preFilterSize;
            this.textBox_preFilterSize.Text = bm_preFilterSize.ToString();
            this.ucTrackBar_preFilterCap.Value = bm_preFilterCap;
            this.textBox_preFilterCap.Text = bm_preFilterCap.ToString();
            this.ucTrackBar_SADWinSize.Value = bm_SADWinSize;
            this.textBox_SADWinSize.Text = bm_SADWinSize.ToString();
            this.ucTrackBar_minDIsparity.Value = bm_minDisparity;
            this.textBox_minDisparity.Text = bm_minDisparity.ToString();
            this.ucTrackBar_numOfDis.Value = bm_numOfDisparities;
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

        private void disparitymeTime(object state)
        {
            if(BM_IMG_FLAG)
            {
                //获取图像
                tLeftImg = ShareData.LeftImg;
                tRightImg = ShareData.RightImg;
            }
            if(BM_DIS_CAL_FLAG)
            {
                Cv2.CvtColor(tLeftImg, tLeftImg_g, ColorConversionCodes.BGR2GRAY);
                Cv2.CvtColor(tRightImg, tRightImg_g, ColorConversionCodes.BGR2GRAY);
                bmMatch.Compute(tLeftImg_g, tRightImg_g, bmDisImg);          //计算视差图
                bmDisImg.ConvertTo(bmDisImg_true, MatType.CV_32FC1, 1.0 / 16);  //除16得到真正视差图
                bmDist8U = new Mat(bmDisImg.Size(), MatType.CV_8UC1);
                bmDist24U = new Mat(bmDisImg.Size(), MatType.CV_8UC3);
                Cv2.Normalize(bmDisImg, bmDist8U, 0, 255, NormTypes.MinMax,0);  //归一化
                Cv2.ApplyColorMap(bmDist8U, bmDist24U, ColormapTypes.Rainbow);      //转换为伪彩色图
            }
            if(BM_DIS_CAL_FLAG)
            {
                this.pictureBoxIpl_Img.ImageIpl = bmDist24U;    //显示伪彩色图
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
            dmTimer.Change(0, 50);
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
            BM_DIS_CAL_FLAG = true;
            ShareData.Log = "[msg] BM视差正在计算";
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
            this.textBox_numOfDis.Text = this.ucTrackBar_numOfDis.Value.ToString();
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
            bm_preFilterSize = (int)this.ucTrackBar_preFilterSize.Value;
            bm_preFilterCap = (int)this.ucTrackBar_preFilterCap.Value;
            bm_SADWinSize = (int)this.ucTrackBar_SADWinSize.Value;
            bm_minDisparity = (int)this.ucTrackBar_minDIsparity.Value;
            bm_numOfDisparities = (int)this.ucTrackBar_numOfDis.Value;
            bm_uniquenessRatio = (int)this.ucTrackBar_uniquenessRatio.Value;
            bm_textureThreshold = (int)this.ucTrackBar_textureThre.Value;
            bm_speckleWinSize = (int)this.ucTrackBar_speckleWinSize.Value;
            bm_speckleRange = (int)this.ucTrackBar_speckleRange.Value;
            bm_disp12MaxDiff = (int)this.ucTrackBar_disp12MaxDiff.Value;
            ShareData.Log = "[msg] BM参数写入成功";
        }
        //设置默认参数
        private void ucBtnExt_parmdefault_BtnClick(object sender, EventArgs e)
        {
            this.ucTrackBar_preFilterSize.Value = 15;
            this.ucTrackBar_preFilterCap.Value  = 31;
            this.ucTrackBar_SADWinSize.Value    = 15;
            this.ucTrackBar_minDIsparity.Value  = 0;
            this.ucTrackBar_numOfDis.Value = 64;
            this.ucTrackBar_uniquenessRatio.Value = 15;
            this.ucTrackBar_textureThre.Value = 10;
            this.ucTrackBar_speckleWinSize.Value = 100;
            this.ucTrackBar_speckleRange.Value = 32;
            this.ucTrackBar_disp12MaxDiff.Value = 1;
            ShareData.Log = "[msg] 设置默认参数成功";
        }
    }
}