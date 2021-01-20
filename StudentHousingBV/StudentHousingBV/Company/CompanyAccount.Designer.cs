
namespace StudentHousingBV
{
    partial class CompanyAccount
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.tbVerifyNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tbCurrentPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTitle.Location = new System.Drawing.Point(0, -1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(473, 60);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Account";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbNewPassword.Location = new System.Drawing.Point(97, 175);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(276, 26);
            this.tbNewPassword.TabIndex = 6;
            this.tbNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNewPassword.Location = new System.Drawing.Point(93, 152);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(126, 20);
            this.lblNewPassword.TabIndex = 7;
            this.lblNewPassword.Text = "New Password:";
            // 
            // tbVerifyNewPassword
            // 
            this.tbVerifyNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbVerifyNewPassword.Location = new System.Drawing.Point(97, 241);
            this.tbVerifyNewPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbVerifyNewPassword.Name = "tbVerifyNewPassword";
            this.tbVerifyNewPassword.PasswordChar = '*';
            this.tbVerifyNewPassword.Size = new System.Drawing.Size(276, 26);
            this.tbVerifyNewPassword.TabIndex = 6;
            this.tbVerifyNewPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(93, 218);
            this.lblConfirmNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(190, 20);
            this.lblConfirmNewPassword.TabIndex = 7;
            this.lblConfirmNewPassword.Text = "Confirm New Password:";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChangePassword.Location = new System.Drawing.Point(97, 297);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(275, 48);
            this.btnChangePassword.TabIndex = 8;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(97, 360);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(275, 48);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tbCurrentPassword
            // 
            this.tbCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbCurrentPassword.Location = new System.Drawing.Point(97, 108);
            this.tbCurrentPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCurrentPassword.Name = "tbCurrentPassword";
            this.tbCurrentPassword.PasswordChar = '*';
            this.tbCurrentPassword.Size = new System.Drawing.Size(276, 26);
            this.tbCurrentPassword.TabIndex = 6;
            this.tbCurrentPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(93, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Current Password:";
            // 
            // CompanyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(469, 434);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.lblConfirmNewPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.tbVerifyNewPassword);
            this.Controls.Add(this.tbCurrentPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "CompanyAccount";
            this.Text = "CompanyAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox tbVerifyNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TextBox tbCurrentPassword;
        private System.Windows.Forms.Label label1;
    }
}