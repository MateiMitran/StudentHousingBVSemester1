
namespace StudentHousingBV
{
    partial class TenantRules
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
            this.lblNotice = new System.Windows.Forms.Label();
            this.pnlRules = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbRules = new System.Windows.Forms.ListBox();
            this.pnlRules.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.Location = new System.Drawing.Point(12, 414);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(794, 17);
            this.lblNotice.TabIndex = 1;
            this.lblNotice.Text = "Note that the rules are subject to change by \"Student Housing BV\". Rules are plac" +
    "ed for everybody to follow";
            // 
            // pnlRules
            // 
            this.pnlRules.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlRules.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRules.Controls.Add(this.lblTitle);
            this.pnlRules.Location = new System.Drawing.Point(15, 12);
            this.pnlRules.Name = "pnlRules";
            this.pnlRules.Size = new System.Drawing.Size(113, 49);
            this.pnlRules.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(102, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Rules:";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbRules
            // 
            this.lbRules.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbRules.ForeColor = System.Drawing.Color.Maroon;
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 25;
            this.lbRules.Items.AddRange(new object[] {
            "-Always keep your surroundings as clean as possible",
            "-Have respect for the other tenants",
            "-No leaving or entering the premises without locking the front door"});
            this.lbRules.Location = new System.Drawing.Point(26, 92);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(689, 279);
            this.lbRules.TabIndex = 5;
            // 
            // TenantRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.lbRules);
            this.Controls.Add(this.pnlRules);
            this.Controls.Add(this.lblNotice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TenantRules";
            this.Text = "TenantRules";
            this.pnlRules.ResumeLayout(false);
            this.pnlRules.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.FlowLayoutPanel pnlRules;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lbRules;
    }
}