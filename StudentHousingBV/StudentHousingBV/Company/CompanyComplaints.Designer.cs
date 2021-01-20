
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
            this.tbComplaintMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.lblTitle.Size = new System.Drawing.Size(467, 60);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Complaints";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbTenants
            // 
            this.cbTenants.FormattingEnabled = true;
            this.cbTenants.Location = new System.Drawing.Point(38, 94);
            this.cbTenants.Name = "cbTenants";
            this.cbTenants.Size = new System.Drawing.Size(180, 24);
            this.cbTenants.TabIndex = 5;
            // 
            // lblTenants
            // 
            this.lblTenants.AutoSize = true;
            this.lblTenants.Location = new System.Drawing.Point(35, 74);
            this.lblTenants.Name = "lblTenants";
            this.lblTenants.Size = new System.Drawing.Size(64, 17);
            this.lblTenants.TabIndex = 6;
            this.lblTenants.Text = "Tenants:";
            // 
            // lbComplaints
            // 
            this.lbComplaints.FormattingEnabled = true;
            this.lbComplaints.ItemHeight = 16;
            this.lbComplaints.Location = new System.Drawing.Point(37, 153);
            this.lbComplaints.Name = "lbComplaints";
            this.lbComplaints.Size = new System.Drawing.Size(389, 180);
            this.lbComplaints.TabIndex = 7;
            this.lbComplaints.SelectedIndexChanged += new System.EventHandler(this.lbComplaints_SelectedIndexChanged);
            // 
            // btnShowComplaints
            // 
            this.btnShowComplaints.Location = new System.Drawing.Point(239, 88);
            this.btnShowComplaints.Name = "btnShowComplaints";
            this.btnShowComplaints.Size = new System.Drawing.Size(129, 32);
            this.btnShowComplaints.TabIndex = 8;
            this.btnShowComplaints.Text = "Show Complaints";
            this.btnShowComplaints.UseVisualStyleBackColor = true;
            this.btnShowComplaints.Click += new System.EventHandler(this.btnShowComplaints_Click);
            // 
            // tbComplaintMessage
            // 
            this.tbComplaintMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbComplaintMessage.Location = new System.Drawing.Point(37, 368);
            this.tbComplaintMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbComplaintMessage.Name = "tbComplaintMessage";
            this.tbComplaintMessage.Size = new System.Drawing.Size(389, 151);
            this.tbComplaintMessage.TabIndex = 10;
            this.tbComplaintMessage.Text = "Select complaint to view complaint message.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 348);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Complaint Message:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date Created:";
            // 
            // CompanyComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbComplaintMessage);
            this.Controls.Add(this.btnShowComplaints);
            this.Controls.Add(this.lbComplaints);
            this.Controls.Add(this.lblTenants);
            this.Controls.Add(this.cbTenants);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.RichTextBox tbComplaintMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}