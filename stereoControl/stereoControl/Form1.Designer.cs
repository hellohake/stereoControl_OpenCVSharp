namespace stereoControl
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxIpl_left = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxIpl_right = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图像处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.立体测量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBB机器人运动控制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucSwitch_rectify = new HZH_Controls.Controls.UCSwitch();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ucBtn_capture = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtn_restart = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtn_pause = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtn_close = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtn_open = new HZH_Controls.Controls.UCBtnExt();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_left)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_right)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxIpl_left);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 520);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Left Camera";
            // 
            // pictureBoxIpl_left
            // 
            this.pictureBoxIpl_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIpl_left.Location = new System.Drawing.Point(10, 25);
            this.pictureBoxIpl_left.Name = "pictureBoxIpl_left";
            this.pictureBoxIpl_left.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxIpl_left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIpl_left.TabIndex = 1;
            this.pictureBoxIpl_left.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBoxIpl_right);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(678, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 520);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Right Camera";
            // 
            // pictureBoxIpl_right
            // 
            this.pictureBoxIpl_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIpl_right.Location = new System.Drawing.Point(10, 25);
            this.pictureBoxIpl_right.Name = "pictureBoxIpl_right";
            this.pictureBoxIpl_right.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxIpl_right.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIpl_right.TabIndex = 2;
            this.pictureBoxIpl_right.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图像处理ToolStripMenuItem,
            this.立体测量ToolStripMenuItem,
            this.aBB机器人运动控制ToolStripMenuItem,
            this.extensionToolStripMenuItem,
            this.lOGToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1346, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图像处理ToolStripMenuItem
            // 
            this.图像处理ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.图像处理ToolStripMenuItem.Name = "图像处理ToolStripMenuItem";
            this.图像处理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.图像处理ToolStripMenuItem.Text = "图像处理";
            // 
            // 立体测量ToolStripMenuItem
            // 
            this.立体测量ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.立体测量ToolStripMenuItem.Name = "立体测量ToolStripMenuItem";
            this.立体测量ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.立体测量ToolStripMenuItem.Text = "立体测量";
            // 
            // aBB机器人运动控制ToolStripMenuItem
            // 
            this.aBB机器人运动控制ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.aBB机器人运动控制ToolStripMenuItem.Name = "aBB机器人运动控制ToolStripMenuItem";
            this.aBB机器人运动控制ToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.aBB机器人运动控制ToolStripMenuItem.Text = "ABB机器人运动控制";
            // 
            // extensionToolStripMenuItem
            // 
            this.extensionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.extensionToolStripMenuItem.Name = "extensionToolStripMenuItem";
            this.extensionToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.extensionToolStripMenuItem.Text = "Extension";
            // 
            // lOGToolStripMenuItem
            // 
            this.lOGToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lOGToolStripMenuItem.Name = "lOGToolStripMenuItem";
            this.lOGToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.lOGToolStripMenuItem.Text = "LOG";
            // 
            // ucSwitch_rectify
            // 
            this.ucSwitch_rectify.BackColor = System.Drawing.Color.Transparent;
            this.ucSwitch_rectify.Checked = false;
            this.ucSwitch_rectify.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucSwitch_rectify.FalseTextColr = System.Drawing.Color.White;
            this.ucSwitch_rectify.Location = new System.Drawing.Point(121, 13);
            this.ucSwitch_rectify.Name = "ucSwitch_rectify";
            this.ucSwitch_rectify.Size = new System.Drawing.Size(53, 19);
            this.ucSwitch_rectify.SwitchType = HZH_Controls.Controls.SwitchType.Line;
            this.ucSwitch_rectify.TabIndex = 10;
            this.ucSwitch_rectify.Texts = null;
            this.ucSwitch_rectify.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucSwitch_rectify.TrueTextColr = System.Drawing.Color.White;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucSwitch_rectify);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ucBtn_capture);
            this.panel1.Controls.Add(this.ucBtn_restart);
            this.panel1.Controls.Add(this.ucBtn_pause);
            this.panel1.Controls.Add(this.ucBtn_close);
            this.panel1.Controls.Add(this.ucBtn_open);
            this.panel1.Location = new System.Drawing.Point(668, 558);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 46);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "显示矫正图像：";
            // 
            // ucBtn_capture
            // 
            this.ucBtn_capture.BackColor = System.Drawing.Color.White;
            this.ucBtn_capture.BtnBackColor = System.Drawing.Color.White;
            this.ucBtn_capture.BtnFont = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtn_capture.BtnForeColor = System.Drawing.Color.White;
            this.ucBtn_capture.BtnText = "Capture";
            this.ucBtn_capture.ConerRadius = 8;
            this.ucBtn_capture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtn_capture.EnabledMouseEffect = true;
            this.ucBtn_capture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtn_capture.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtn_capture.IsRadius = true;
            this.ucBtn_capture.IsShowRect = true;
            this.ucBtn_capture.IsShowTips = false;
            this.ucBtn_capture.Location = new System.Drawing.Point(595, 6);
            this.ucBtn_capture.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtn_capture.Name = "ucBtn_capture";
            this.ucBtn_capture.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtn_capture.RectWidth = 1;
            this.ucBtn_capture.Size = new System.Drawing.Size(65, 32);
            this.ucBtn_capture.TabIndex = 5;
            this.ucBtn_capture.TabStop = false;
            this.ucBtn_capture.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtn_capture.TipsText = "";
            // 
            // ucBtn_restart
            // 
            this.ucBtn_restart.BackColor = System.Drawing.Color.White;
            this.ucBtn_restart.BtnBackColor = System.Drawing.Color.White;
            this.ucBtn_restart.BtnFont = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtn_restart.BtnForeColor = System.Drawing.Color.White;
            this.ucBtn_restart.BtnText = "Restart";
            this.ucBtn_restart.ConerRadius = 8;
            this.ucBtn_restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtn_restart.EnabledMouseEffect = true;
            this.ucBtn_restart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtn_restart.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtn_restart.IsRadius = true;
            this.ucBtn_restart.IsShowRect = true;
            this.ucBtn_restart.IsShowTips = false;
            this.ucBtn_restart.Location = new System.Drawing.Point(522, 6);
            this.ucBtn_restart.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtn_restart.Name = "ucBtn_restart";
            this.ucBtn_restart.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtn_restart.RectWidth = 1;
            this.ucBtn_restart.Size = new System.Drawing.Size(65, 32);
            this.ucBtn_restart.TabIndex = 4;
            this.ucBtn_restart.TabStop = false;
            this.ucBtn_restart.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtn_restart.TipsText = "";
            this.ucBtn_restart.BtnClick += new System.EventHandler(this.ucBtn_restart_BtnClick);
            // 
            // ucBtn_pause
            // 
            this.ucBtn_pause.BackColor = System.Drawing.Color.White;
            this.ucBtn_pause.BtnBackColor = System.Drawing.Color.White;
            this.ucBtn_pause.BtnFont = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtn_pause.BtnForeColor = System.Drawing.Color.White;
            this.ucBtn_pause.BtnText = "Pause";
            this.ucBtn_pause.ConerRadius = 8;
            this.ucBtn_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtn_pause.EnabledMouseEffect = true;
            this.ucBtn_pause.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtn_pause.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtn_pause.IsRadius = true;
            this.ucBtn_pause.IsShowRect = true;
            this.ucBtn_pause.IsShowTips = false;
            this.ucBtn_pause.Location = new System.Drawing.Point(449, 6);
            this.ucBtn_pause.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtn_pause.Name = "ucBtn_pause";
            this.ucBtn_pause.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtn_pause.RectWidth = 1;
            this.ucBtn_pause.Size = new System.Drawing.Size(65, 32);
            this.ucBtn_pause.TabIndex = 3;
            this.ucBtn_pause.TabStop = false;
            this.ucBtn_pause.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtn_pause.TipsText = "";
            this.ucBtn_pause.BtnClick += new System.EventHandler(this.ucBtn_pause_BtnClick);
            // 
            // ucBtn_close
            // 
            this.ucBtn_close.BackColor = System.Drawing.Color.White;
            this.ucBtn_close.BtnBackColor = System.Drawing.Color.White;
            this.ucBtn_close.BtnFont = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtn_close.BtnForeColor = System.Drawing.Color.White;
            this.ucBtn_close.BtnText = "Close";
            this.ucBtn_close.ConerRadius = 8;
            this.ucBtn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtn_close.EnabledMouseEffect = true;
            this.ucBtn_close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtn_close.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtn_close.IsRadius = true;
            this.ucBtn_close.IsShowRect = true;
            this.ucBtn_close.IsShowTips = false;
            this.ucBtn_close.Location = new System.Drawing.Point(376, 6);
            this.ucBtn_close.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtn_close.Name = "ucBtn_close";
            this.ucBtn_close.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtn_close.RectWidth = 1;
            this.ucBtn_close.Size = new System.Drawing.Size(65, 32);
            this.ucBtn_close.TabIndex = 2;
            this.ucBtn_close.TabStop = false;
            this.ucBtn_close.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtn_close.TipsText = "";
            this.ucBtn_close.BtnClick += new System.EventHandler(this.ucBtn_close_BtnClick);
            // 
            // ucBtn_open
            // 
            this.ucBtn_open.BackColor = System.Drawing.Color.White;
            this.ucBtn_open.BtnBackColor = System.Drawing.Color.White;
            this.ucBtn_open.BtnFont = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtn_open.BtnForeColor = System.Drawing.Color.White;
            this.ucBtn_open.BtnText = "Open";
            this.ucBtn_open.ConerRadius = 8;
            this.ucBtn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtn_open.EnabledMouseEffect = true;
            this.ucBtn_open.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtn_open.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtn_open.IsRadius = true;
            this.ucBtn_open.IsShowRect = true;
            this.ucBtn_open.IsShowTips = false;
            this.ucBtn_open.Location = new System.Drawing.Point(303, 6);
            this.ucBtn_open.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtn_open.Name = "ucBtn_open";
            this.ucBtn_open.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtn_open.RectWidth = 1;
            this.ucBtn_open.Size = new System.Drawing.Size(65, 32);
            this.ucBtn_open.TabIndex = 1;
            this.ucBtn_open.TabStop = false;
            this.ucBtn_open.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtn_open.TipsText = "";
            this.ucBtn_open.BtnClick += new System.EventHandler(this.ucBtn_open_BtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 612);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "MachineVersionControl";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_left)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_right)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图像处理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 立体测量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBB机器人运动控制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extensionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGToolStripMenuItem;
        private HZH_Controls.Controls.UCSwitch ucSwitch_rectify;
        private System.Windows.Forms.Panel panel1;
        private HZH_Controls.Controls.UCBtnExt ucBtn_open;
        private HZH_Controls.Controls.UCBtnExt ucBtn_restart;
        private HZH_Controls.Controls.UCBtnExt ucBtn_pause;
        private HZH_Controls.Controls.UCBtnExt ucBtn_close;
        private HZH_Controls.Controls.UCBtnExt ucBtn_capture;
        private System.Windows.Forms.Label label1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl_left;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl_right;
    }
}

