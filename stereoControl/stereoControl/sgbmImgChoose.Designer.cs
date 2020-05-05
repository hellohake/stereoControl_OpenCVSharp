namespace stereoControl
{
    partial class sgbmImgChoose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sgbmImgChoose));
            this.textBox_leftImg = new System.Windows.Forms.TextBox();
            this.textBox_rightImg = new System.Windows.Forms.TextBox();
            this.leftImgBrowse_Btn = new System.Windows.Forms.Button();
            this.rightImgBrowse_Btn = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox_leftImg
            // 
            this.textBox_leftImg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_leftImg.Location = new System.Drawing.Point(100, 27);
            this.textBox_leftImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_leftImg.Name = "textBox_leftImg";
            this.textBox_leftImg.Size = new System.Drawing.Size(336, 23);
            this.textBox_leftImg.TabIndex = 0;
            // 
            // textBox_rightImg
            // 
            this.textBox_rightImg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_rightImg.Location = new System.Drawing.Point(100, 69);
            this.textBox_rightImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_rightImg.Name = "textBox_rightImg";
            this.textBox_rightImg.Size = new System.Drawing.Size(336, 23);
            this.textBox_rightImg.TabIndex = 1;
            // 
            // leftImgBrowse_Btn
            // 
            this.leftImgBrowse_Btn.Location = new System.Drawing.Point(444, 25);
            this.leftImgBrowse_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftImgBrowse_Btn.Name = "leftImgBrowse_Btn";
            this.leftImgBrowse_Btn.Size = new System.Drawing.Size(73, 27);
            this.leftImgBrowse_Btn.TabIndex = 2;
            this.leftImgBrowse_Btn.Text = "Browse";
            this.leftImgBrowse_Btn.UseVisualStyleBackColor = true;
            this.leftImgBrowse_Btn.Click += new System.EventHandler(this.leftImgBrowse_Btn_Click);
            // 
            // rightImgBrowse_Btn
            // 
            this.rightImgBrowse_Btn.Location = new System.Drawing.Point(444, 67);
            this.rightImgBrowse_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rightImgBrowse_Btn.Name = "rightImgBrowse_Btn";
            this.rightImgBrowse_Btn.Size = new System.Drawing.Size(73, 27);
            this.rightImgBrowse_Btn.TabIndex = 3;
            this.rightImgBrowse_Btn.Text = "Browse";
            this.rightImgBrowse_Btn.UseVisualStyleBackColor = true;
            this.rightImgBrowse_Btn.Click += new System.EventHandler(this.rightImgBrowse_Btn_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(363, 103);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(73, 27);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "确定";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(444, 103);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(73, 27);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "LeftImage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(20, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "RightImage:";
            // 
            // sgbmImgChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(522, 136);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.rightImgBrowse_Btn);
            this.Controls.Add(this.leftImgBrowse_Btn);
            this.Controls.Add(this.textBox_rightImg);
            this.Controls.Add(this.textBox_leftImg);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "sgbmImgChoose";
            this.Text = "请选择用于计算视差的左右相机图片";
            this.Load += new System.EventHandler(this.sgbmImgChoose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_leftImg;
        private System.Windows.Forms.TextBox textBox_rightImg;
        private System.Windows.Forms.Button leftImgBrowse_Btn;
        private System.Windows.Forms.Button rightImgBrowse_Btn;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}