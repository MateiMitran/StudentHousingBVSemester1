
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
            this.btnViewAnnouncement = new System.Windows.Forms.Button();
            this.btnRemoveAnnouncement = new System.Windows.Forms.Button();
            this.lbAnnouncements = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAnnouncement
            // 
            this.btnAddAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddAnnouncement.Location = new System.Drawing.Point(736, 128);
            this.btnAddAnnouncement.Name = "btnAddAnnouncement";
            this.btnAddAnnouncement.Size = new System.Drawing.Size(287, 79);
            this.btnAddAnnouncement.TabIndex = 6;
            this.btnAddAnnouncement.Text = "Add";
            this.btnAddAnnouncement.UseVisualStyleBackColor = true;
            // 
            // btnViewAnnouncement
            // 
            this.btnViewAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnViewAnnouncement.Location = new System.Drawing.Point(736, 244);
            this.btnViewAnnouncement.Name = "btnViewAnnouncement";
            this.btnViewAnnouncement.Size = new System.Drawing.Size(287, 79);
            this.btnViewAnnouncement.TabIndex = 7;
            this.btnViewAnnouncement.Text = "View";
            this.btnViewAnnouncement.UseVisualStyleBackColor = true;
            // 
            // btnRemoveAnnouncement
            // 
            this.btnRemoveAnnouncement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemoveAnnouncement.Location = new System.Drawing.Point(736, 360);
            this.btnRemoveAnnouncement.Name = "btnRemoveAnnouncement";
            this.btnRemoveAnnouncement.Size = new System.Drawing.Size(287, 79);
            this.btnRemoveAnnouncement.TabIndex = 8;
            this.btnRemoveAnnouncement.Text = "Remove";
            this.btnRemoveAnnouncement.UseVisualStyleBackColor = true;
            // 
            // lbAnnouncements
            // 
            this.lbAnnouncements.FormattingEnabled = true;
            this.lbAnnouncements.ItemHeight = 25;
            this.lbAnnouncements.Location = new System.Drawing.Point(32, 128);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(620, 604);
            this.lbAnnouncements.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1106, 93);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Announcements";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompanyAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1104, 770);
            this.Controls.Add(this.btnAddAnnouncement);
            this.Controls.Add(this.btnViewAnnouncement);
            this.Controls.Add(this.btnRemoveAnnouncement);
            this.Controls.Add(this.lbAnnouncements);
            this.Controls.Add(this.lblTitle);
            this.Name = "CompanyAnnouncements";
            this.Text = "CompanyAnnouncements";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAnnouncement;
        private System.Windows.Forms.Button btnViewAnnouncement;
        private System.Windows.Forms.Button btnRemoveAnnouncement;
        private System.Windows.Forms.ListBox lbAnnouncements;
        private System.Windows.Forms.Label lblTitle;
    }
}