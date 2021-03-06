﻿#region 
/*----------------------------------------------------------------
* 项目名称 ：stereoControl
* 项目描述 ：
* 类 名 称 ：ShareData
* 类 描 述 ：
* 所在的域 ：DESKTOP-43OU7EB
* 命名空间 ：stereoControl
* 机器名称 ：DESKTOP-43OU7EB
* CLR 版本 ：4.0.30319.42000
* 作    者 ：hello
* 创建时间 ：2020/4/28 19:50:14
* 更新时间 ：2020/4/28 19:50:14
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ hello 2020. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp;          //添加命令空间

namespace stereoControl
{
    //共享数据
    class ShareData
    {
        //定义私有变量
        private static Mat comImg = new Mat();
        private static Mat leftImg = new Mat();
        private static Mat rightImg = new Mat();
        private static string logString = null;

        //相机标定参数
        private static Mat _leftCamIntrinsic = new Mat();
        private static Mat _rightCamIntrinsic = new Mat();
        private static Mat _leftDistCoeffs = new Mat();
        private static Mat _rightDistCoeffs = new Mat();
        private static Mat _R = new Mat();
        private static Mat _T = new Mat();
        private static Mat _E = new Mat();
        private static Mat _F = new Mat();
        private static Mat _R1 = new Mat();
        private static Mat _R2 = new Mat();
        private static Mat _P1 = new Mat();
        private static Mat _P2 = new Mat();
        private static Mat _Q = new Mat();
        //公共静态变量
        public static Rect PixROI1 = new Rect();
        public static Rect PixROI2 = new Rect();
        public static Mat leftMap1 = new Mat();
        public static Mat leftMap2 = new Mat();
        public static Mat rightMap1 = new Mat();
        public static Mat rightMap2 = new Mat();
        //轮廓坐标点数据
        public static OpenCvSharp.Point[] Apple_contour;
        public static OpenCvSharp.Point[] Pear_contour;

        //封装属性
        public static Mat ComImg
        {
            set
            {
                comImg = value;
            }
            get
            {
                return comImg;
            }
        }
        public static Mat LeftImg
        {
            set
            {
                leftImg = value;
            }
            get
            {
                return leftImg;
            }
        }
        public static Mat RightImg
        {
            set
            {
                rightImg = value;
            }
            get
            {
                return rightImg;
            }
        }
        public static string Log
        {
            set
            {
                logString = value;
            }
            get
            {
                return logString;
            }
        }

        public static Mat leftCamIntrinsic
        {
            set
            {
                _leftCamIntrinsic = value;
            }
            get
            {
                return _leftCamIntrinsic;
            }
        }
        public static Mat rightCamIntrinsic
        {
            set
            {
                _rightCamIntrinsic = value;
            }
            get
            {
                return _rightCamIntrinsic;
            }
        }
        public static Mat leftDistCoeffs
        {
            set
            {
                _leftDistCoeffs = value;
            }
            get
            {
                return _leftDistCoeffs;
            }
        }
        public static Mat rightDistCoeffs
        {
            set
            {
                _rightDistCoeffs = value;
            }
            get
            {
                return _rightDistCoeffs;
            }
        }

        public static Mat R
        {
            set
            {
                _R = value;
            }
            get
            {
                return _R;
            }
        }
        public static Mat T
        {
            set
            {
                _T = value;
            }
            get
            {
                return _T;
            }
        }
        public static Mat E
        {
            set
            {
                _E = value;
            }
            get
            {
                return _E;
            }
        }
        public static Mat F
        {
            set
            {
                _F = value;
            }
            get
            {
                return _F;
            }
        }

        public static Mat R1
        {
            set
            {
                _R1 = value;
            }
            get
            {
                return _R1;
            }
        }
        public static Mat R2
        {
            set
            {
                _R2 = value;
            }
            get
            {
                return _R2;
            }
        }
        public static Mat P1
        {
            set
            {
                _P1 = value;
            }
            get
            {
                return _P1;
            }
        }
        public static Mat P2
        {
            set
            {
                _P2 = value;
            }
            get
            {
                return _P2;
            }
        }
        public static Mat Q
        {
            set
            {
                _Q = value;
            }
            get
            {
                return _Q;
            }
        }
        
        
    }
}
