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
        private bool DOUBLECAM_OPEN = false;
        private bool DOUBLECAM_PAUSE = false;

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
            camTim = new System.Threading.Timer(picCapThread, null, 0, 50);
        }
        //捕获摄像机图像线程定时器
        private void picCapThread(object state)
        {
            if(!cap.IsOpened())
            {
               if(FrmDialog.ShowDialog(this, "双目相机连接失败", "Error")==DialogResult.OK)
               {
                    //执行连接失败处理
                    return;
               }
            }
            if(DOUBLECAM_OPEN)          //摄像头打开
            {
                cap.Read(comImg);
                if (comImg.Data == null)
                {
                    return;
                }
                leftImg = new Mat(comImg, new Rect(0, 0, 640, 480)).Clone();    //深拷贝图像
                rightImg = new Mat(comImg, new Rect(640, 0, 640, 480)).Clone(); //深拷贝图像

                this.pictureBoxIpl_left.ImageIpl = leftImg;
                this.pictureBoxIpl_right.ImageIpl = rightImg;
            }
            else
            {
                //清空图像显示
                if(!DOUBLECAM_PAUSE)
                {
                    this.pictureBoxIpl_left.ImageIpl = null;
                    this.pictureBoxIpl_right.ImageIpl = null;
                }                
            }
        }
        //打开摄像头
        private void ucBtn_open_BtnClick(object sender, EventArgs e)
        {
            if(!DOUBLECAM_OPEN)
            {
                DOUBLECAM_OPEN = true;
            }
            else
            {
            }
        }
        //关闭摄像头
        private void ucBtn_close_BtnClick(object sender, EventArgs e)
        {
            if(DOUBLECAM_OPEN)
            {
                DOUBLECAM_OPEN = false;
                DOUBLECAM_PAUSE = false;
            }
            else
            {
                DOUBLECAM_PAUSE = false;
            }
        }
        //暂停摄像头
        private void ucBtn_pause_BtnClick(object sender, EventArgs e)
        {
            if(DOUBLECAM_OPEN)
            {
                DOUBLECAM_OPEN = false;
                DOUBLECAM_PAUSE = true;
            }
            else
            {
            }
        }
        //重新启动摄像头
        private void ucBtn_restart_BtnClick(object sender, EventArgs e)
        {
            if(DOUBLECAM_OPEN)
            {
            }
            else
            {
                DOUBLECAM_OPEN = true;
                DOUBLECAM_PAUSE = false;
            }
        }
    }
}
