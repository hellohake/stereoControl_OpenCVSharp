namespace stereoControl
{
    partial class LogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogView));
            this.ucCheckBox_log = new HZH_Controls.Controls.UCCheckBox();
            this.ucBtnExt_clear = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnExt_save = new HZH_Controls.Controls.UCBtnExt();
            this.richTextBox_log = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ucCheckBox_log
            // 
            this.ucCheckBox_log.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ucCheckBox_log.BackColor = System.Drawing.Color.Transparent;
            this.ucCheckBox_log.Checked = false;
            this.ucCheckBox_log.Font = new System.Drawing.Font("宋体", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucCheckBox_log.Location = new System.Drawing.Point(1, 484);
            this.ucCheckBox_log.Name = "ucCheckBox_log";
            this.ucCheckBox_log.Padding = new System.Windows.Forms.Padding(1);
            this.ucCheckBox_log.Size = new System.Drawing.Size(102, 30);
            this.ucCheckBox_log.TabIndex = 1;
            this.ucCheckBox_log.TextValue = "始终置顶";
            this.ucCheckBox_log.CheckedChangeEvent += new System.EventHandler(this.ucCheckBox_log_CheckedChangeEvent);
            // 
            // ucBtnExt_clear
            // 
            this.ucBtnExt_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucBtnExt_clear.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_clear.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_clear.BtnFont = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtnExt_clear.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_clear.BtnText = "Clear";
            this.ucBtnExt_clear.ConerRadius = 5;
            this.ucBtnExt_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_clear.EnabledMouseEffect = true;
            this.ucBtnExt_clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_clear.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_clear.IsRadius = true;
            this.ucBtnExt_clear.IsShowRect = true;
            this.ucBtnExt_clear.IsShowTips = false;
            this.ucBtnExt_clear.Location = new System.Drawing.Point(213, 488);
            this.ucBtnExt_clear.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_clear.Name = "ucBtnExt_clear";
            this.ucBtnExt_clear.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_clear.RectWidth = 1;
            this.ucBtnExt_clear.Size = new System.Drawing.Size(56, 23);
            this.ucBtnExt_clear.TabIndex = 2;
            this.ucBtnExt_clear.TabStop = false;
            this.ucBtnExt_clear.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_clear.TipsText = "";
            this.ucBtnExt_clear.BtnClick += new System.EventHandler(this.ucBtnExt_clear_BtnClick);
            // 
            // ucBtnExt_save
            // 
            this.ucBtnExt_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ucBtnExt_save.BackColor = System.Drawing.Color.White;
            this.ucBtnExt_save.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt_save.BtnFont = new System.Drawing.Font("Times New Roman", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBtnExt_save.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt_save.BtnText = "Save";
            this.ucBtnExt_save.ConerRadius = 5;
            this.ucBtnExt_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt_save.EnabledMouseEffect = true;
            this.ucBtnExt_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucBtnExt_save.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt_save.IsRadius = true;
            this.ucBtnExt_save.IsShowRect = true;
            this.ucBtnExt_save.IsShowTips = false;
            this.ucBtnExt_save.Location = new System.Drawing.Point(275, 488);
            this.ucBtnExt_save.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt_save.Name = "ucBtnExt_save";
            this.ucBtnExt_save.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(58)))));
            this.ucBtnExt_save.RectWidth = 1;
            this.ucBtnExt_save.Size = new System.Drawing.Size(56, 23);
            this.ucBtnExt_save.TabIndex = 3;
            this.ucBtnExt_save.TabStop = false;
            this.ucBtnExt_save.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt_save.TipsText = "";
            this.ucBtnExt_save.BtnClick += new System.EventHandler(this.ucBtnExt_save_BtnClick);
            // 
            // richTextBox_log
            // 
            this.richTextBox_log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_log.Font = new System.Drawing.Font("微软雅黑", 9.07563F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox_log.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_log.Name = "richTextBox_log";
            this.richTextBox_log.ReadOnly = true;
            this.richTextBox_log.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_log.Size = new System.Drawing.Size(330, 480);
            this.richTextBox_log.TabIndex = 4;
            this.richTextBox_log.Text = "";
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(332, 514);
            this.Controls.Add(this.richTextBox_log);
            this.Controls.Add(this.ucBtnExt_save);
            this.Controls.Add(this.ucBtnExt_clear);
            this.Controls.Add(this.ucCheckBox_log);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogView";
            this.Text = "LogView";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LogView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private HZH_Controls.Controls.UCCheckBox ucCheckBox_log;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_clear;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt_save;
        private System.Windows.Forms.RichTextBox richTextBox_log;
    }
}