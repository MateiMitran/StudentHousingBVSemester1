
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyComplaints));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tpAllAnnouncements = new System.Windows.Forms.TabPage();
            this.btnRefreshComplaintsAll = new System.Windows.Forms.Button();
            this.btnSortComplaintsByResolvedStatusAll = new System.Windows.Forms.Button();
            this.btnSortComplaintsByReadStatusAll = new System.Windows.Forms.Button();
            this.btnViewComplaintAll = new System.Windows.Forms.Button();
            this.btnSetComplaintResolvedStatusAll = new System.Windows.Forms.Button();
            this.btnSetComplaintReadStatusAll = new System.Windows.Forms.Button();
            this.lbAllComplaints = new System.Windows.Forms.ListBox();
            this.tpNewAnnouncements = new System.Windows.Forms.TabPage();
            this.btnRefreshComplaintsNew = new System.Windows.Forms.Button();
            this.btnSortComplaintsByResolvedStatusNew = new System.Windows.Forms.Button();
            this.btnSortComplaintsByReadStatusNew = new System.Windows.Forms.Button();
            this.btnViewComplaintNew = new System.Windows.Forms.Button();
            this.btnSetComplaintResolvedStatusNew = new System.Windows.Forms.Button();
            this.btnSetComplaintReadStatusNew = new System.Windows.Forms.Button();
            this.lbNewComplaints = new System.Windows.Forms.ListBox();
            this.tcComplaints = new System.Windows.Forms.TabControl();
            this.tpAllAnnouncements.SuspendLayout();
            this.tpNewAnnouncements.SuspendLayout();
            this.tcComplaints.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTitle.Location = new System.Drawing.Point(-1, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1089, 93);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Complaints";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpAllAnnouncements
            // 
            this.tpAllAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tpAllAnnouncements.Controls.Add(this.btnRefreshComplaintsAll);
            this.tpAllAnnouncements.Controls.Add(this.btnSortComplaintsByResolvedStatusAll);
            this.tpAllAnnouncements.Controls.Add(this.btnSortComplaintsByReadStatusAll);
            this.tpAllAnnouncements.Controls.Add(this.btnViewComplaintAll);
            this.tpAllAnnouncements.Controls.Add(this.btnSetComplaintResolvedStatusAll);
            this.tpAllAnnouncements.Controls.Add(this.btnSetComplaintReadStatusAll);
            this.tpAllAnnouncements.Controls.Add(this.lbAllComplaints);
            this.tpAllAnnouncements.Location = new System.Drawing.Point(8, 39);
            this.tpAllAnnouncements.Name = "tpAllAnnouncements";
            this.tpAllAnnouncements.Padding = new System.Windows.Forms.Padding(3);
            this.tpAllAnnouncements.Size = new System.Drawing.Size(1091, 669);
            this.tpAllAnnouncements.TabIndex = 1;
            this.tpAllAnnouncements.Text = "All";
            // 
            // btnRefreshComplaintsAll
            // 
            this.btnRefreshComplaintsAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshComplaintsAll.BackgroundImage")));
            this.btnRefreshComplaintsAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshComplaintsAll.Location = new System.Drawing.Point(589, 604);
            this.btnRefreshComplaintsAll.Name = "btnRefreshComplaintsAll";
            this.btnRefreshComplaintsAll.Size = new System.Drawing.Size(43, 43);
            this.btnRefreshComplaintsAll.TabIndex = 13;
            this.btnRefreshComplaintsAll.UseVisualStyleBackColor = true;
            // 
            // btnSortComplaintsByResolvedStatusAll
            // 
            this.btnSortComplaintsByResolvedStatusAll.Location = new System.Drawing.Point(15, 604);
            this.btnSortComplaintsByResolvedStatusAll.Name = "btnSortComplaintsByResolvedStatusAll";
            this.btnSortComplaintsByResolvedStatusAll.Size = new System.Drawing.Size(255, 43);
            this.btnSortComplaintsByResolvedStatusAll.TabIndex = 11;
            this.btnSortComplaintsByResolvedStatusAll.Text = "Sort by Resolved Status";
            this.btnSortComplaintsByResolvedStatusAll.UseVisualStyleBackColor = true;
            // 
            // btnSortComplaintsByReadStatusAll
            // 
            this.btnSortComplaintsByReadStatusAll.Location = new System.Drawing.Point(301, 604);
            this.btnSortComplaintsByReadStatusAll.Name = "btnSortComplaintsByReadStatusAll";
            this.btnSortComplaintsByReadStatusAll.Size = new System.Drawing.Size(255, 43);
            this.btnSortComplaintsByReadStatusAll.TabIndex = 12;
            this.btnSortComplaintsByReadStatusAll.Text = "Sort by Read Status";
            this.btnSortComplaintsByReadStatusAll.UseVisualStyleBackColor = true;
            // 
            // btnViewComplaintAll
            // 
            this.btnViewComplaintAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnViewComplaintAll.Location = new System.Drawing.Point(719, 29);
            this.btnViewComplaintAll.Name = "btnViewComplaintAll";
            this.btnViewComplaintAll.Size = new System.Drawing.Size(287, 79);
            this.btnViewComplaintAll.TabIndex = 8;
            this.btnViewComplaintAll.Text = "View";
            this.btnViewComplaintAll.UseVisualStyleBackColor = true;
            // 
            // btnSetComplaintResolvedStatusAll
            // 
            this.btnSetComplaintResolvedStatusAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSetComplaintResolvedStatusAll.Location = new System.Drawing.Point(719, 261);
            this.btnSetComplaintResolvedStatusAll.Name = "btnSetComplaintResolvedStatusAll";
            this.btnSetComplaintResolvedStatusAll.Size = new System.Drawing.Size(287, 79);
            this.btnSetComplaintResolvedStatusAll.TabIndex = 9;
            this.btnSetComplaintResolvedStatusAll.Text = "Mark as Resolved";
            this.btnSetComplaintResolvedStatusAll.UseVisualStyleBackColor = true;
            // 
            // btnSetComplaintReadStatusAll
            // 
            this.btnSetComplaintReadStatusAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSetComplaintReadStatusAll.Location = new System.Drawing.Point(719, 145);
            this.btnSetComplaintReadStatusAll.Name = "btnSetComplaintReadStatusAll";
            this.btnSetComplaintReadStatusAll.Size = new System.Drawing.Size(287, 79);
            this.btnSetComplaintReadStatusAll.TabIndex = 10;
            this.btnSetComplaintReadStatusAll.Text = "Mark as Read";
            this.btnSetComplaintReadStatusAll.UseVisualStyleBackColor = true;
            // 
            // lbAllComplaints
            // 
            this.lbAllComplaints.FormattingEnabled = true;
            this.lbAllComplaints.ItemHeight = 25;
            this.lbAllComplaints.Location = new System.Drawing.Point(16, 29);
            this.lbAllComplaints.Margin = new System.Windows.Forms.Padding(0);
            this.lbAllComplaints.Name = "lbAllComplaints";
            this.lbAllComplaints.Size = new System.Drawing.Size(616, 554);
            this.lbAllComplaints.TabIndex = 7;
            // 
            // tpNewAnnouncements
            // 
            this.tpNewAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.tpNewAnnouncements.Controls.Add(this.btnRefreshComplaintsNew);
            this.tpNewAnnouncements.Controls.Add(this.btnSortComplaintsByResolvedStatusNew);
            this.tpNewAnnouncements.Controls.Add(this.btnSortComplaintsByReadStatusNew);
            this.tpNewAnnouncements.Controls.Add(this.btnViewComplaintNew);
            this.tpNewAnnouncements.Controls.Add(this.btnSetComplaintResolvedStatusNew);
            this.tpNewAnnouncements.Controls.Add(this.btnSetComplaintReadStatusNew);
            this.tpNewAnnouncements.Controls.Add(this.lbNewComplaints);
            this.tpNewAnnouncements.Location = new System.Drawing.Point(8, 39);
            this.tpNewAnnouncements.Name = "tpNewAnnouncements";
            this.tpNewAnnouncements.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewAnnouncements.Size = new System.Drawing.Size(1091, 669);
            this.tpNewAnnouncements.TabIndex = 0;
            this.tpNewAnnouncements.Text = "New";
            // 
            // btnRefreshComplaintsNew
            // 
            this.btnRefreshComplaintsNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshComplaintsNew.BackgroundImage")));
            this.btnRefreshComplaintsNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshComplaintsNew.Location = new System.Drawing.Point(589, 604);
            this.btnRefreshComplaintsNew.Name = "btnRefreshComplaintsNew";
            this.btnRefreshComplaintsNew.Size = new System.Drawing.Size(43, 43);
            this.btnRefreshComplaintsNew.TabIndex = 7;
            this.btnRefreshComplaintsNew.UseVisualStyleBackColor = true;
            // 
            // btnSortComplaintsByResolvedStatusNew
            // 
            this.btnSortComplaintsByResolvedStatusNew.Location = new System.Drawing.Point(15, 604);
            this.btnSortComplaintsByResolvedStatusNew.Name = "btnSortComplaintsByResolvedStatusNew";
            this.btnSortComplaintsByResolvedStatusNew.Size = new System.Drawing.Size(255, 43);
            this.btnSortComplaintsByResolvedStatusNew.TabIndex = 6;
            this.btnSortComplaintsByResolvedStatusNew.Text = "Sort by Resolved Status";
            this.btnSortComplaintsByResolvedStatusNew.UseVisualStyleBackColor = true;
            // 
            // btnSortComplaintsByReadStatusNew
            // 
            this.btnSortComplaintsByReadStatusNew.Location = new System.Drawing.Point(301, 604);
            this.btnSortComplaintsByReadStatusNew.Name = "btnSortComplaintsByReadStatusNew";
            this.btnSortComplaintsByReadStatusNew.Size = new System.Drawing.Size(255, 43);
            this.btnSortComplaintsByReadStatusNew.TabIndex = 6;
            this.btnSortComplaintsByReadStatusNew.Text = "Sort by Read Status";
            this.btnSortComplaintsByReadStatusNew.UseVisualStyleBackColor = true;
            // 
            // btnViewComplaintNew
            // 
            this.btnViewComplaintNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnViewComplaintNew.Location = new System.Drawing.Point(719, 29);
            this.btnViewComplaintNew.Name = "btnViewComplaintNew";
            this.btnViewComplaintNew.Size = new System.Drawing.Size(287, 79);
            this.btnViewComplaintNew.TabIndex = 4;
            this.btnViewComplaintNew.Text = "View";
            this.btnViewComplaintNew.UseVisualStyleBackColor = true;
            // 
            // btnSetComplaintResolvedStatusNew
            // 
            this.btnSetComplaintResolvedStatusNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSetComplaintResolvedStatusNew.Location = new System.Drawing.Point(719, 261);
            this.btnSetComplaintResolvedStatusNew.Name = "btnSetComplaintResolvedStatusNew";
            this.btnSetComplaintResolvedStatusNew.Size = new System.Drawing.Size(287, 79);
            this.btnSetComplaintResolvedStatusNew.TabIndex = 5;
            this.btnSetComplaintResolvedStatusNew.Text = "Mark as Resolved";
            this.btnSetComplaintResolvedStatusNew.UseVisualStyleBackColor = true;
            // 
            // btnSetComplaintReadStatusNew
            // 
            this.btnSetComplaintReadStatusNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSetComplaintReadStatusNew.Location = new System.Drawing.Point(719, 145);
            this.btnSetComplaintReadStatusNew.Name = "btnSetComplaintReadStatusNew";
            this.btnSetComplaintReadStatusNew.Size = new System.Drawing.Size(287, 79);
            this.btnSetComplaintReadStatusNew.TabIndex = 5;
            this.btnSetComplaintReadStatusNew.Text = "Mark as Read";
            this.btnSetComplaintReadStatusNew.UseVisualStyleBackColor = true;
            // 
            // lbNewComplaints
            // 
            this.lbNewComplaints.FormattingEnabled = true;
            this.lbNewComplaints.ItemHeight = 25;
            this.lbNewComplaints.Location = new System.Drawing.Point(16, 29);
            this.lbNewComplaints.Margin = new System.Windows.Forms.Padding(0);
            this.lbNewComplaints.Name = "lbNewComplaints";
            this.lbNewComplaints.Size = new System.Drawing.Size(616, 554);
            this.lbNewComplaints.TabIndex = 0;
            // 
            // tcComplaints
            // 
            this.tcComplaints.Controls.Add(this.tpNewAnnouncements);
            this.tcComplaints.Controls.Add(this.tpAllAnnouncements);
            this.tcComplaints.Location = new System.Drawing.Point(-8, 91);
            this.tcComplaints.Margin = new System.Windows.Forms.Padding(0);
            this.tcComplaints.Name = "tcComplaints";
            this.tcComplaints.SelectedIndex = 0;
            this.tcComplaints.Size = new System.Drawing.Size(1107, 716);
            this.tcComplaints.TabIndex = 5;
            // 
            // CompanyComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 798);
            this.Controls.Add(this.tcComplaints);
            this.Controls.Add(this.lblTitle);
            this.Name = "CompanyComplaints";
            this.Text = "CompanyComplaints";
            this.tpAllAnnouncements.ResumeLayout(false);
            this.tpNewAnnouncements.ResumeLayout(false);
            this.tcComplaints.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabPage tpAllAnnouncements;
        private System.Windows.Forms.Button btnRefreshComplaintsAll;
        private System.Windows.Forms.Button btnSortComplaintsByResolvedStatusAll;
        private System.Windows.Forms.Button btnSortComplaintsByReadStatusAll;
        private System.Windows.Forms.Button btnViewComplaintAll;
        private System.Windows.Forms.Button btnSetComplaintResolvedStatusAll;
        private System.Windows.Forms.Button btnSetComplaintReadStatusAll;
        private System.Windows.Forms.ListBox lbAllComplaints;
        private System.Windows.Forms.TabPage tpNewAnnouncements;
        private System.Windows.Forms.Button btnRefreshComplaintsNew;
        private System.Windows.Forms.Button btnSortComplaintsByResolvedStatusNew;
        private System.Windows.Forms.Button btnSortComplaintsByReadStatusNew;
        private System.Windows.Forms.Button btnViewComplaintNew;
        private System.Windows.Forms.Button btnSetComplaintResolvedStatusNew;
        private System.Windows.Forms.Button btnSetComplaintReadStatusNew;
        private System.Windows.Forms.ListBox lbNewComplaints;
        private System.Windows.Forms.TabControl tcComplaints;
    }
}