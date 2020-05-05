namespace stereoControl
{
    partial class DisparityMeasure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisparityMeasure));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxIpl_Img = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.tabControlExt1 = new HZH_Controls.Controls.TabControlExt();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucBtnExt_parmdefault = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_writeBMParm = new HZH_Controls.Controls.UCBtnExt();
            this.ucTrackBar_disp12MaxDiff = new HZH_Controls.Controls.UCTrackBar();
            this.label19 = new System.Windows.Forms.Label();
            this.ucTrackBar_speckleRange = new HZH_Controls.Controls.UCTrackBar();
            this.ucTrackBar_speckleWinSize = new HZH_Controls.Controls.UCTrackBar();
            this.ucTrackBar_textureThre = new HZH_Controls.Controls.UCTrackBar();
            this.ucTrackBar_uniquenessRatio = new HZH_Controls.Controls.UCTrackBar();
            this.label18 = new System.Windows.Forms.Label();
            this.ucTrackBar_numOfDis = new HZH_Controls.Controls.UCTrackBar();
            this.ucTrackBar_minDIsparity = new HZH_Controls.Controls.UCTrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_preFilterSize = new System.Windows.Forms.TextBox();
            this.textBox_preFilterCap = new System.Windows.Forms.TextBox();
            this.ucTrackBar_preFilterCap = new HZH_Controls.Controls.UCTrackBar();
            this.ucTrackBar_preFilterSize = new HZH_Controls.Controls.UCTrackBar();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_disp12MaxDiff = new System.Windows.Forms.TextBox();
            this.textBox_speckleRange = new System.Windows.Forms.TextBox();
            this.textBox_speckleWinSize = new System.Windows.Forms.TextBox();
            this.textBox_textureThreshold = new System.Windows.Forms.TextBox();
            this.textBox_SADWinSize = new System.Windows.Forms.TextBox();
            this.textBox_numOfDis = new System.Windows.Forms.TextBox();
            this.textBox_minDisparity = new System.Windows.Forms.TextBox();
            this.ucTrackBar_SADWinSize = new HZH_Controls.Controls.UCTrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_uniquenessRatio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucPanelQuote1 = new HZH_Controls.Controls.UCPanelQuote();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ucBtnExt3 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_sgbmrefresh = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_sgbmChangeImg = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_sgbmDisCal = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_sgbmLoadImg = new HZH_Controls.Controls.UCBtnExt();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucBtnExt_restart = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_pause = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_bmImg = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_bmDisCal = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_bmchangeImg = new HZH_Controls.Controls.UCBtnExt();
            this.timer_disparityMeasure = new System.Windows.Forms.Timer(this.components);
            this.textBox_xpos = new System.Windows.Forms.TextBox();
            this.textBox_ypos = new System.Windows.Forms.TextBox();
            this.textBox_zpos = new System.Windows.Forms.TextBox();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_Img)).BeginInit();
            this.tabControlExt1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ucPanelQuote1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxIpl_Img);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(661, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // pictureBoxIpl_Img
            // 
            this.pictureBoxIpl_Img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIpl_Img.Location = new System.Drawing.Point(8, 20);
            this.pictureBoxIpl_Img.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxIpl_Img.Name = "pictureBoxIpl_Img";
            this.pictureBoxIpl_Img.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxIpl_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIpl_Img.TabIndex = 0;
            this.pictureBoxIpl_Img.TabStop = false;
            this.pictureBoxIpl_Img.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxIpl_Img_MouseDown);
            // 
            // tabControlExt1
            // 
            this.tabControlExt1.Controls.Add(this.tabPage1);
            this.tabControlExt1.Controls.Add(this.tabPage2);
            this.tabControlExt1.IsShowCloseBtn = false;
            this.tabControlExt1.ItemSize = new System.Drawing.Size(0, 50);
            this.tabControlExt1.Location = new System.Drawing.Point(705, 12);
            this.tabControlExt1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlExt1.Name = "tabControlExt1";
            this.tabControlExt1.SelectedIndex = 0;
            this.tabControlExt1.Size = new System.Drawing.Size(271, 509);
            this.tabControlExt1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucBtnExt_parmdefault);
            this.tabPage1.Controls.Add(this.ucBtnExt_writeBMParm);
            this.tabPage1.Controls.Add(this.ucTrackBar_disp12MaxDiff);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.ucTrackBar_speckleRange);
            this.tabPage1.Controls.Add(this.ucTrackBar_speckleWinSize);
            this.tabPage1.Controls.Add(this.ucTrackBar_textureThre);
            this.tabPage1.Controls.Add(this.ucTrackBar_uniquenessRatio);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.ucTrackBar_numOfDis);
            this.tabPage1.Controls.Add(this.ucTrackBar_minDIsparity);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.textBox_preFilterSize);
            this.tabPage1.Controls.Add(this.textBox_preFilterCap);
            this.tabPage1.Controls.Add(this.ucTrackBar_preFilterCap);
            this.tabPage1.Controls.Add(this.ucTrackBar_preFilterSize);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textBox_disp12MaxDiff);
            this.tabPage1.Controls.Add(this.textBox_speckleRange);
            this.tabPage1.Controls.Add(this.textBox_speckleWinSize);
            this.tabPage1.Controls.Add(this.textBox_textureThreshold);
            this.tabPage1.Controls.Add(this.textBox_SADWinSize);
            this.tabPage1.Controls.Add(this.textBox_numOfDis);
            this.tabPage1.Controls.Add(this.textBox_minDisparity);
            this.tabPage1.Controls.Add(this.ucTrackBar_SADWinSize);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox_uniquenessRatio);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 54);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(263, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BM算法";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucBtnExt_parmdefault
            // 
            this.ucBtnExt_parmdefault.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_parmdefault.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_parmdefault.BtnFont = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_parmdefault.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_parmdefault.BtnText = "默认参数";
            this.ucBtnExt_parmdefault.ConerRadius = 5;
            this.ucBtnExt_parmdefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_parmdefault.EnabledMouseEffect = true;
            this.ucBtnExt_parmdefault.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_parmdefault.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_parmdefault.IsRadius = true;
            this.ucBtnExt_parmdefault.IsShowRect = true;
            this.ucBtnExt_parmdefault.IsShowTips = false;
            this.ucBtnExt_parmdefault.Location = new System.Drawing.Point(14, 389);
            this.ucBtnExt_parmdefault.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_parmdefault.Name = "ucBtnExt_parmdefault";
            this.ucBtnExt_parmdefault.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_parmdefault.RectWidth = 1;
            this.ucBtnExt_parmdefault.Size = new System.Drawing.Size(62, 20);
            this.ucBtnExt_parmdefault.TabIndex = 4;
            this.ucBtnExt_parmdefault.TabStop = false;
            this.ucBtnExt_parmdefault.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_parmdefault.TipsText = "";
            this.ucBtnExt_parmdefault.BtnClick += new System.EventHandler(this.ucBtnExt_parmdefault_BtnClick);
            // 
            // ucBtnExt_writeBMParm
            // 
            this.ucBtnExt_writeBMParm.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_writeBMParm.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_writeBMParm.BtnFont = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_writeBMParm.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_writeBMParm.BtnText = "写入参数";
            this.ucBtnExt_writeBMParm.ConerRadius = 5;
            this.ucBtnExt_writeBMParm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_writeBMParm.EnabledMouseEffect = true;
            this.ucBtnExt_writeBMParm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_writeBMParm.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_writeBMParm.IsRadius = true;
            this.ucBtnExt_writeBMParm.IsShowRect = true;
            this.ucBtnExt_writeBMParm.IsShowTips = false;
            this.ucBtnExt_writeBMParm.Location = new System.Drawing.Point(85, 389);
            this.ucBtnExt_writeBMParm.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_writeBMParm.Name = "ucBtnExt_writeBMParm";
            this.ucBtnExt_writeBMParm.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_writeBMParm.RectWidth = 1;
            this.ucBtnExt_writeBMParm.Size = new System.Drawing.Size(62, 20);
            this.ucBtnExt_writeBMParm.TabIndex = 3;
            this.ucBtnExt_writeBMParm.TabStop = false;
            this.ucBtnExt_writeBMParm.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_writeBMParm.TipsText = "";
            this.ucBtnExt_writeBMParm.BtnClick += new System.EventHandler(this.ucBtnExt_writeBMParm_BtnClick);
            // 
            // ucTrackBar_disp12MaxDiff
            // 
            this.ucTrackBar_disp12MaxDiff.DcimalDigits = 0;
            this.ucTrackBar_disp12MaxDiff.IsShowTips = true;
            this.ucTrackBar_disp12MaxDiff.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBar_disp12MaxDiff.LineWidth = 5F;
            this.ucTrackBar_disp12MaxDiff.Location = new System.Drawing.Point(112, 310);
            this.ucTrackBar_disp12MaxDiff.Margin = new System.Windows.Forms.Padding(2);
            this.ucTrackBar_disp12MaxDiff.MaxValue = 10F;
            this.ucTrackBar_disp12MaxDiff.MinValue = -1F;
            this.ucTrackBar_disp12MaxDiff.Name = "ucTrackBar_disp12MaxDiff";
            this.ucTrackBar_disp12MaxDiff.Size = new System.Drawing.Size(103, 18);
            this.ucTrackBar_disp12MaxDiff.TabIndex = 41;
            this.ucTrackBar_disp12MaxDiff.Text = "ucTrackBar8";
            this.ucTrackBar_disp12MaxDiff.TipsFormat = null;
            this.ucTrackBar_disp12MaxDiff.Value = 0F;
            this.ucTrackBar_disp12MaxDiff.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.ucTrackBar_disp12MaxDiff.ValueChanged += new System.EventHandler(this.ucTrackBar_disp12MaxDiff_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(10, 286);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 19);
            this.label19.TabIndex = 40;
            this.label19.Text = "状态参数：";
            // 
            // ucTrackBar_speckleRange
            // 
            this.ucTrackBar_speckleRange.DcimalDigits = 0;
            this.ucTrackBar_speckleRange.IsShowTips = true;
            this.ucTrackBar_speckleRange.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBar_speckleRange.LineWidth = 5F;
            this.ucTrackBar_speckleRange.Location = new System.Drawing.Point(112, 264);
            this.ucTrackBar_speckleRange.Margin = new System.Windows.Forms.Padding(2);
            this.ucTrackBar_speckleRange.MaxValue = 100F;
            this.ucTrackBar_speckleRange.MinValue = 0F;
            this.ucTrackBar_speckleRange.Name = "ucTrackBar_speckleRange";
            this.ucTrackBar_speckleRange.Size = new System.Drawing.Size(103, 18);
            this.ucTrackBar_speckleRange.TabIndex = 39;
            this.ucTrackBar_speckleRange.Text = "ucTrackBar7";
            this.ucTrackBar_speckleRange.TipsFormat = null;
            this.ucTrackBar_speckleRange.Value = 0F;
            this.ucTrackBar_speckleRange.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.ucTrackBar_speckleRange.ValueChanged += new System.EventHandler(this.ucTrackBar_speckleRange_ValueChanged);
            // 
            // ucTrackBar_speckleWinSize
            // 
            this.ucTrackBar_speckleWinSize.DcimalDigits = 0;
            this.ucTrackBar_speckleWinSize.IsShowTips = true;
            this.ucTrackBar_speckleWinSize.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBar_speckleWinSize.LineWidth = 5F;
            this.ucTrackBar_speckleWinSize.Location = new System.Drawing.Point(112, 242);
            this.ucTrackBar_speckleWinSize.Margin = new System.Windows.Forms.Padding(2);
            this.ucTrackBar_speckleWinSize.MaxValue = 100F;
            this.ucTrackBar_speckleWinSize.MinValue = 0F;
            this.ucTrackBar_speckleWinSize.Name = "ucTrackBar_speckleWinSize";
            this.ucTrackBar_speckleWinSize.Size = new System.Drawing.Size(103, 18);
            this.ucTrackBar_speckleWinSize.TabIndex = 38;
            this.ucTrackBar_speckleWinSize.Text = "ucTrackBar6";
            this.ucTrackBar_speckleWinSize.TipsFormat = null;
            this.ucTrackBar_speckleWinSize.Value = 0F;
            this.ucTrackBar_speckleWinSize.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.ucTrackBar_speckleWinSize.ValueChanged += new System.EventHandler(this.ucTrackBar_speckleWinSize_ValueChanged);
            // 
            // ucTrackBar_textureThre
            // 
            this.ucTrackBar_textureThre.DcimalDigits = 0;
            this.ucTrackBar_textureThre.IsShowTips = true;
            this.ucTrackBar_textureThre.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBar_textureThre.LineWidth = 5F;
            this.ucTrackBar_textureThre.Location = new System.Drawing.Point(112, 221);
            this.ucTrackBar_textureThre.Margin = new System.Windows.Forms.Padding(2);
            this.ucTrackBar_textureThre.MaxValue = 1000F;
            this.ucTrackBar_textureThre.MinValue = 0F;
            this.ucTrackBar_textureThre.Name = "ucTrackBar_textureThre";
            this.ucTrackBar_textureThre.Size = new System.Drawing.Size(103, 18);
            this.ucTrackBar_textureThre.TabIndex = 37;
            this.ucTrackBar_textureThre.Text = "ucTrackBar5";
            this.ucTrackBar_textureThre.TipsFormat = null;
            this.ucTrackBar_textureThre.Value = 0F;
            this.ucTrackBar_textureThre.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.ucTrackBar_textureThre.ValueChanged += new System.EventHandler(this.ucTrackBar_textureThre_ValueChanged);
            // 
            // ucTrackBar_uniquenessRatio
            // 
            this.ucTrackBar_uniquenessRatio.DcimalDigits = 0;
            this.ucTrackBar_uniquenessRatio.IsShowTips = true;
            this.ucTrackBar_uniquenessRatio.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBar_uniquenessRatio.LineWidth = 5F;
            this.ucTrackBar_uniquenessRatio.Location = new System.Drawing.Point(112, 199);
            this.ucTrackBar_uniquenessRatio.Margin = new System.Windows.Forms.Padding(2);
            this.ucTrackBar_uniquenessRatio.MaxValue = 20F;
            this.ucTrackBar_uniquenessRatio.MinValue = 0F;
            this.ucTrackBar_uniquenessRatio.Name = "ucTrackBar_uniquenessRatio";
            this.ucTrackBar_uniquenessRatio.Size = new System.Drawing.Size(103, 18);
            this.ucTrackBar_uniquenessRatio.TabIndex = 36;
            this.ucTrackBar_uniquenessRatio.Text = "ucTrackBar1";
            this.ucTrackBar_uniquenessRatio.TipsFormat = null;
            this.ucTrackBar_uniquenessRatio.Value = 0F;
            this.ucTrackBar_uniquenessRatio.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.ucTrackBar_uniquenessRatio.ValueChanged += new System.EventHandler(this.ucTrackBar_uniquenessRatio_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(10, 175);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 19);
            this.label18.TabIndex = 35;
            this.label18.Text = "后处理参数：";
            // 
            // ucTrackBar_numOfDis
            // 
            this.ucTrackBar_numOfDis.DcimalDigits = 0;
            this.ucTrackBar_numOfDis.IsShowTips = false;
            this.ucTrackBar_numOfDis.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBar_numOfDis.LineWidth = 5F;
            this.ucTrackBar_numOfDis.Location = new System.Drawing.Point(112, 151);
            this.ucTrackBar_numOfDis.Margin = new System.Windows.Forms.Padding(2);
            this.ucTrackBar_numOfDis.MaxValue = 10F;
            this.ucTrackBar_numOfDis.MinValue = 0F;
            this.ucTrackBar_numOfDis.Name = "ucTrackBar_numOfDis";
            this.ucTrackBar_numOfDis.Size = new System.Drawing.Size(103, 18);
            this.ucTrackBar_numOfDis.TabIndex = 34;
            this.ucTrackBar_numOfDis.Text = "ucTrackBar3";
            this.ucTrackBar_numOfDis.TipsFormat = null;
            this.ucTrackBar_numOfDis.Value = 0F;
            this.ucTrackBar_numOfDis.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.ucTrackBar_numOfDis.ValueChanged += new System.EventHandler(this.ucTrackBar_numOfDis_ValueChanged);
            // 
            // ucTrackBar_minDIsparity
            // 
            this.ucTrackBar_minDIsparity.DcimalDigits = 0;
            this.ucTrackBar_minDIsparity.IsShowTips = true;
            this.ucTrackBar_minDIsparity.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBar_minDIsparity.LineWidth = 5F;
            this.ucTrackBar_minDIsparity.Location = new System.Drawing.Point(112, 130);
            this.ucTrackBar_minDIsparity.Margin = new System.Windows.Forms.Padding(2);
            this.ucTrackBar_minDIsparity.MaxValue = 10F;
            this.ucTrackBar_minDIsparity.MinValue = -10F;
            this.ucTrackBar_minDIsparity.Name = "ucTrackBar_minDIsparity";
            this.ucTrackBar_minDIsparity.Size = new System.Drawing.Size(103, 18);
            this.ucTrackBar_minDIsparity.TabIndex = 33;
            this.ucTrackBar_minDIsparity.Text = "ucTrackBar2";
            this.ucTrackBar_minDIsparity.TipsFormat = null;
            this.ucTrackBar_minDIsparity.Value = 0F;
            this.ucTrackBar_minDIsparity.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.ucTrackBar_minDIsparity.ValueChanged += new System.EventHandler(this.ucTrackBar_minDIsparity_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(10, 86);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 19);
            this.label17.TabIndex = 32;
            this.label17.Text = "SAD参数：";
            // 
            // textBox_preFilterSize
            // 
            this.textBox_preFilterSize.Location = new System.Drawing.Point(220, 40);
            this.textBox_preFilterSize.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_preFilterSize.Name = "textBox_preFilterSize";
            this.textBox_preFilterSize.ReadOnly = true;
            this.textBox_preFilterSize.Size = new System.Drawing.Size(30, 21);
            this.textBox_preFilterSize.TabIndex = 31;
            this.textBox_preFilterSize.Text = "0";
            // 
            // textBox_preFilterCap
            // 
            this.textBox_preFilterCap.Location = new System.Drawing.Point(220, 62);
            this.textBox_preFilterCap.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_preFilterCap.Name = "textBox_preFilterCap";
            this.textBox_preFilterCap.ReadOnly = true;
            this.textBox_preFilterCap.Size = new System.Drawing.Size(30, 21);
            this.textBox_preFilterCap.TabIndex = 30;
            this.textBox_preFilterCap.Text = "0";
            // 
            // ucTrackBar_preFilterCap
            // 
            this.ucTrackBar_preFilterCap.DcimalDigits = 0;
            this.ucTrackBar_preFilterCap.IsShowTips = true;
            this.ucTrackBar_preFilterCap.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBar_preFilterCap.LineWidth = 5F;
            this.ucTrackBar_preFilterCap.Location = new System.Drawing.Point(112, 62);
            this.ucTrackBar_preFilterCap.Margin = new System.Windows.Forms.Padding(2);
            this.ucTrackBar_preFilterCap.MaxValue = 31F;
            this.ucTrackBar_preFilterCap.MinValue = 0F;
            this.ucTrackBar_preFilterCap.Name = "ucTrackBar_preFilterCap";
            this.ucTrackBar_preFilterCap.Size = new System.Drawing.Size(103, 18);
            this.ucTrackBar_preFilterCap.TabIndex = 29;
            this.ucTrackBar_preFilterCap.Text = "ucTrackBar10";
            this.ucTrackBar_preFilterCap.TipsFormat = null;
            this.ucTrackBar_preFilterCap.Value = 0F;
            this.ucTrackBar_preFilterCap.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.ucTrackBar_preFilterCap.ValueChanged += new System.EventHandler(this.ucTrackBar_preFilterCap_ValueChanged);
            // 
            // ucTrackBar_preFilterSize
            // 
            this.ucTrackBar_preFilterSize.DcimalDigits = 0;
            this.ucTrackBar_preFilterSize.IsShowTips = true;
            this.ucTrackBar_preFilterSize.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBar_preFilterSize.LineWidth = 5F;
            this.ucTrackBar_preFilterSize.Location = new System.Drawing.Point(112, 41);
            this.ucTrackBar_preFilterSize.Margin = new System.Windows.Forms.Padding(2);
            this.ucTrackBar_preFilterSize.MaxValue = 255F;
            this.ucTrackBar_preFilterSize.MinValue = 0F;
            this.ucTrackBar_preFilterSize.Name = "ucTrackBar_preFilterSize";
            this.ucTrackBar_preFilterSize.Size = new System.Drawing.Size(103, 18);
            this.ucTrackBar_preFilterSize.TabIndex = 28;
            this.ucTrackBar_preFilterSize.Text = "ucTrackBar9";
            this.ucTrackBar_preFilterSize.TipsFormat = null;
            this.ucTrackBar_preFilterSize.Value = 0F;
            this.ucTrackBar_preFilterSize.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.ucTrackBar_preFilterSize.ValueChanged += new System.EventHandler(this.ucTrackBar_preFilterSize_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 65);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 15);
            this.label16.TabIndex = 27;
            this.label16.Text = "preFilterCap:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 43);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "preFilterSize:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(10, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "预处理滤波参数：";
            // 
            // textBox_disp12MaxDiff
            // 
            this.textBox_disp12MaxDiff.Location = new System.Drawing.Point(220, 306);
            this.textBox_disp12MaxDiff.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_disp12MaxDiff.Name = "textBox_disp12MaxDiff";
            this.textBox_disp12MaxDiff.ReadOnly = true;
            this.textBox_disp12MaxDiff.Size = new System.Drawing.Size(30, 21);
            this.textBox_disp12MaxDiff.TabIndex = 24;
            this.textBox_disp12MaxDiff.Text = "0";
            // 
            // textBox_speckleRange
            // 
            this.textBox_speckleRange.Location = new System.Drawing.Point(220, 261);
            this.textBox_speckleRange.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_speckleRange.Name = "textBox_speckleRange";
            this.textBox_speckleRange.ReadOnly = true;
            this.textBox_speckleRange.Size = new System.Drawing.Size(30, 21);
            this.textBox_speckleRange.TabIndex = 23;
            this.textBox_speckleRange.Text = "0";
            // 
            // textBox_speckleWinSize
            // 
            this.textBox_speckleWinSize.Location = new System.Drawing.Point(220, 239);
            this.textBox_speckleWinSize.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_speckleWinSize.Name = "textBox_speckleWinSize";
            this.textBox_speckleWinSize.ReadOnly = true;
            this.textBox_speckleWinSize.Size = new System.Drawing.Size(30, 21);
            this.textBox_speckleWinSize.TabIndex = 22;
            this.textBox_speckleWinSize.Text = "0";
            // 
            // textBox_textureThreshold
            // 
            this.textBox_textureThreshold.Location = new System.Drawing.Point(220, 218);
            this.textBox_textureThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_textureThreshold.Name = "textBox_textureThreshold";
            this.textBox_textureThreshold.ReadOnly = true;
            this.textBox_textureThreshold.Size = new System.Drawing.Size(30, 21);
            this.textBox_textureThreshold.TabIndex = 21;
            this.textBox_textureThreshold.Text = "0";
            // 
            // textBox_SADWinSize
            // 
            this.textBox_SADWinSize.Location = new System.Drawing.Point(220, 107);
            this.textBox_SADWinSize.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_SADWinSize.Name = "textBox_SADWinSize";
            this.textBox_SADWinSize.ReadOnly = true;
            this.textBox_SADWinSize.Size = new System.Drawing.Size(30, 21);
            this.textBox_SADWinSize.TabIndex = 20;
            this.textBox_SADWinSize.Text = "0";
            // 
            // textBox_numOfDis
            // 
            this.textBox_numOfDis.Location = new System.Drawing.Point(220, 150);
            this.textBox_numOfDis.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_numOfDis.Name = "textBox_numOfDis";
            this.textBox_numOfDis.ReadOnly = true;
            this.textBox_numOfDis.Size = new System.Drawing.Size(30, 21);
            this.textBox_numOfDis.TabIndex = 19;
            this.textBox_numOfDis.Text = "0";
            // 
            // textBox_minDisparity
            // 
            this.textBox_minDisparity.Location = new System.Drawing.Point(220, 129);
            this.textBox_minDisparity.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_minDisparity.Name = "textBox_minDisparity";
            this.textBox_minDisparity.ReadOnly = true;
            this.textBox_minDisparity.Size = new System.Drawing.Size(30, 21);
            this.textBox_minDisparity.TabIndex = 18;
            this.textBox_minDisparity.Text = "0";
            // 
            // ucTrackBar_SADWinSize
            // 
            this.ucTrackBar_SADWinSize.DcimalDigits = 0;
            this.ucTrackBar_SADWinSize.IsShowTips = true;
            this.ucTrackBar_SADWinSize.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBar_SADWinSize.LineWidth = 5F;
            this.ucTrackBar_SADWinSize.Location = new System.Drawing.Point(112, 108);
            this.ucTrackBar_SADWinSize.Margin = new System.Windows.Forms.Padding(2);
            this.ucTrackBar_SADWinSize.MaxValue = 255F;
            this.ucTrackBar_SADWinSize.MinValue = 0F;
            this.ucTrackBar_SADWinSize.Name = "ucTrackBar_SADWinSize";
            this.ucTrackBar_SADWinSize.Size = new System.Drawing.Size(103, 18);
            this.ucTrackBar_SADWinSize.TabIndex = 13;
            this.ucTrackBar_SADWinSize.Text = "ucTrackBar4";
            this.ucTrackBar_SADWinSize.TipsFormat = null;
            this.ucTrackBar_SADWinSize.Value = 0F;
            this.ucTrackBar_SADWinSize.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.ucTrackBar_SADWinSize.ValueChanged += new System.EventHandler(this.ucTrackBar_SADWinSize_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 310);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "disp12MaxDiff:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "speckleRange:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "speckleWinSize:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 221);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "textureThreshold:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "SADWindowSize:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "NumOfDisparities:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "minDisparity:";
            // 
            // textBox_uniquenessRatio
            // 
            this.textBox_uniquenessRatio.Location = new System.Drawing.Point(220, 196);
            this.textBox_uniquenessRatio.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_uniquenessRatio.Name = "textBox_uniquenessRatio";
            this.textBox_uniquenessRatio.ReadOnly = true;
            this.textBox_uniquenessRatio.Size = new System.Drawing.Size(30, 21);
            this.textBox_uniquenessRatio.TabIndex = 2;
            this.textBox_uniquenessRatio.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "uniquenessRatio:";
            // 
            // tabPage2
            // 
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 54);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(263, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SGBM算法";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucPanelQuote1
            // 
            this.ucPanelQuote1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucPanelQuote1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucPanelQuote1.Controls.Add(this.panel2);
            this.ucPanelQuote1.Controls.Add(this.label14);
            this.ucPanelQuote1.Controls.Add(this.groupBox3);
            this.ucPanelQuote1.Controls.Add(this.groupBox2);
            this.ucPanelQuote1.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ucPanelQuote1.Location = new System.Drawing.Point(11, 532);
            this.ucPanelQuote1.Margin = new System.Windows.Forms.Padding(2);
            this.ucPanelQuote1.Name = "ucPanelQuote1";
            this.ucPanelQuote1.Padding = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.ucPanelQuote1.Size = new System.Drawing.Size(965, 123);
            this.ucPanelQuote1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_zpos);
            this.panel2.Controls.Add(this.textBox_ypos);
            this.panel2.Controls.Add(this.textBox_xpos);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(441, 14);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 101);
            this.panel2.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(7, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 19);
            this.label13.TabIndex = 12;
            this.label13.Text = "图像像素点空间坐标：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(20, 71);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "Z=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(20, 49);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "Y=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(20, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "X=";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(599, 16);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(357, 95);
            this.label14.TabIndex = 16;
            this.label14.Text = "说明：\r\n1. 鼠标点击进行测距\r\n2. [切换画面]可以在视差图与左相机原图之间切换显示\r\n3. 坐标值单位为mm，坐标系原点位于左相机光心\r\n4. BM算法用" +
    "于实时深度计算，SGBM算法用于图片深度计算";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ucBtnExt3);
            this.groupBox3.Controls.Add(this.ucBtnExt_sgbmrefresh);
            this.groupBox3.Controls.Add(this.ucBtnExt_sgbmChangeImg);
            this.groupBox3.Controls.Add(this.ucBtnExt_sgbmDisCal);
            this.groupBox3.Controls.Add(this.ucBtnExt_sgbmLoadImg);
            this.groupBox3.Location = new System.Drawing.Point(8, 63);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(429, 49);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SGBM";
            // 
            // ucBtnExt3
            // 
            this.ucBtnExt3.BackColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnFont = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt3.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt3.BtnText = "开始测量";
            this.ucBtnExt3.ConerRadius = 5;
            this.ucBtnExt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt3.EnabledMouseEffect = true;
            this.ucBtnExt3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt3.IsRadius = true;
            this.ucBtnExt3.IsShowRect = true;
            this.ucBtnExt3.IsShowTips = false;
            this.ucBtnExt3.Location = new System.Drawing.Point(274, 17);
            this.ucBtnExt3.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt3.Name = "ucBtnExt3";
            this.ucBtnExt3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt3.RectWidth = 1;
            this.ucBtnExt3.Size = new System.Drawing.Size(69, 26);
            this.ucBtnExt3.TabIndex = 3;
            this.ucBtnExt3.TabStop = false;
            this.ucBtnExt3.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt3.TipsText = "";
            // 
            // ucBtnExt_sgbmrefresh
            // 
            this.ucBtnExt_sgbmrefresh.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_sgbmrefresh.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_sgbmrefresh.BtnFont = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_sgbmrefresh.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_sgbmrefresh.BtnText = "刷新";
            this.ucBtnExt_sgbmrefresh.ConerRadius = 5;
            this.ucBtnExt_sgbmrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_sgbmrefresh.EnabledMouseEffect = true;
            this.ucBtnExt_sgbmrefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_sgbmrefresh.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_sgbmrefresh.IsRadius = true;
            this.ucBtnExt_sgbmrefresh.IsShowRect = true;
            this.ucBtnExt_sgbmrefresh.IsShowTips = false;
            this.ucBtnExt_sgbmrefresh.Location = new System.Drawing.Point(224, 17);
            this.ucBtnExt_sgbmrefresh.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_sgbmrefresh.Name = "ucBtnExt_sgbmrefresh";
            this.ucBtnExt_sgbmrefresh.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_sgbmrefresh.RectWidth = 1;
            this.ucBtnExt_sgbmrefresh.Size = new System.Drawing.Size(45, 26);
            this.ucBtnExt_sgbmrefresh.TabIndex = 3;
            this.ucBtnExt_sgbmrefresh.TabStop = false;
            this.ucBtnExt_sgbmrefresh.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_sgbmrefresh.TipsText = "";
            // 
            // ucBtnExt_sgbmChangeImg
            // 
            this.ucBtnExt_sgbmChangeImg.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_sgbmChangeImg.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_sgbmChangeImg.BtnFont = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_sgbmChangeImg.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_sgbmChangeImg.BtnText = "切换画面";
            this.ucBtnExt_sgbmChangeImg.ConerRadius = 5;
            this.ucBtnExt_sgbmChangeImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_sgbmChangeImg.EnabledMouseEffect = true;
            this.ucBtnExt_sgbmChangeImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_sgbmChangeImg.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_sgbmChangeImg.IsRadius = true;
            this.ucBtnExt_sgbmChangeImg.IsShowRect = true;
            this.ucBtnExt_sgbmChangeImg.IsShowTips = false;
            this.ucBtnExt_sgbmChangeImg.Location = new System.Drawing.Point(152, 17);
            this.ucBtnExt_sgbmChangeImg.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_sgbmChangeImg.Name = "ucBtnExt_sgbmChangeImg";
            this.ucBtnExt_sgbmChangeImg.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_sgbmChangeImg.RectWidth = 1;
            this.ucBtnExt_sgbmChangeImg.Size = new System.Drawing.Size(67, 26);
            this.ucBtnExt_sgbmChangeImg.TabIndex = 2;
            this.ucBtnExt_sgbmChangeImg.TabStop = false;
            this.ucBtnExt_sgbmChangeImg.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_sgbmChangeImg.TipsText = "";
            // 
            // ucBtnExt_sgbmDisCal
            // 
            this.ucBtnExt_sgbmDisCal.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_sgbmDisCal.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_sgbmDisCal.BtnFont = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_sgbmDisCal.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_sgbmDisCal.BtnText = "视差计算";
            this.ucBtnExt_sgbmDisCal.ConerRadius = 5;
            this.ucBtnExt_sgbmDisCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_sgbmDisCal.EnabledMouseEffect = true;
            this.ucBtnExt_sgbmDisCal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_sgbmDisCal.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_sgbmDisCal.IsRadius = true;
            this.ucBtnExt_sgbmDisCal.IsShowRect = true;
            this.ucBtnExt_sgbmDisCal.IsShowTips = false;
            this.ucBtnExt_sgbmDisCal.Location = new System.Drawing.Point(80, 17);
            this.ucBtnExt_sgbmDisCal.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_sgbmDisCal.Name = "ucBtnExt_sgbmDisCal";
            this.ucBtnExt_sgbmDisCal.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_sgbmDisCal.RectWidth = 1;
            this.ucBtnExt_sgbmDisCal.Size = new System.Drawing.Size(67, 26);
            this.ucBtnExt_sgbmDisCal.TabIndex = 3;
            this.ucBtnExt_sgbmDisCal.TabStop = false;
            this.ucBtnExt_sgbmDisCal.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_sgbmDisCal.TipsText = "";
            // 
            // ucBtnExt_sgbmLoadImg
            // 
            this.ucBtnExt_sgbmLoadImg.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_sgbmLoadImg.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_sgbmLoadImg.BtnFont = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_sgbmLoadImg.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_sgbmLoadImg.BtnText = "加载图像";
            this.ucBtnExt_sgbmLoadImg.ConerRadius = 5;
            this.ucBtnExt_sgbmLoadImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_sgbmLoadImg.EnabledMouseEffect = true;
            this.ucBtnExt_sgbmLoadImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_sgbmLoadImg.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_sgbmLoadImg.IsRadius = true;
            this.ucBtnExt_sgbmLoadImg.IsShowRect = true;
            this.ucBtnExt_sgbmLoadImg.IsShowTips = false;
            this.ucBtnExt_sgbmLoadImg.Location = new System.Drawing.Point(8, 17);
            this.ucBtnExt_sgbmLoadImg.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_sgbmLoadImg.Name = "ucBtnExt_sgbmLoadImg";
            this.ucBtnExt_sgbmLoadImg.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_sgbmLoadImg.RectWidth = 1;
            this.ucBtnExt_sgbmLoadImg.Size = new System.Drawing.Size(67, 26);
            this.ucBtnExt_sgbmLoadImg.TabIndex = 3;
            this.ucBtnExt_sgbmLoadImg.TabStop = false;
            this.ucBtnExt_sgbmLoadImg.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_sgbmLoadImg.TipsText = "";
            this.ucBtnExt_sgbmLoadImg.BtnClick += new System.EventHandler(this.ucBtnExt_sgbmLoadImg_BtnClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucBtnExt1);
            this.groupBox2.Controls.Add(this.ucBtnExt_restart);
            this.groupBox2.Controls.Add(this.ucBtnExt_pause);
            this.groupBox2.Controls.Add(this.ucBtnExt_bmImg);
            this.groupBox2.Controls.Add(this.ucBtnExt_bmDisCal);
            this.groupBox2.Controls.Add(this.ucBtnExt_bmchangeImg);
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(429, 49);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BM";
            // 
            // ucBtnExt_restart
            // 
            this.ucBtnExt_restart.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_restart.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_restart.BtnFont = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtnExt_restart.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_restart.BtnText = "Restart";
            this.ucBtnExt_restart.ConerRadius = 5;
            this.ucBtnExt_restart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_restart.EnabledMouseEffect = true;
            this.ucBtnExt_restart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_restart.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_restart.IsRadius = true;
            this.ucBtnExt_restart.IsShowRect = true;
            this.ucBtnExt_restart.IsShowTips = false;
            this.ucBtnExt_restart.Location = new System.Drawing.Point(311, 16);
            this.ucBtnExt_restart.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_restart.Name = "ucBtnExt_restart";
            this.ucBtnExt_restart.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_restart.RectWidth = 1;
            this.ucBtnExt_restart.Size = new System.Drawing.Size(54, 26);
            this.ucBtnExt_restart.TabIndex = 4;
            this.ucBtnExt_restart.TabStop = false;
            this.ucBtnExt_restart.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_restart.TipsText = "";
            this.ucBtnExt_restart.BtnClick += new System.EventHandler(this.ucBtnExt_restart_BtnClick);
            // 
            // ucBtnExt_pause
            // 
            this.ucBtnExt_pause.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_pause.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_pause.BtnFont = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_pause.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_pause.BtnText = "Pause";
            this.ucBtnExt_pause.ConerRadius = 5;
            this.ucBtnExt_pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_pause.EnabledMouseEffect = true;
            this.ucBtnExt_pause.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_pause.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_pause.IsRadius = true;
            this.ucBtnExt_pause.IsShowRect = true;
            this.ucBtnExt_pause.IsShowTips = false;
            this.ucBtnExt_pause.Location = new System.Drawing.Point(253, 16);
            this.ucBtnExt_pause.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_pause.Name = "ucBtnExt_pause";
            this.ucBtnExt_pause.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_pause.RectWidth = 1;
            this.ucBtnExt_pause.Size = new System.Drawing.Size(54, 26);
            this.ucBtnExt_pause.TabIndex = 3;
            this.ucBtnExt_pause.TabStop = false;
            this.ucBtnExt_pause.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_pause.TipsText = "";
            this.ucBtnExt_pause.BtnClick += new System.EventHandler(this.ucBtnExt_pause_BtnClick);
            // 
            // ucBtnExt_bmImg
            // 
            this.ucBtnExt_bmImg.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_bmImg.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_bmImg.BtnFont = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_bmImg.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_bmImg.BtnText = "显示相机图像";
            this.ucBtnExt_bmImg.ConerRadius = 5;
            this.ucBtnExt_bmImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_bmImg.EnabledMouseEffect = true;
            this.ucBtnExt_bmImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_bmImg.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_bmImg.IsRadius = true;
            this.ucBtnExt_bmImg.IsShowRect = true;
            this.ucBtnExt_bmImg.IsShowTips = false;
            this.ucBtnExt_bmImg.Location = new System.Drawing.Point(8, 16);
            this.ucBtnExt_bmImg.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_bmImg.Name = "ucBtnExt_bmImg";
            this.ucBtnExt_bmImg.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_bmImg.RectWidth = 1;
            this.ucBtnExt_bmImg.Size = new System.Drawing.Size(98, 26);
            this.ucBtnExt_bmImg.TabIndex = 5;
            this.ucBtnExt_bmImg.TabStop = false;
            this.ucBtnExt_bmImg.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_bmImg.TipsText = "";
            this.ucBtnExt_bmImg.BtnClick += new System.EventHandler(this.ucBtnExt_bmImg_BtnClick);
            // 
            // ucBtnExt_bmDisCal
            // 
            this.ucBtnExt_bmDisCal.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_bmDisCal.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_bmDisCal.BtnFont = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_bmDisCal.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_bmDisCal.BtnText = "视差计算";
            this.ucBtnExt_bmDisCal.ConerRadius = 5;
            this.ucBtnExt_bmDisCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_bmDisCal.EnabledMouseEffect = true;
            this.ucBtnExt_bmDisCal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_bmDisCal.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_bmDisCal.IsRadius = true;
            this.ucBtnExt_bmDisCal.IsShowRect = true;
            this.ucBtnExt_bmDisCal.IsShowTips = false;
            this.ucBtnExt_bmDisCal.Location = new System.Drawing.Point(110, 16);
            this.ucBtnExt_bmDisCal.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_bmDisCal.Name = "ucBtnExt_bmDisCal";
            this.ucBtnExt_bmDisCal.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_bmDisCal.RectWidth = 1;
            this.ucBtnExt_bmDisCal.Size = new System.Drawing.Size(68, 26);
            this.ucBtnExt_bmDisCal.TabIndex = 2;
            this.ucBtnExt_bmDisCal.TabStop = false;
            this.ucBtnExt_bmDisCal.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_bmDisCal.TipsText = "";
            this.ucBtnExt_bmDisCal.BtnClick += new System.EventHandler(this.ucBtnExt_bmDisCal_BtnClick);
            // 
            // ucBtnExt_bmchangeImg
            // 
            this.ucBtnExt_bmchangeImg.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_bmchangeImg.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_bmchangeImg.BtnFont = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt_bmchangeImg.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_bmchangeImg.BtnText = "切换画面";
            this.ucBtnExt_bmchangeImg.ConerRadius = 5;
            this.ucBtnExt_bmchangeImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_bmchangeImg.EnabledMouseEffect = true;
            this.ucBtnExt_bmchangeImg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_bmchangeImg.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_bmchangeImg.IsRadius = true;
            this.ucBtnExt_bmchangeImg.IsShowRect = true;
            this.ucBtnExt_bmchangeImg.IsShowTips = false;
            this.ucBtnExt_bmchangeImg.Location = new System.Drawing.Point(182, 16);
            this.ucBtnExt_bmchangeImg.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_bmchangeImg.Name = "ucBtnExt_bmchangeImg";
            this.ucBtnExt_bmchangeImg.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_bmchangeImg.RectWidth = 1;
            this.ucBtnExt_bmchangeImg.Size = new System.Drawing.Size(67, 26);
            this.ucBtnExt_bmchangeImg.TabIndex = 0;
            this.ucBtnExt_bmchangeImg.TabStop = false;
            this.ucBtnExt_bmchangeImg.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_bmchangeImg.TipsText = "";
            this.ucBtnExt_bmchangeImg.BtnClick += new System.EventHandler(this.ucBtnExt_bmchangeImg_BtnClick);
            // 
            // timer_disparityMeasure
            // 
            this.timer_disparityMeasure.Interval = 50;
            this.timer_disparityMeasure.Tick += new System.EventHandler(this.timer_disparityMeasure_Tick);
            // 
            // textBox_xpos
            // 
            this.textBox_xpos.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_xpos.Location = new System.Drawing.Point(51, 26);
            this.textBox_xpos.Name = "textBox_xpos";
            this.textBox_xpos.ReadOnly = true;
            this.textBox_xpos.Size = new System.Drawing.Size(88, 21);
            this.textBox_xpos.TabIndex = 1;
            // 
            // textBox_ypos
            // 
            this.textBox_ypos.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_ypos.Location = new System.Drawing.Point(51, 48);
            this.textBox_ypos.Name = "textBox_ypos";
            this.textBox_ypos.ReadOnly = true;
            this.textBox_ypos.Size = new System.Drawing.Size(88, 21);
            this.textBox_ypos.TabIndex = 13;
            // 
            // textBox_zpos
            // 
            this.textBox_zpos.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_zpos.Location = new System.Drawing.Point(51, 70);
            this.textBox_zpos.Name = "textBox_zpos";
            this.textBox_zpos.ReadOnly = true;
            this.textBox_zpos.Size = new System.Drawing.Size(88, 21);
            this.textBox_zpos.TabIndex = 14;
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "Close";
            this.ucBtnExt1.ConerRadius = 5;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = true;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(369, 16);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(47, 26);
            this.ucBtnExt1.TabIndex = 5;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            // 
            // DisparityMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(992, 677);
            this.Controls.Add(this.ucPanelQuote1);
            this.Controls.Add(this.tabControlExt1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisparityMeasure";
            this.Text = "立体测量";
            this.Load += new System.EventHandler(this.DisparityMeasure_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_Img)).EndInit();
            this.tabControlExt1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ucPanelQuote1.ResumeLayout(false);
            this.ucPanelQuote1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl_Img;
        private HZH_Controls.Controls.TabControlExt tabControlExt1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private HZH_Controls.Controls.UCPanelQuote ucPanelQuote1;
        private System.Windows.Forms.TextBox textBox_disp12MaxDiff;
        private System.Windows.Forms.TextBox textBox_speckleRange;
        private System.Windows.Forms.TextBox textBox_speckleWinSize;
        private System.Windows.Forms.TextBox textBox_textureThreshold;
        private System.Windows.Forms.TextBox textBox_SADWinSize;
        private System.Windows.Forms.TextBox textBox_numOfDis;
        private System.Windows.Forms.TextBox textBox_minDisparity;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar_SADWinSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_writeBMParm;
        private System.Windows.Forms.TextBox textBox_uniquenessRatio;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_sgbmLoadImg;
        private System.Windows.Forms.Label label9;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_bmDisCal;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_bmchangeImg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_sgbmrefresh;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_sgbmChangeImg;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_sgbmDisCal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_bmImg;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt3;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_pause;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_preFilterCap;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar_preFilterCap;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar_preFilterSize;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar_disp12MaxDiff;
        private System.Windows.Forms.Label label19;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar_speckleRange;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar_speckleWinSize;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar_textureThre;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar_uniquenessRatio;
        private System.Windows.Forms.Label label18;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar_numOfDis;
        private HZH_Controls.Controls.UCTrackBar ucTrackBar_minDIsparity;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_preFilterSize;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_parmdefault;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_restart;
        private System.Windows.Forms.Timer timer_disparityMeasure;
        private System.Windows.Forms.TextBox textBox_zpos;
        private System.Windows.Forms.TextBox textBox_ypos;
        private System.Windows.Forms.TextBox textBox_xpos;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
    }
}