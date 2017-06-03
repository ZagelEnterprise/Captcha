namespace Captcha
{
    partial class FrmCaptcha
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
            this.CaptchaPathBox = new System.Windows.Forms.PictureBox();
            this.BtnVerify = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.TxtVerify = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPathBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CaptchaPathBox
            // 
            this.CaptchaPathBox.Location = new System.Drawing.Point(32, 23);
            this.CaptchaPathBox.Name = "CaptchaPathBox";
            this.CaptchaPathBox.Size = new System.Drawing.Size(139, 60);
            this.CaptchaPathBox.TabIndex = 0;
            this.CaptchaPathBox.TabStop = false;
            // 
            // BtnVerify
            // 
            this.BtnVerify.Location = new System.Drawing.Point(105, 127);
            this.BtnVerify.Name = "BtnVerify";
            this.BtnVerify.Size = new System.Drawing.Size(64, 30);
            this.BtnVerify.TabIndex = 1;
            this.BtnVerify.Text = "Verify";
            this.BtnVerify.UseVisualStyleBackColor = true;
            this.BtnVerify.Click += new System.EventHandler(this.BtnVerify_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(33, 127);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(64, 30);
            this.BtnRefresh.TabIndex = 2;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // TxtVerify
            // 
            this.TxtVerify.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVerify.Location = new System.Drawing.Point(32, 89);
            this.TxtVerify.Name = "TxtVerify";
            this.TxtVerify.Size = new System.Drawing.Size(139, 27);
            this.TxtVerify.TabIndex = 3;
            // 
            // FrmCaptcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 174);
            this.Controls.Add(this.TxtVerify);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnVerify);
            this.Controls.Add(this.CaptchaPathBox);
            this.Name = "FrmCaptcha";
            this.Text = "CaptchaPath";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCaptcha_FormClosed);
            this.Load += new System.EventHandler(this.FrmCaptcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CaptchaPathBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox CaptchaPathBox;
        private System.Windows.Forms.Button BtnVerify;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.TextBox TxtVerify;
    }
}

