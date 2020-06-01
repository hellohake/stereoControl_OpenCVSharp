namespace stereoControl
{
    partial class ImageProcess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageProcess));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxIpl_img = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ucPanelTitle1 = new HZH_Controls.Controls.UCPanelTitle();
            this.ucBtnExt_A4 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_A3 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_A2 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_A1 = new HZH_Controls.Controls.UCBtnExt();
            this.ucPanelQuote1 = new HZH_Controls.Controls.UCPanelQuote();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ucBtnExt_load = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_close = new HZH_Controls.Controls.UCBtnExt();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ucBtnExt_A5 = new HZH_Controls.Controls.UCBtnExt();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_img)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ucPanelTitle1.SuspendLayout();
            this.ucPanelQuote1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxIpl_img);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // pictureBoxIpl_img
            // 
            this.pictureBoxIpl_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIpl_img.Location = new System.Drawing.Point(15, 20);
            this.pictureBoxIpl_img.Name = "pictureBoxIpl_img";
            this.pictureBoxIpl_img.Size = new System.Drawing.Size(640, 480);
            this.pictureBoxIpl_img.TabIndex = 0;
            this.pictureBoxIpl_img.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(696, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(231, 503);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.ucPanelTitle1);
            this.tabPage1.Controls.Add(this.ucPanelQuote1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(223, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "目标提取";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ucPanelTitle1
            // 
            this.ucPanelTitle1.BackColor = System.Drawing.Color.Transparent;
            this.ucPanelTitle1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucPanelTitle1.ConerRadius = 10;
            this.ucPanelTitle1.Controls.Add(this.ucBtnExt_A5);
            this.ucPanelTitle1.Controls.Add(this.ucBtnExt_A3);
            this.ucPanelTitle1.Controls.Add(this.ucBtnExt_A4);
            this.ucPanelTitle1.Controls.Add(this.ucBtnExt_A2);
            this.ucPanelTitle1.Controls.Add(this.ucBtnExt_A1);
            this.ucPanelTitle1.FillColor = System.Drawing.Color.White;
            this.ucPanelTitle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucPanelTitle1.IsCanExpand = false;
            this.ucPanelTitle1.IsExpand = false;
            this.ucPanelTitle1.IsRadius = true;
            this.ucPanelTitle1.IsShowRect = true;
            this.ucPanelTitle1.Location = new System.Drawing.Point(10, 110);
            this.ucPanelTitle1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucPanelTitle1.Name = "ucPanelTitle1";
            this.ucPanelTitle1.Padding = new System.Windows.Forms.Padding(1);
            this.ucPanelTitle1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucPanelTitle1.RectWidth = 1;
            this.ucPanelTitle1.Size = new System.Drawing.Size(204, 212);
            this.ucPanelTitle1.TabIndex = 6;
            this.ucPanelTitle1.Title = "目标识别";
            // 
            // ucBtnExt_A4
            // 
            this.ucBtnExt_A4.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_A4.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_A4.BtnFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtnExt_A4.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_A4.BtnText = "目标质心像素坐标计算";
            this.ucBtnExt_A4.ConerRadius = 10;
            this.ucBtnExt_A4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_A4.EnabledMouseEffect = true;
            this.ucBtnExt_A4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_A4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_A4.IsRadius = true;
            this.ucBtnExt_A4.IsShowRect = true;
            this.ucBtnExt_A4.IsShowTips = false;
            this.ucBtnExt_A4.Location = new System.Drawing.Point(6, 112);
            this.ucBtnExt_A4.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_A4.Name = "ucBtnExt_A4";
            this.ucBtnExt_A4.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_A4.RectWidth = 1;
            this.ucBtnExt_A4.Size = new System.Drawing.Size(142, 23);
            this.ucBtnExt_A4.TabIndex = 8;
            this.ucBtnExt_A4.TabStop = false;
            this.ucBtnExt_A4.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_A4.TipsText = "";
            this.ucBtnExt_A4.BtnClick += new System.EventHandler(this.ucBtnExt_A4_BtnClick);
            // 
            // ucBtnExt_A3
            // 
            this.ucBtnExt_A3.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_A3.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_A3.BtnFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtnExt_A3.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_A3.BtnText = "轮廓像素点坐标计算";
            this.ucBtnExt_A3.ConerRadius = 10;
            this.ucBtnExt_A3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_A3.EnabledMouseEffect = true;
            this.ucBtnExt_A3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_A3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_A3.IsRadius = true;
            this.ucBtnExt_A3.IsShowRect = true;
            this.ucBtnExt_A3.IsShowTips = false;
            this.ucBtnExt_A3.Location = new System.Drawing.Point(6, 146);
            this.ucBtnExt_A3.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_A3.Name = "ucBtnExt_A3";
            this.ucBtnExt_A3.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_A3.RectWidth = 1;
            this.ucBtnExt_A3.Size = new System.Drawing.Size(142, 23);
            this.ucBtnExt_A3.TabIndex = 7;
            this.ucBtnExt_A3.TabStop = false;
            this.ucBtnExt_A3.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_A3.TipsText = "";
            this.ucBtnExt_A3.BtnClick += new System.EventHandler(this.ucBtnExt_A3_BtnClick);
            // 
            // ucBtnExt_A2
            // 
            this.ucBtnExt_A2.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_A2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_A2.BtnFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtnExt_A2.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_A2.BtnText = "边缘检测";
            this.ucBtnExt_A2.ConerRadius = 10;
            this.ucBtnExt_A2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_A2.EnabledMouseEffect = true;
            this.ucBtnExt_A2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_A2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_A2.IsRadius = true;
            this.ucBtnExt_A2.IsShowRect = true;
            this.ucBtnExt_A2.IsShowTips = false;
            this.ucBtnExt_A2.Location = new System.Drawing.Point(6, 78);
            this.ucBtnExt_A2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_A2.Name = "ucBtnExt_A2";
            this.ucBtnExt_A2.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_A2.RectWidth = 1;
            this.ucBtnExt_A2.Size = new System.Drawing.Size(142, 23);
            this.ucBtnExt_A2.TabIndex = 6;
            this.ucBtnExt_A2.TabStop = false;
            this.ucBtnExt_A2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_A2.TipsText = "";
            this.ucBtnExt_A2.BtnClick += new System.EventHandler(this.ucBtnExt_A2_BtnClick);
            // 
            // ucBtnExt_A1
            // 
            this.ucBtnExt_A1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_A1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_A1.BtnFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtnExt_A1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_A1.BtnText = "图像分割";
            this.ucBtnExt_A1.ConerRadius = 10;
            this.ucBtnExt_A1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_A1.EnabledMouseEffect = true;
            this.ucBtnExt_A1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_A1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_A1.IsRadius = true;
            this.ucBtnExt_A1.IsShowRect = true;
            this.ucBtnExt_A1.IsShowTips = false;
            this.ucBtnExt_A1.Location = new System.Drawing.Point(6, 44);
            this.ucBtnExt_A1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_A1.Name = "ucBtnExt_A1";
            this.ucBtnExt_A1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_A1.RectWidth = 1;
            this.ucBtnExt_A1.Size = new System.Drawing.Size(142, 23);
            this.ucBtnExt_A1.TabIndex = 5;
            this.ucBtnExt_A1.TabStop = false;
            this.ucBtnExt_A1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_A1.TipsText = "";
            this.ucBtnExt_A1.BtnClick += new System.EventHandler(this.ucBtnExt_A1_BtnClick);
            // 
            // ucPanelQuote1
            // 
            this.ucPanelQuote1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.ucPanelQuote1.Controls.Add(this.radioButton2);
            this.ucPanelQuote1.Controls.Add(this.radioButton1);
            this.ucPanelQuote1.Controls.Add(this.ucBtnExt1);
            this.ucPanelQuote1.Controls.Add(this.textBox1);
            this.ucPanelQuote1.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ucPanelQuote1.Location = new System.Drawing.Point(8, 19);
            this.ucPanelQuote1.Name = "ucPanelQuote1";
            this.ucPanelQuote1.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.ucPanelQuote1.Size = new System.Drawing.Size(206, 77);
            this.ucPanelQuote1.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Text = "中值滤波";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "不滤波";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = "Write";
            this.ucBtnExt1.ConerRadius = 10;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = true;
            this.ucBtnExt1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(146, 42);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(51, 23);
            this.ucBtnExt1.TabIndex = 4;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "5";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(223, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "二维图像处理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ucBtnExt_load
            // 
            this.ucBtnExt_load.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_load.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_load.BtnFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtnExt_load.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_load.BtnText = "Load";
            this.ucBtnExt_load.ConerRadius = 10;
            this.ucBtnExt_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_load.EnabledMouseEffect = true;
            this.ucBtnExt_load.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_load.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_load.IsRadius = true;
            this.ucBtnExt_load.IsShowRect = true;
            this.ucBtnExt_load.IsShowTips = false;
            this.ucBtnExt_load.Location = new System.Drawing.Point(30, 531);
            this.ucBtnExt_load.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_load.Name = "ucBtnExt_load";
            this.ucBtnExt_load.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_load.RectWidth = 1;
            this.ucBtnExt_load.Size = new System.Drawing.Size(70, 23);
            this.ucBtnExt_load.TabIndex = 2;
            this.ucBtnExt_load.TabStop = false;
            this.ucBtnExt_load.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_load.TipsText = "";
            this.ucBtnExt_load.BtnClick += new System.EventHandler(this.ucBtnExt_load_BtnClick);
            // 
            // ucBtnExt_close
            // 
            this.ucBtnExt_close.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_close.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_close.BtnFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtnExt_close.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_close.BtnText = "Close";
            this.ucBtnExt_close.ConerRadius = 10;
            this.ucBtnExt_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_close.EnabledMouseEffect = true;
            this.ucBtnExt_close.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_close.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_close.IsRadius = true;
            this.ucBtnExt_close.IsShowRect = true;
            this.ucBtnExt_close.IsShowTips = false;
            this.ucBtnExt_close.Location = new System.Drawing.Point(106, 531);
            this.ucBtnExt_close.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_close.Name = "ucBtnExt_close";
            this.ucBtnExt_close.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_close.RectWidth = 1;
            this.ucBtnExt_close.Size = new System.Drawing.Size(70, 23);
            this.ucBtnExt_close.TabIndex = 3;
            this.ucBtnExt_close.TabStop = false;
            this.ucBtnExt_close.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_close.TipsText = "";
            this.ucBtnExt_close.BtnClick += new System.EventHandler(this.ucBtnExt_close_BtnClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(10, 330);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(207, 140);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucBtnExt_A5
            // 
            this.ucBtnExt_A5.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_A5.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_A5.BtnFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtnExt_A5.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_A5.BtnText = "显示目标识别结果";
            this.ucBtnExt_A5.ConerRadius = 10;
            this.ucBtnExt_A5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_A5.EnabledMouseEffect = true;
            this.ucBtnExt_A5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_A5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_A5.IsRadius = true;
            this.ucBtnExt_A5.IsShowRect = true;
            this.ucBtnExt_A5.IsShowTips = false;
            this.ucBtnExt_A5.Location = new System.Drawing.Point(6, 180);
            this.ucBtnExt_A5.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_A5.Name = "ucBtnExt_A5";
            this.ucBtnExt_A5.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_A5.RectWidth = 1;
            this.ucBtnExt_A5.Size = new System.Drawing.Size(142, 23);
            this.ucBtnExt_A5.TabIndex = 8;
            this.ucBtnExt_A5.TabStop = false;
            this.ucBtnExt_A5.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_A5.TipsText = "";
            this.ucBtnExt_A5.BtnClick += new System.EventHandler(this.ucBtnExt_A5_BtnClick);
            // 
            // ImageProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(940, 560);
            this.Controls.Add(this.ucBtnExt_close);
            this.Controls.Add(this.ucBtnExt_load);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ImageProcess";
            this.Text = "图像处理";
            this.Load += new System.EventHandler(this.ImageProcess_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_img)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ucPanelTitle1.ResumeLayout(false);
            this.ucPanelQuote1.ResumeLayout(false);
            this.ucPanelQuote1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl_img;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_load;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_close;
        private HZH_Controls.Controls.UCPanelQuote ucPanelQuote1;
        private HZH_Controls.Controls.UCPanelTitle ucPanelTitle1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_A4;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_A3;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_A2;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_A1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_A5;
    }
}