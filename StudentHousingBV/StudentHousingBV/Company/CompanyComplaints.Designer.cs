
namespace StudentHousingBV
{
    partial class CompanyComplaints
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
            this.cbTenants = new System.Windows.Forms.ComboBox();
            this.lblTenants = new System.Windows.Forms.Label();
            this.lbComplaints = new System.Windows.Forms.ListBox();
            this.btnShowComplaints = new System.Windows.Forms.Button();
            this.btnRemoveComplaint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTitle.Location = new System.Drawing.Point(-1, -1);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(726, 60);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Complaints";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTenants
            // 
            this.cbTenants.FormattingEnabled = true;
            this.cbTenants.Location = new System.Drawing.Point(6, 89);
            this.cbTenants.Name = "cbTenants";
            this.cbTenants.Size = new System.Drawing.Size(180, 24);
            this.cbTenants.TabIndex = 5;
            // 
            // lblTenants
            // 
            this.lblTenants.AutoSize = true;
            this.lblTenants.Location = new System.Drawing.Point(3, 69);
            this.lblTenants.Name = "lblTenants";
            this.lblTenants.Size = new System.Drawing.Size(60, 17);
            this.lblTenants.TabIndex = 6;
            this.lblTenants.Text = "Tenants";
            // 
            // lbComplaints
            // 
            this.lbComplaints.FormattingEnabled = true;
            this.lbComplaints.ItemHeight = 16;
            this.lbComplaints.Location = new System.Drawing.Point(6, 130);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(211, 180);
            this.lbComplaints.TabIndex = 7;
            // 
            // btnShowComplaints
            // 
            this.btnShowComplaints.Location = new System.Drawing.Point(268, 130);
            this.btnShowComplaints.Name = "btnShowComplaints";
            this.btnShowComplaints.Size = new System.Drawing.Size(129, 32);
            this.btnShowComplaints.TabIndex = 8;
            this.btnShowComplaints.Text = "Show Complaints";
            this.btnShowComplaints.UseVisualStyleBackColor = true;
            this.btnShowComplaints.Click += new System.EventHandler(this.btnShowComplaints_Click);
            // 
            // btnRemoveComplaint
            // 
            this.btnRemoveComplaint.Location = new System.Drawing.Point(6, 341);
            this.btnRemoveComplaint.Name = "btnRemoveComplaint";
            this.btnRemoveComplaint.Size = new System.Drawing.Size(214, 36);
            this.btnRemoveComplaint.TabIndex = 9;
            this.btnRemoveComplaint.Text = "Remove Complaint";
            this.btnRemoveComplaint.UseVisualStyleBackColor = true;
            this.btnRemoveComplaint.Click += new System.EventHandler(this.btnRemoveComplaint_Click);
            // 
            // CompanyComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 511);
            this.Controls.Add(this.btnRemoveComplaint);
            this.Controls.Add(this.btnShowComplaints);
            this.Controls.Add(this.lbComplaints);
            this.Controls.Add(this.lblTenants);
            this.Controls.Add(this.cbTenants);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CompanyComplaints";
            this.Text = "CompanyComplaints";
            this.Load += new System.EventHandler(this.CompanyComplaints_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbTenants;
        private System.Windows.Forms.Label lblTenants;
        private System.Windows.Forms.ListBox lbComplaints;
        private System.Windows.Forms.Button btnShowComplaints;
        private System.Windows.Forms.Button btnRemoveComplaint;
    }
}