
namespace StudentHousingBV
{
    partial class TenantComplaint
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
            this.panelComplaints = new System.Windows.Forms.FlowLayoutPanel();
            this.lblComplaints = new System.Windows.Forms.Label();
            this.lblChoose = new System.Windows.Forms.Label();
            this.lblCustom = new System.Windows.Forms.Label();
            this.tbCustom = new System.Windows.Forms.TextBox();
            this.cbxTenants = new System.Windows.Forms.ComboBox();
            this.lblChooseATenant = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.rbTrash = new System.Windows.Forms.RadioButton();
            this.rbDirty = new System.Windows.Forms.RadioButton();
            this.rbLoud = new System.Windows.Forms.RadioButton();
            this.rbUnlocked = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panelComplaints.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelComplaints
            // 
            this.panelComplaints.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelComplaints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelComplaints.Controls.Add(this.lblComplaints);
            this.panelComplaints.Location = new System.Drawing.Point(33, 19);
            this.panelComplaints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelComplaints.Name = "panelComplaints";
            this.panelComplaints.Size = new System.Drawing.Size(290, 77);
            this.panelComplaints.TabIndex = 0;
            // 
            // lblComplaints
            // 
            this.lblComplaints.AutoSize = true;
            this.lblComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaints.Location = new System.Drawing.Point(4, 0);
            this.lblComplaints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplaints.Name = "lblComplaints";
            this.lblComplaints.Size = new System.Drawing.Size(265, 52);
            this.lblComplaints.TabIndex = 0;
            this.lblComplaints.Text = "Complaints:";
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.Location = new System.Drawing.Point(26, 173);
            this.lblChoose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(508, 37);
            this.lblChoose.TabIndex = 0;
            this.lblChoose.Text = "Choose what has bothered you: ";
            // 
            // lblCustom
            // 
            this.lblCustom.AutoSize = true;
            this.lblCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustom.Location = new System.Drawing.Point(642, 173);
            this.lblCustom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustom.Name = "lblCustom";
            this.lblCustom.Size = new System.Drawing.Size(535, 37);
            this.lblCustom.TabIndex = 0;
            this.lblCustom.Text = "Add a message to your complaint:";
            // 
            // tbCustom
            // 
            this.tbCustom.Location = new System.Drawing.Point(650, 241);
            this.tbCustom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustom.Multiline = true;
            this.tbCustom.Name = "tbCustom";
            this.tbCustom.Size = new System.Drawing.Size(644, 310);
            this.tbCustom.TabIndex = 5;
            // 
            // cbxTenants
            // 
            this.cbxTenants.FormattingEnabled = true;
            this.cbxTenants.Location = new System.Drawing.Point(650, 94);
            this.cbxTenants.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxTenants.Name = "cbxTenants";
            this.cbxTenants.Size = new System.Drawing.Size(408, 33);
            this.cbxTenants.TabIndex = 6;
            // 
            // lblChooseATenant
            // 
            this.lblChooseATenant.AutoSize = true;
            this.lblChooseATenant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblChooseATenant.Location = new System.Drawing.Point(642, 50);
            this.lblChooseATenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChooseATenant.Name = "lblChooseATenant";
            this.lblChooseATenant.Size = new System.Drawing.Size(416, 37);
            this.lblChooseATenant.TabIndex = 7;
            this.lblChooseATenant.Text = "Choose a tenant to report:";
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFile.Location = new System.Drawing.Point(650, 645);
            this.btnFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(644, 114);
            this.btnFile.TabIndex = 8;
            this.btnFile.Text = "File Complaint";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // rbTrash
            // 
            this.rbTrash.AutoSize = true;
            this.rbTrash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbTrash.Location = new System.Drawing.Point(33, 295);
            this.rbTrash.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTrash.Name = "rbTrash";
            this.rbTrash.Size = new System.Drawing.Size(305, 36);
            this.rbTrash.TabIndex = 9;
            this.rbTrash.TabStop = true;
            this.rbTrash.Text = "Trash not taken out?";
            this.rbTrash.UseVisualStyleBackColor = true;
            // 
            // rbDirty
            // 
            this.rbDirty.AutoSize = true;
            this.rbDirty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbDirty.Location = new System.Drawing.Point(33, 386);
            this.rbDirty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDirty.Name = "rbDirty";
            this.rbDirty.Size = new System.Drawing.Size(277, 36);
            this.rbDirty.TabIndex = 10;
            this.rbDirty.TabStop = true;
            this.rbDirty.Text = "Dirty living space?";
            this.rbDirty.UseVisualStyleBackColor = true;
            // 
            // rbLoud
            // 
            this.rbLoud.AutoSize = true;
            this.rbLoud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbLoud.Location = new System.Drawing.Point(33, 473);
            this.rbLoud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbLoud.Name = "rbLoud";
            this.rbLoud.Size = new System.Drawing.Size(317, 36);
            this.rbLoud.TabIndex = 11;
            this.rbLoud.TabStop = true;
            this.rbLoud.Text = "Neighbours too loud?";
            this.rbLoud.UseVisualStyleBackColor = true;
            // 
            // rbUnlocked
            // 
            this.rbUnlocked.AutoSize = true;
            this.rbUnlocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbUnlocked.Location = new System.Drawing.Point(33, 552);
            this.rbUnlocked.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbUnlocked.Name = "rbUnlocked";
            this.rbUnlocked.Size = new System.Drawing.Size(389, 36);
            this.rbUnlocked.TabIndex = 12;
            this.rbUnlocked.TabStop = true;
            this.rbUnlocked.Text = "Main door found unlocked?";
            this.rbUnlocked.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbOther.Location = new System.Drawing.Point(33, 632);
            this.rbOther.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(117, 36);
            this.rbOther.TabIndex = 12;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1193, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "*optional";
            // 
            // TenantComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1522, 862);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbUnlocked);
            this.Controls.Add(this.rbLoud);
            this.Controls.Add(this.rbDirty);
            this.Controls.Add(this.rbTrash);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblChooseATenant);
            this.Controls.Add(this.cbxTenants);
            this.Controls.Add(this.tbCustom);
            this.Controls.Add(this.lblCustom);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.panelComplaints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TenantComplaint";
            this.Text = "TenantComplaint";
            this.Load += new System.EventHandler(this.TenantComplaint_Load);
            this.panelComplaints.ResumeLayout(false);
            this.panelComplaints.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelComplaints;
        private System.Windows.Forms.Label lblComplaints;
        private System.Windows.Forms.Label lblChoose;
        private System.Windows.Forms.Label lblCustom;
        private System.Windows.Forms.TextBox tbCustom;
        private System.Windows.Forms.ComboBox cbxTenants;
        private System.Windows.Forms.Label lblChooseATenant;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.RadioButton rbTrash;
        private System.Windows.Forms.RadioButton rbDirty;
        private System.Windows.Forms.RadioButton rbLoud;
        private System.Windows.Forms.RadioButton rbUnlocked;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.Label label1;
    }
}