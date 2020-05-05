using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stereoControl
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.ThreadException += Application_ThreadException;
            //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            Application.Run(new Form1());
        }

        //private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        //{
        //    ShareData.Log = "[error] " + ((Exception)e.ExceptionObject).Message;
        //}

        //private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        //{
        //    ShareData.Log = "[error] " + e.Exception.Message;            
        //}
    }
}
