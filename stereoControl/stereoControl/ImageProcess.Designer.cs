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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageProcess));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxIpl_img = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ucBtnExt_load = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_close = new HZH_Controls.Controls.UCBtnExt();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl_img)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(696, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(323, 503);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(315, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "图像滤波";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(315, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "边缘检测";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(315, 477);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "特征提取";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ucBtnExt_load
            // 
            this.ucBtnExt_load.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_load.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_load.BtnFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ucBtnExt_close.BtnFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "均值滤波：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "中值滤波：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(21, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "高斯滤波：";
            // 
            // ImageProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1026, 560);
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
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl_img;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_load;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_close;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}