using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;                  //添加命名空间
using HZH_Controls.Forms;
using HZH_Controls.Controls;
using System.Threading;
using System.IO;

namespace stereoControl
{
    public partial class Form1 : Form
    {
        //定义变量
        private VideoCapture cap;
        private int camIndex = 1;
        private System.Threading.Timer camTim;
        private Mat comImg = new Mat();
        private Mat leftImg = new Mat();
        private Mat rightImg = new Mat();
        //标志位
        private bool IS_DOUBLECAM_OPEN = false;
        private bool IS_DOUBLECAM_PAUSE = false;
        private bool IS_SHOW_RECTIFYIMAGE = false;
        private bool IS_SHOW_RECTIFYLINE = false;
        private bool IS_READPARM = false;
        //窗体
        private LogView logWin;
        private Settings settingWin;
        private DisparityMeasure stereoMeasureWin;
        private ImageProcess imgProcessWin;
        //存储文件路径信息
        private DirectoryInfo rootDir;
        private string camParmyaml;
        public Form1()
        {
            InitializeComponent();               
        }
        //初始化相关配置
        private void Form1_Load(object sender, EventArgs e)
        {
            cap = new VideoCapture(camIndex);
            if(!cap.IsOpened())
            {
                //摄像头实例化失败处理                
                return; 
            }
            //设置摄像头属性
            cap.Set(CaptureProperty.FrameHeight, 480);
            cap.Set(CaptureProperty.FrameWidth, 1280);
            cap.Set(CaptureProperty.Fps, 60);
            cap.Set(CaptureProperty.FourCC, 1196444237);
            //初始化定时器
            timer_showImage.Enabled = true;
            timer_showImage.Stop();
            //camTim = new System.Threading.Timer(picCapThread, null, 0, 50);
        }
        private void timer_showImage_Tick(object sender, EventArgs e)
        {
            if (!cap.IsOpened())
            {
                //if (FrmDialog.ShowDialog(this, "双目相机连接失败", "Error") == DialogResult.OK)
                //{
                //    //执行连接失败处理
                //    return;
                //}
            }
            if (IS_DOUBLECAM_OPEN)          //摄像头打开
            {
                cap.Read(comImg);
                if (comImg.Data == null)
                {
                    return;
                }
                if (!IS_SHOW_RECTIFYIMAGE)
                {
                    leftImg = new Mat(comImg, new Rect(0, 0, 640, 480)).Clone();    //深拷贝图像
                    rightImg = new Mat(comImg, new Rect(640, 0, 640, 480)).Clone(); //深拷贝图像                    
                }
                if (IS_SHOW_RECTIFYIMAGE)                   //立体校正
                {
                    Mat _leftImg = new Mat(comImg, new Rect(0, 0, 640, 480)).Clone();    //深拷贝图像
                    Mat _rightImg = new Mat(comImg, new Rect(640, 0, 640, 480)).Clone(); //深拷贝图像
                    Cv2.Remap(_leftImg, leftImg, ShareData.leftMap1, ShareData.leftMap2, InterpolationFlags.Linear);
                    Cv2.Remap(_rightImg, rightImg, ShareData.rightMap1, ShareData.rightMap2, InterpolationFlags.Linear);
                    //使用红线绘制出像素有效区域
                    //Cv2.Rectangle(leftImg, ShareData.PixROI1, new Scalar(0, 0, 255), 1);
                    //Cv2.Rectangle(rightImg, ShareData.PixROI2, new Scalar(0, 0, 255), 1);
                }
                if (IS_SHOW_RECTIFYLINE)
                {
                    for (int i = 20; i < 480; i += 20)
                    {
                        Cv2.Line(leftImg, new OpenCvSharp.Point(0, i), new OpenCvSharp.Point(640, i),
                                 new Scalar(0, 0, 255));
                        Cv2.Line(rightImg, new OpenCvSharp.Point(0, i), new OpenCvSharp.Point(640, i),
                                 new Scalar(0, 0, 255));
                    }
                }
                //备份
                ShareData.LeftImg = leftImg;
                ShareData.RightImg = rightImg;
                //显示图像
                if (this.pictureBoxIpl_left.Image != null)
                {
                    this.pictureBoxIpl_left.Image.Dispose();
                }
                if (this.pictureBoxIpl_right.Image != null)
                {
                    this.pictureBoxIpl_right.Image.Dispose();
                }
                this.pictureBoxIpl_left.ImageIpl = leftImg;
                this.pictureBoxIpl_right.ImageIpl = rightImg;
            }
            else
            {
                //关闭摄像机
                if (!IS_DOUBLECAM_PAUSE)
                {
                    this.pictureBoxIpl_left.ImageIpl = null;
                    this.pictureBoxIpl_right.ImageIpl = null;
                    //摄像头关闭后清理缓存图片
                    this.comImg = new Mat();
                    this.leftImg = new Mat();
                    this.rightImg = new Mat();
                }
            }
        }
        private delegate void UpdateMainUI();
        //捕获摄像机图像线程定时器
        private void picCapThread(object state)
        {
            if (!cap.IsOpened())
            {
                if (FrmDialog.ShowDialog(this, "双目相机连接失败", "Error") == DialogResult.OK)
                {
                    //执行连接失败处理
                    return;
                }
            }
            if (IS_DOUBLECAM_OPEN)          //摄像头打开
            {
                cap.Read(comImg);
                if (comImg.Data == null)
                {
                    return;
                }
                if (!IS_SHOW_RECTIFYIMAGE)
                {
                    leftImg = new Mat(comImg, new Rect(0, 0, 640, 480)).Clone();    //深拷贝图像
                    rightImg = new Mat(comImg, new Rect(640, 0, 640, 480)).Clone(); //深拷贝图像                    
                }
                if (IS_SHOW_RECTIFYIMAGE)                   //立体校正
                {
                    Mat _leftImg = new Mat(comImg, new Rect(0, 0, 640, 480)).Clone();    //深拷贝图像
                    Mat _rightImg = new Mat(comImg, new Rect(640, 0, 640, 480)).Clone(); //深拷贝图像
                    Cv2.Remap(_leftImg, leftImg, ShareData.leftMap1, ShareData.leftMap2, InterpolationFlags.Linear);
                    Cv2.Remap(_rightImg, rightImg, ShareData.rightMap1, ShareData.rightMap2, InterpolationFlags.Linear);
                    //使用红线绘制出像素有效区域
                    Cv2.Rectangle(leftImg, ShareData.PixROI1, new Scalar(0, 0, 255), 1);
                    Cv2.Rectangle(rightImg, ShareData.PixROI2, new Scalar(0, 0, 255), 1);
                }
                if (IS_SHOW_RECTIFYLINE)
                {
                    for (int i = 20; i < 480; i += 20)
                    {
                        Cv2.Line(leftImg, new OpenCvSharp.Point(0, i), new OpenCvSharp.Point(640, i),
                                 new Scalar(0, 0, 255));
                        Cv2.Line(rightImg, new OpenCvSharp.Point(0, i), new OpenCvSharp.Point(640, i),
                                 new Scalar(0, 0, 255));
                    }
                }
                //备份
                ShareData.LeftImg = leftImg;
                ShareData.RightImg = rightImg;
                //显示图像
                if(this.pictureBoxIpl_left.Image!= null)
                {
                    this.pictureBoxIpl_left.Image.Dispose();
                }
                if(this.pictureBoxIpl_right.Image != null)
                {
                    this.pictureBoxIpl_right.Image.Dispose();
                }
                this.pictureBoxIpl_left.ImageIpl = leftImg;
                this.pictureBoxIpl_right.ImageIpl = rightImg;
            }
            else
            {
                //关闭摄像机
                if (!IS_DOUBLECAM_PAUSE)
                {
                    this.pictureBoxIpl_left.ImageIpl = null;
                    this.pictureBoxIpl_right.ImageIpl = null;
                    //摄像头关闭后清理缓存图片
                    this.comImg = new Mat();
                    this.leftImg = new Mat();
                    this.rightImg = new Mat();
                }
            }
            //this.Invoke(new UpdateMainUI(updateMainUI), new object[] { });
        }

