
namespace StudentHousingBV
{
    partial class TenantAccount
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
            this.lblReports = new System.Windows.Forms.Label();
            this.pnlProfile = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pbAccount = new System.Windows.Forms.PictureBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.pnlProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.Location = new System.Drawing.Point(490, 425);
            this.lblReports.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(174, 32);
            this.lblReports.TabIndex = 1;
            this.lblReports.Text = "0 REPORTS";
            // 
            // pnlProfile
            // 
            this.pnlProfile.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProfile.Controls.Add(this.lblTitle);
            this.pnlProfile.Location = new System.Drawing.Point(18, 19);
            this.pnlProfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(193, 77);
            this.pnlProfile.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(4, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Profile:";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(468, 477);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(210, 77);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pbAccount
            // 
            this.pbAccount.Image = global::StudentHousingBV.Properties.Resources.download;
            this.pbAccount.Location = new System.Drawing.Point(404, 52);
            this.pbAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbAccount.Name = "pbAccount";
            this.pbAccount.Size = new System.Drawing.Size(327, 330);
            this.pbAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAccount.TabIndex = 0;
            this.pbAccount.TabStop = false;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(468, 581);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(210, 77);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "CHANGE PASSWORD";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // TenantAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.pnlProfile);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.pbAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TenantAccount";
            this.Text = "TenantAccount";
            this.Load += new System.EventHandler(this.TenantAccount_Load);
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAccount;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.FlowLayoutPanel pnlProfile;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnChangePassword;
    }
}