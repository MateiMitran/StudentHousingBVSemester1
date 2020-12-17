
namespace StudentHousingBV
{
    partial class TenantTasks
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
            this.pnlTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTasks = new System.Windows.Forms.Label();
            this.lbTasks = new System.Windows.Forms.ListBox();
            this.pnlTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTasks
            // 
            this.pnlTasks.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTasks.Controls.Add(this.lblTasks);
            this.pnlTasks.Location = new System.Drawing.Point(12, 12);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(120, 51);
            this.pnlTasks.TabIndex = 1;
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(3, 0);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(104, 32);
            this.lblTasks.TabIndex = 0;
            this.lblTasks.Text = "Tasks:";
            // 
            // lbTasks
            // 
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.ItemHeight = 16;
            this.lbTasks.Location = new System.Drawing.Point(15, 85);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(394, 308);
            this.lbTasks.TabIndex = 2;
            // 
            // TenantTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.lbTasks);
            this.Controls.Add(this.pnlTasks);
            this.Name = "TenantTasks";
            this.Text = "TenantTask";
            this.Load += new System.EventHandler(this.TenantTask_Load);
            this.pnlTasks.ResumeLayout(false);
            this.pnlTasks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTasks;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.ListBox lbTasks;
    }
}