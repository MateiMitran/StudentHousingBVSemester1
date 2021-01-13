namespace StudentHousingBV
{
    partial class TenantEsentials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TenantEsentials));
            this.panelComplaints = new System.Windows.Forms.FlowLayoutPanel();
            this.lblComplaints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HouseBanklbl = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.goallbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contributionlbl = new System.Windows.Forms.Label();
            this.enoughGatheredlbl = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.panelComplaints.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelComplaints
            // 
            this.panelComplaints.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelComplaints.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelComplaints.Controls.Add(this.lblComplaints);
            this.panelComplaints.Location = new System.Drawing.Point(22, 12);
            this.panelComplaints.Name = "panelComplaints";
            this.panelComplaints.Size = new System.Drawing.Size(166, 51);
            this.panelComplaints.TabIndex = 1;
            // 
            // lblComplaints
            // 
            this.lblComplaints.AutoSize = true;
            this.lblComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplaints.Location = new System.Drawing.Point(3, 0);
            this.lblComplaints.Name = "lblComplaints";
            this.lblComplaints.Size = new System.Drawing.Size(150, 32);
            this.lblComplaints.TabIndex = 0;
            this.lblComplaints.Text = "Esentials:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 153);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // HouseBanklbl
            // 
            this.HouseBanklbl.AutoSize = true;
            this.HouseBanklbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseBanklbl.Location = new System.Drawing.Point(250, 156);
            this.HouseBanklbl.Name = "HouseBanklbl";
            this.HouseBanklbl.Size = new System.Drawing.Size(32, 36);
            this.HouseBanklbl.TabIndex = 3;
            this.HouseBanklbl.Text = "0";
            this.HouseBanklbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(22, 142);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(190, 76);
            this.addbtn.TabIndex = 4;
            this.addbtn.Text = "Add €2 to the pile!";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "/";
            // 
            // goallbl
            // 
            this.goallbl.AutoSize = true;
            this.goallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goallbl.Location = new System.Drawing.Point(294, 156);
            this.goallbl.Name = "goallbl";
            this.goallbl.Size = new System.Drawing.Size(0, 36);
            this.goallbl.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(426, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 226);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IMPORTANT!";
            // 
            // contributionlbl
            // 
            this.contributionlbl.AutoSize = true;
            this.contributionlbl.Location = new System.Drawing.Point(19, 95);
            this.contributionlbl.Name = "contributionlbl";
            this.contributionlbl.Size = new System.Drawing.Size(0, 17);
            this.contributionlbl.TabIndex = 8;
            // 
            // enoughGatheredlbl
            // 
            this.enoughGatheredlbl.AutoSize = true;
            this.enoughGatheredlbl.Location = new System.Drawing.Point(30, 280);
            this.enoughGatheredlbl.Name = "enoughGatheredlbl";
            this.enoughGatheredlbl.Size = new System.Drawing.Size(0, 17);
            this.enoughGatheredlbl.TabIndex = 9;
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEuro.Location = new System.Drawing.Point(327, 159);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(31, 32);
            this.lblEuro.TabIndex = 10;
            this.lblEuro.Text = "$";
            // 
            // TenantEsentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(819, 353);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.enoughGatheredlbl);
            this.Controls.Add(this.contributionlbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.goallbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.HouseBanklbl);
            this.Controls.Add(this.panelComplaints);
            this.Name = "TenantEsentials";
            this.Text = "Esentials";
            this.Load += new System.EventHandler(this.TenantEsentials_Load);
            this.panelComplaints.ResumeLayout(false);
            this.panelComplaints.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelComplaints;
        private System.Windows.Forms.Label lblComplaints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HouseBanklbl;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label goallbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label contributionlbl;
        private System.Windows.Forms.Label enoughGatheredlbl;
        private System.Windows.Forms.Label lblEuro;
    }
}