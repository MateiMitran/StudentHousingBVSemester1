
namespace StudentHousingBV
{
    partial class CompanyRules
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
            this.lbRules = new System.Windows.Forms.ListBox();
            this.btnRemoveRule = new System.Windows.Forms.Button();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Rules";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 16;
            this.lbRules.Location = new System.Drawing.Point(21, 82);
            this.lbRules.Margin = new System.Windows.Forms.Padding(2);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(415, 388);
            this.lbRules.TabIndex = 2;
            // 
            // btnRemoveRule
            // 
            this.btnRemoveRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemoveRule.Location = new System.Drawing.Point(491, 230);
            this.btnRemoveRule.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveRule.Name = "btnRemoveRule";
            this.btnRemoveRule.Size = new System.Drawing.Size(191, 51);
            this.btnRemoveRule.TabIndex = 3;
            this.btnRemoveRule.Text = "Remove";
            this.btnRemoveRule.UseVisualStyleBackColor = true;
            this.btnRemoveRule.Click += new System.EventHandler(this.btnRemoveRule_Click);
            // 
            // btnAddRule
            // 
            this.btnAddRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddRule.Location = new System.Drawing.Point(491, 82);
            this.btnAddRule.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(191, 51);
            this.btnAddRule.TabIndex = 3;
            this.btnAddRule.Text = "Add";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.Location = new System.Drawing.Point(491, 156);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(191, 51);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnViewRule_Click);
            // 
            // CompanyRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(736, 493);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRemoveRule);
            this.Controls.Add(this.lbRules);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CompanyRules";
            this.Text = "CompanyRules";
            this.Load += new System.EventHandler(this.CompanyRules_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.Button btnRemoveRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Button btnUpdate;
    }
}