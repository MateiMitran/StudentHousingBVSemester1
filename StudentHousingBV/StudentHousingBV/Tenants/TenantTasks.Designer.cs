
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
            this.btnFinished = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTasks
            // 
            this.pnlTasks.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pnlTasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTasks.Controls.Add(this.lblTasks);
            this.pnlTasks.Location = new System.Drawing.Point(18, 19);
            this.pnlTasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(178, 77);
            this.pnlTasks.TabIndex = 1;
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(4, 0);
            this.lblTasks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(158, 52);
            this.lblTasks.TabIndex = 0;
            this.lblTasks.Text = "Tasks:";
            // 
            // lbTasks
            // 
            this.lbTasks.FormattingEnabled = true;
            this.lbTasks.ItemHeight = 25;
            this.lbTasks.Location = new System.Drawing.Point(18, 193);
            this.lbTasks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbTasks.Name = "lbTasks";
            this.lbTasks.Size = new System.Drawing.Size(616, 479);
            this.lbTasks.TabIndex = 2;
            // 
            // btnFinished
            // 
            this.btnFinished.Location = new System.Drawing.Point(448, 50);
            this.btnFinished.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(186, 56);
            this.btnFinished.TabIndex = 3;
            this.btnFinished.Text = "Finished";
            this.btnFinished.UseVisualStyleBackColor = true;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Task:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Deadline:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(496, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Status:";
            // 
            // TenantTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(734, 703);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.lbTasks);
            this.Controls.Add(this.pnlTasks);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TenantTasks";
            this.Text = "TenantTask";
            this.Load += new System.EventHandler(this.TenantTask_Load);
            this.pnlTasks.ResumeLayout(false);
            this.pnlTasks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTasks;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.ListBox lbTasks;
        private System.Windows.Forms.Button btnFinished;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}