
namespace StudentHousingBV
{
    partial class CompanyAnnouncements
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
            this.btnAddAnnouncement = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemoveAnnouncement = new System.Windows.Forms.Button();
            this.lbAnnouncements = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAnnouncement
            // 
            this.btnAddAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddAnnouncement.Location = new System.Drawing.Point(491, 82);
            this.btnAddAnnouncement.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAnnouncement.Name = "btnAddAnnouncement";
            this.btnAddAnnouncement.Size = new System.Drawing.Size(191, 51);
            this.btnAddAnnouncement.TabIndex = 6;
            this.btnAddAnnouncement.Text = "Add";
            this.btnAddAnnouncement.UseVisualStyleBackColor = true;
            this.btnAddAnnouncement.Click += new System.EventHandler(this.btnAddAnnouncement_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(491, 156);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 51);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemoveAnnouncement
            // 
            this.btnRemoveAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemoveAnnouncement.Location = new System.Drawing.Point(491, 230);
            this.btnRemoveAnnouncement.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAnnouncement.Name = "btnRemoveAnnouncement";
            this.btnRemoveAnnouncement.Size = new System.Drawing.Size(191, 51);
            this.btnRemoveAnnouncement.TabIndex = 8;
            this.btnRemoveAnnouncement.Text = "Remove";
            this.btnRemoveAnnouncement.UseVisualStyleBackColor = true;
            this.btnRemoveAnnouncement.Click += new System.EventHandler(this.btnRemoveAnnouncement_Click);
            // 
            // lbAnnouncements
            // 
            this.lbAnnouncements.FormattingEnabled = true;
            this.lbAnnouncements.ItemHeight = 16;
            this.lbAnnouncements.Location = new System.Drawing.Point(21, 82);
            this.lbAnnouncements.Margin = new System.Windows.Forms.Padding(2);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(415, 388);
            this.lbAnnouncements.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(737, 60);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Announcements";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(736, 493);
            this.Controls.Add(this.btnAddAnnouncement);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemoveAnnouncement);
            this.Controls.Add(this.lbAnnouncements);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CompanyAnnouncements";
            this.Text = "CompanyAnnouncements";
            this.Load += new System.EventHandler(this.CompanyAnnouncements_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnnouncement;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemoveAnnouncement;
        private System.Windows.Forms.ListBox lbAnnouncements;
        private System.Windows.Forms.Label lblTitle;
    }
}