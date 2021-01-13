
namespace StudentHousingBV
{
    partial class TenantAnnouncements
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
            this.pnlTitle = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNotice = new System.Windows.Forms.Label();
            this.lbAnnouncements = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.votebtn = new System.Windows.Forms.Button();
            this.voteslbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNrOfTenants = new System.Windows.Forms.Label();
            this.opinionlbl = new System.Windows.Forms.Label();
            this.eventTakesPlacelbl = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Location = new System.Drawing.Point(12, 12);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(474, 74);
            this.pnlTitle.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(446, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Announcements and Proposals:";
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(9, 424);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(623, 17);
            this.lblNotice.TabIndex = 2;
            this.lblNotice.Text = "\"Student Housing BV\" will update this tab every time an important event is schedu" +
    "led";
            // 
            // lbAnnouncements
            // 
            this.lbAnnouncements.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbAnnouncements.ForeColor = System.Drawing.Color.Maroon;
            this.lbAnnouncements.FormattingEnabled = true;
            this.lbAnnouncements.ItemHeight = 25;
            this.lbAnnouncements.Location = new System.Drawing.Point(12, 126);
            this.lbAnnouncements.Name = "lbAnnouncements";
            this.lbAnnouncements.Size = new System.Drawing.Size(422, 204);
            this.lbAnnouncements.TabIndex = 7;
            this.lbAnnouncements.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "announcements";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(553, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "proposals";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "*We want to have a pizza party at 20:00 on Friday,\r\neverybody is invited to join!" +
    "\r\n";
            // 
            // votebtn
            // 
            this.votebtn.Location = new System.Drawing.Point(582, 198);
            this.votebtn.Name = "votebtn";
            this.votebtn.Size = new System.Drawing.Size(121, 51);
            this.votebtn.TabIndex = 12;
            this.votebtn.Text = "I\'m in!";
            this.votebtn.UseVisualStyleBackColor = true;
            this.votebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // voteslbl
            // 
            this.voteslbl.AutoSize = true;
            this.voteslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteslbl.Location = new System.Drawing.Point(718, 212);
            this.voteslbl.Name = "voteslbl";
            this.voteslbl.Size = new System.Drawing.Size(18, 20);
            this.voteslbl.TabIndex = 13;
            this.voteslbl.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(733, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "/";
            // 
            // lblNrOfTenants
            // 
            this.lblNrOfTenants.AutoSize = true;
            this.lblNrOfTenants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNrOfTenants.Location = new System.Drawing.Point(742, 212);
            this.lblNrOfTenants.Name = "lblNrOfTenants";
            this.lblNrOfTenants.Size = new System.Drawing.Size(18, 20);
            this.lblNrOfTenants.TabIndex = 15;
            this.lblNrOfTenants.Text = "0";
            this.lblNrOfTenants.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // opinionlbl
            // 
            this.opinionlbl.AutoSize = true;
            this.opinionlbl.Location = new System.Drawing.Point(480, 313);
            this.opinionlbl.Name = "opinionlbl";
            this.opinionlbl.Size = new System.Drawing.Size(0, 17);
            this.opinionlbl.TabIndex = 16;
            // 
            // eventTakesPlacelbl
            // 
            this.eventTakesPlacelbl.AutoSize = true;
            this.eventTakesPlacelbl.Location = new System.Drawing.Point(565, 51);
            this.eventTakesPlacelbl.Name = "eventTakesPlacelbl";
            this.eventTakesPlacelbl.Size = new System.Drawing.Size(0, 17);
            this.eventTakesPlacelbl.TabIndex = 17;
            // 
            // TenantAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(935, 485);
            this.Controls.Add(this.eventTakesPlacelbl);
            this.Controls.Add(this.opinionlbl);
            this.Controls.Add(this.lblNrOfTenants);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.voteslbl);
            this.Controls.Add(this.votebtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAnnouncements);
            this.Controls.Add(this.lblNotice);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TenantAnnouncements";
            this.Text = "General announcements";
            this.Load += new System.EventHandler(this.TenantAnnouncements_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.ListBox lbAnnouncements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button votebtn;
        private System.Windows.Forms.Label voteslbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNrOfTenants;
        private System.Windows.Forms.Label opinionlbl;
        private System.Windows.Forms.Label eventTakesPlacelbl;
    }
}