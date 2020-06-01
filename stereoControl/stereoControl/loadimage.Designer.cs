namespace stereoControl
{
    partial class loadimage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loadimage));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Img = new System.Windows.Forms.TextBox();
            this.imgchoose_Btn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.openFileDialog_img = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "请选择实验图片：";
            // 
            // textBox_Img
            // 
            this.textBox_Img.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Img.Location = new System.Drawing.Point(103, 21);
            this.textBox_Img.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Img.Name = "textBox_Img";
            this.textBox_Img.Size = new System.Drawing.Size(238, 23);
            this.textBox_Img.TabIndex = 8;
            this.textBox_Img.TextChanged += new System.EventHandler(this.textBox_Img_TextChanged);
            // 
            // imgchoose_Btn
            // 
            this.imgchoose_Btn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgchoose_Btn.Location = new System.Drawing.Point(349, 21);
            this.imgchoose_Btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgchoose_Btn.Name = "imgchoose_Btn";
            this.imgchoose_Btn.Size = new System.Drawing.Size(59, 23);
            this.imgchoose_Btn.TabIndex = 9;
            this.imgchoose_Btn.Text = "Browse";
            this.imgchoose_Btn.UseVisualStyleBackColor = true;
            this.imgchoose_Btn.Click += new System.EventHandler(this.imgchoose_Btn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKBtn.Location = new System.Drawing.Point(282, 54);
            this.OKBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(59, 23);
            this.OKBtn.TabIndex = 10;
            this.OKBtn.Text = "确定";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.Location = new System.Drawing.Point(349, 54);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(59, 23);
            this.CancelBtn.TabIndex = 11;
            this.CancelBtn.Text = "取消";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // openFileDialog_img
            // 
            this.openFileDialog_img.FileName = "openFileDialog1";
            // 
            // loadimage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(419, 88);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.imgchoose_Btn);
            this.Controls.Add(this.textBox_Img);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loadimage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "目标识别实验";
            this.Load += new System.EventHandler(this.loadimage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Img;
        private System.Windows.Forms.Button imgchoose_Btn;
        private System.Windows.Forms.Button OKBtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog_img;
    }
}