#region 
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
    }
}