        private void updateMainUI()
        {            
        }

        //打开摄像头
        private void ucBtn_open_BtnClick(object sender, EventArgs e)
        {
            if(!IS_DOUBLECAM_OPEN)
            {
                timer_showImage.Start();
                IS_DOUBLECAM_OPEN = true;
                ShareData.Log = "[msg] 摄像头已打开";
            }
            else
            {
            }
        }
        //关闭摄像头
        private void ucBtn_close_BtnClick(object sender, EventArgs e)
        {
            if(IS_DOUBLECAM_OPEN)
            {
                ShareData.Log = "[msg] 摄像头已关闭";
                IS_DOUBLECAM_OPEN = false;
                IS_DOUBLECAM_PAUSE = false;                
            }
            else
            {
                IS_DOUBLECAM_PAUSE = false;
            }
        }
        //暂停摄像头
        private void ucBtn_pause_BtnClick(object sender, EventArgs e)
        {
            if(IS_DOUBLECAM_OPEN)
            {
                ShareData.Log = "[msg] 摄像头已暂停";
                IS_DOUBLECAM_OPEN = false;
                IS_DOUBLECAM_PAUSE = true;
            }
            else
            {
            }
        }
        //重新启动摄像头
        private void ucBtn_restart_BtnClick(object sender, EventArgs e)
        {
            if(IS_DOUBLECAM_OPEN)
            {
            }
            else
            {
                ShareData.Log = "[msg] 摄像头已重启";
                IS_DOUBLECAM_OPEN = true;
                IS_DOUBLECAM_PAUSE = false;
            }
        }
        //捕获当前图片（实现拍照功能）
        private void ucBtn_capture_BtnClick(object sender, EventArgs e)
        {
            //当相机关闭时
            if(!IS_DOUBLECAM_PAUSE && !IS_DOUBLECAM_OPEN)
            {
                if(FrmDialog.ShowDialog(this,"必须打开摄像头才能拍照","Warning")== DialogResult.OK)
                {
                    return;
                }
            }
            //临时暂存图像
            Mat leftImg_temp = leftImg.Clone();
            Mat rightImg_temp = rightImg.Clone();
            //设置saveFileDialog            
            this.saveFileDialog_pic.Filter = "jpg file|*.jpg|bmp file|*.bmp";
            this.saveFileDialog_pic.FilterIndex = 1;
            this.saveFileDialog_pic.RestoreDirectory = true;
            //如果按下确认选择的按钮
            if(this.saveFileDialog_pic.ShowDialog() == DialogResult.OK)
            {
                //设置保存文件名
                string fileName = this.saveFileDialog_pic.FileName;
                string[] splitName = fileName.Split('.');
                string leftPicfileName = splitName[0] + "_left." + splitName[1]; 
                string rightPicfileName = splitName[0] + "_right." + splitName[1];
                //写入图片
                Cv2.ImWrite(leftPicfileName, leftImg_temp);
                Cv2.ImWrite(rightPicfileName, rightImg_temp);
                ShareData.Log = "[msg] 图片保存成功";
            }
        }
        //打开LogView窗口
        private void lOGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logWin = GenericSingleton<LogView>.CreateInstance();
            logWin.Show();
            ShareData.Log = "[msg] LogView已打开";
        }
        //主窗体置顶
        private void ucCheckBox_top_CheckedChangeEvent(object sender, EventArgs e)
        {
            if(this.ucCheckBox_top.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
        //读入相机标定数据
        /// <summary>
        /// 待修改！！！！！！！！！！
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucBtnExt_readCamParm_BtnClick(object sender, EventArgs e)
        {
            rootDir = Directory.GetParent(Environment.CurrentDirectory);    //定位bin目录
            camParmyaml = rootDir.Parent.Parent.FullName + @"\CamParm.yaml";//获取文件名称
            using (var fs = new FileStorage(camParmyaml,FileStorage.Mode.Read))
            {
                ShareData.leftCamIntrinsic = fs["leftCamIntrinsic"].ReadMat();
                ShareData.leftDistCoeffs = fs["leftDistCoeffs"].ReadMat();
                ShareData.rightCamIntrinsic = fs["rightCamIntrinsic"].ReadMat();
                ShareData.rightDistCoeffs = fs["rightDistCoeffs"].ReadMat();
                ShareData.R = fs["R"].ReadMat();
                ShareData.T = fs["T"].ReadMat();
                ShareData.E = fs["E"].ReadMat();
                ShareData.F = fs["F"].ReadMat();
            }
            ///使用640 * 480图片的分辨率重新采集图像 计算数值             
            OpenCvSharp.Size imgSize = new OpenCvSharp.Size(640,480);
            //注意 这里传入的参数 必须符合规定格式
            double alpha = 0;       //只显示有效像素区域
            Cv2.StereoRectify(ShareData.leftCamIntrinsic, ShareData.leftDistCoeffs, ShareData.rightCamIntrinsic,
                              ShareData.rightDistCoeffs, imgSize, ShareData.R, ShareData.T,
                              ShareData.R1, ShareData.R2, ShareData.P1, ShareData.P2, ShareData.Q, StereoRectificationFlags.ZeroDisparity,
                              alpha, imgSize, out ShareData.PixROI1, out ShareData.PixROI2);
            //计算左右相机校正映射 ， 映射为定点表示形式
            Cv2.InitUndistortRectifyMap(ShareData.leftCamIntrinsic, ShareData.leftDistCoeffs, ShareData.R1, ShareData.P1,
                                        imgSize, MatType.CV_16SC2, ShareData.leftMap1, ShareData.leftMap2);
            Cv2.InitUndistortRectifyMap(ShareData.rightCamIntrinsic, ShareData.rightDistCoeffs, ShareData.R2, ShareData.P2,
                                        imgSize, MatType.CV_16SC2, ShareData.rightMap1, ShareData.rightMap2);
            //标志位置1
            this.IS_READPARM = true;
            ShareData.Log = "[msg] 相机参数读入计算成功";            
        }
        //打开相机设置选项卡
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShareData.Log = "[msg] Settings窗口已打开";
            settingWin = GenericSingleton<Settings>.CreateInstance();
            //按照模态窗体方式打开
            settingWin.ShowDialog();   
        }
        //显示矫正图像
        private void ucSwitch_rectify_CheckedChanged(object sender, EventArgs e)
        {                        
            if(IS_READPARM)
            {
                if (this.ucSwitch_rectify.Checked)
                {
                    IS_SHOW_RECTIFYIMAGE = true;
                }
                else
                {
                    IS_SHOW_RECTIFYIMAGE = false;
                }
            }
            else
            {
                if (FrmDialog.ShowDialog(this, "请先读入相机标定系数", "Warning") == DialogResult.OK)
                {
                    //this.ucSwitch_rectify.Checked = false;                   
                }
            }            
        }
        //显示矫正线
        private void ucSwitch_line_CheckedChanged(object sender, EventArgs e)
        {            
            if(IS_READPARM)
            {
                if (this.ucSwitch_line.Checked)
                {
                    this.IS_SHOW_RECTIFYLINE = true;
                }
                else
                {
                    this.IS_SHOW_RECTIFYLINE = false;
                }
            }
            else
            {
                if (FrmDialog.ShowDialog(this, "请先读入相机标定系数", "Warning") == DialogResult.OK)
                {
                    this.ucSwitch_line.Checked = false;
                }
            }
        }
        //窗体关闭前释放资源
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //camTim.Change(-1, 50);
        }
        //打开立体测量对话框
        private void 立体测量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShareData.Log = "[msg] 立体测量窗口已打开";
            stereoMeasureWin = GenericSingleton<DisparityMeasure>.CreateInstance();
            stereoMeasureWin.Show();
        }
        //打开图像处理对话框
        private void 图像处理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgProcessWin = GenericSingleton<ImageProcess>.CreateInstance();
            imgProcessWin.Show();
            ShareData.Log = "[msg] 图像处理对话框已打开";
        }
    }
}
