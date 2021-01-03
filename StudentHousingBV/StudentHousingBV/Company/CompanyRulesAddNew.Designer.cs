
namespace StudentHousingBV.Company
{
    partial class CompanyRulesAddNew
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
            this.tbCompanyRulesAddNew = new System.Windows.Forms.RichTextBox();
            this.btnAddRule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTitle.Location = new System.Drawing.Point(-1, -1);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1106, 93);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Add Rule";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbCompanyRulesAddNew
            // 
            this.tbCompanyRulesAddNew.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCompanyRulesAddNew.Location = new System.Drawing.Point(120, 144);
            this.tbCompanyRulesAddNew.Name = "tbCompanyRulesAddNew";
            this.tbCompanyRulesAddNew.Size = new System.Drawing.Size(864, 388);
            this.tbCompanyRulesAddNew.TabIndex = 3;
            this.tbCompanyRulesAddNew.Text = "";
            // 
            // btnAddRule
            // 
            this.btnAddRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRule.Location = new System.Drawing.Point(120, 572);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(864, 92);
            this.btnAddRule.TabIndex = 4;
            this.btnAddRule.Text = "Add";
            this.btnAddRule.UseVisualStyleBackColor = true;
            this.btnAddRule.Click += new System.EventHandler(this.btnAddRule_Click);
            // 
            // CompanyRulesAddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1104, 742);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.tbCompanyRulesAddNew);
            this.Controls.Add(this.lblTitle);
            this.Name = "CompanyRulesAddNew";
            this.Text = "CompanyRulesAddNew";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RichTextBox tbCompanyRulesAddNew;
        private System.Windows.Forms.Button btnAddRule;
    }
}