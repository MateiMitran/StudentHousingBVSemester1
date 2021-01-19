
namespace StudentHousingBV
{
    partial class CompanyTenants
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewUsername = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMakeSoTM = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerateRandomPassword = new System.Windows.Forms.Button();
            this.cbNewUserRole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1200, 94);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Manange Users";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(72, 248);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(418, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Choose student of the month";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Add a new user";
            // 
            // tbNewUsername
            // 
            this.tbNewUsername.Location = new System.Drawing.Point(618, 246);
            this.tbNewUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNewUsername.Multiline = true;
            this.tbNewUsername.Name = "tbNewUsername";
            this.tbNewUsername.Size = new System.Drawing.Size(418, 35);
            this.tbNewUsername.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(618, 559);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(418, 66);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Tenant";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnMakeSoTM
            // 
            this.btnMakeSoTM.Location = new System.Drawing.Point(70, 363);
            this.btnMakeSoTM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMakeSoTM.Name = "btnMakeSoTM";
            this.btnMakeSoTM.Size = new System.Drawing.Size(420, 66);
            this.btnMakeSoTM.TabIndex = 11;
            this.btnMakeSoTM.Text = "Make Student Of The Month";
            this.btnMakeSoTM.UseVisualStyleBackColor = true;
            this.btnMakeSoTM.Click += new System.EventHandler(this.btnMakeSoTM_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Choose a username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Select tenant:";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(618, 334);
            this.tbNewPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNewPassword.Multiline = true;
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(418, 35);
            this.tbNewPassword.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Create new password:";
            // 
            // btnGenerateRandomPassword
            // 
            this.btnGenerateRandomPassword.Location = new System.Drawing.Point(618, 379);
            this.btnGenerateRandomPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerateRandomPassword.Name = "btnGenerateRandomPassword";
            this.btnGenerateRandomPassword.Size = new System.Drawing.Size(418, 50);
            this.btnGenerateRandomPassword.TabIndex = 10;
            this.btnGenerateRandomPassword.Text = "Generate Random Password";
            this.btnGenerateRandomPassword.UseVisualStyleBackColor = true;
            this.btnGenerateRandomPassword.Click += new System.EventHandler(this.btnGenerateRandomPassword_Click);
            // 
            // cbNewUserRole
            // 
            this.cbNewUserRole.FormattingEnabled = true;
            this.cbNewUserRole.Items.AddRange(new object[] {
            "tenant",
            "admin"});
            this.cbNewUserRole.Location = new System.Drawing.Point(618, 480);
            this.cbNewUserRole.Name = "cbNewUserRole";
            this.cbNewUserRole.Size = new System.Drawing.Size(418, 33);
            this.cbNewUserRole.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 452);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Select role:";
            // 
            // CompanyTenants
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.cbNewUserRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMakeSoTM);
            this.Controls.Add(this.btnGenerateRandomPassword);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbNewUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CompanyTenants";
            this.Text = "CompanyTenants";
            this.Load += new System.EventHandler(this.CompanyTenants_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewUsername;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMakeSoTM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerateRandomPassword;
        private System.Windows.Forms.ComboBox cbNewUserRole;
        private System.Windows.Forms.Label label6;
    }
}