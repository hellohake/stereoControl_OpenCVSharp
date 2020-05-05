using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;         //添加命名空间

namespace stereoControl
{
    public partial class LogView : Form
    {
        //定义变量
        private System.Threading.Timer logTim;
        private string logstring = null;
        private delegate void UpdateLogUI();
        public LogView()
        {
            InitializeComponent();
        }
        //LogView窗体初始化
        private void LogView_Load(object sender, EventArgs e)
        {            
            this.richTextBox_log.Text = "";
            //默认不置顶
            this.ucCheckBox_log.Checked = false;
            this.TopMost = false;
            logTim = new System.Threading.Timer(logRefresh, null, 0, 100);
        }

        private void logRefresh(object state)
        {
            if(ShareData.Log != this.logstring)
            {
                this.logstring = ShareData.Log;
                //异步更新UI
                this.Invoke(new UpdateLogUI(updateLogUI), new object[] { });                
            }
            else
            {
            }
        }

        private void updateLogUI()
        {
            this.richTextBox_log.AppendText(this.logstring + "\r\n");
        }

        //是否置顶
        private void ucCheckBox_log_CheckedChangeEvent(object sender, EventArgs e)
        {
            if(this.ucCheckBox_log.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
        //清空日志
        private void ucBtnExt_clear_BtnClick(object sender, EventArgs e)
        {
            this.richTextBox_log.Text = "";
        }
        //保存日志
        private void ucBtnExt_save_BtnClick(object sender, EventArgs e)
        {
            //暂不实现
        }
        //richTextBox自动定位至最底部
        private void richTextBox_log_TextChanged(object sender, EventArgs e)
        {
            richTextBox_log.SelectionStart = richTextBox_log.Text.Length;
            richTextBox_log.ScrollToCaret();
        }
    }
}
