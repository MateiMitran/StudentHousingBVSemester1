
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
            this.btnViewRule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1106, 93);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Rules";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRules
            // 
            this.lbRules.FormattingEnabled = true;
            this.lbRules.ItemHeight = 25;
            this.lbRules.Items.AddRange(new object[] {
            "No leaving or entering the premises without locking the front door",
            "Always keep your surroundings as clean as possible",
            "Have respect for the other tennants"});
            this.lbRules.Location = new System.Drawing.Point(32, 128);
            this.lbRules.Name = "lbRules";
            this.lbRules.Size = new System.Drawing.Size(620, 604);
            this.lbRules.TabIndex = 2;
            // 
            // btnRemoveRule
            // 
            this.btnRemoveRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRemoveRule.Location = new System.Drawing.Point(736, 360);
            this.btnRemoveRule.Name = "btnRemoveRule";
            this.btnRemoveRule.Size = new System.Drawing.Size(287, 79);
            this.btnRemoveRule.TabIndex = 3;
            this.btnRemoveRule.Text = "Remove";
            this.btnRemoveRule.UseVisualStyleBackColor = true;
            // 
            // btnAddRule
            // 
            this.btnAddRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddRule.Location = new System.Drawing.Point(736, 128);
            this.btnAddRule.Name = "btnAddRule";
            this.btnAddRule.Size = new System.Drawing.Size(287, 79);
            this.btnAddRule.TabIndex = 3;
            this.btnAddRule.Text = "Add";
            this.btnAddRule.UseVisualStyleBackColor = true;
            // 
            // btnViewRule
            // 
            this.btnViewRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnViewRule.Location = new System.Drawing.Point(736, 244);
            this.btnViewRule.Name = "btnViewRule";
            this.btnViewRule.Size = new System.Drawing.Size(287, 79);
            this.btnViewRule.TabIndex = 3;
            this.btnViewRule.Text = "View";
            this.btnViewRule.UseVisualStyleBackColor = true;
            // 
            // CompanyRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(1104, 770);
            this.Controls.Add(this.btnAddRule);
            this.Controls.Add(this.btnViewRule);
            this.Controls.Add(this.btnRemoveRule);
            this.Controls.Add(this.lbRules);
            this.Controls.Add(this.lblTitle);
            this.Name = "CompanyRules";
            this.Text = "CompanyRules";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lbRules;
        private System.Windows.Forms.Button btnRemoveRule;
        private System.Windows.Forms.Button btnAddRule;
        private System.Windows.Forms.Button btnViewRule;
    }
}