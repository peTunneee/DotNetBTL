namespace fLogin
{
    partial class fSetting
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
            this.lblChaoBan = new System.Windows.Forms.Label();
            this.picAnhCaNhan = new System.Windows.Forms.PictureBox();
            this.lblNgayGio = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhCaNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblChaoBan
            // 
            this.lblChaoBan.AutoSize = true;
            this.lblChaoBan.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblChaoBan.Location = new System.Drawing.Point(474, 223);
            this.lblChaoBan.Name = "lblChaoBan";
            this.lblChaoBan.Size = new System.Drawing.Size(94, 25);
            this.lblChaoBan.TabIndex = 0;
            this.lblChaoBan.Text = "Chào ....";
            // 
            // picAnhCaNhan
            // 
            this.picAnhCaNhan.Image = global::fLogin.Properties.Resources.W11;
            this.picAnhCaNhan.Location = new System.Drawing.Point(425, 41);
            this.picAnhCaNhan.Name = "picAnhCaNhan";
            this.picAnhCaNhan.Size = new System.Drawing.Size(193, 156);
            this.picAnhCaNhan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhCaNhan.TabIndex = 1;
            this.picAnhCaNhan.TabStop = false;
            // 
            // lblNgayGio
            // 
            this.lblNgayGio.AutoSize = true;
            this.lblNgayGio.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNgayGio.Location = new System.Drawing.Point(349, 269);
            this.lblNgayGio.Name = "lblNgayGio";
            this.lblNgayGio.Size = new System.Drawing.Size(344, 24);
            this.lblNgayGio.TabIndex = 2;
            this.lblNgayGio.Text = "19:10, Ngày 23 Tháng 11 năm 2023";
            // 
            // btnSignOut
            // 
            this.btnSignOut.Location = new System.Drawing.Point(454, 345);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(135, 44);
            this.btnSignOut.TabIndex = 3;
            this.btnSignOut.Text = "Đăng Xuất";
            this.btnSignOut.UseVisualStyleBackColor = true;
            // 
            // fSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 552);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblNgayGio);
            this.Controls.Add(this.picAnhCaNhan);
            this.Controls.Add(this.lblChaoBan);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fSetting";
            ((System.ComponentModel.ISupportInitialize)(this.picAnhCaNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChaoBan;
        private System.Windows.Forms.PictureBox picAnhCaNhan;
        private System.Windows.Forms.Label lblNgayGio;
        private System.Windows.Forms.Button btnSignOut;
    }
}