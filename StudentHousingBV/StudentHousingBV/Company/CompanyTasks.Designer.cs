﻿
namespace StudentHousingBV
{
    partial class CompanyTasks
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbTrash = new System.Windows.Forms.RadioButton();
            this.rbDishes = new System.Windows.Forms.RadioButton();
            this.rbGroceries = new System.Windows.Forms.RadioButton();
            this.rbClean = new System.Windows.Forms.RadioButton();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAssign = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(62, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // rbTrash
            // 
            this.rbTrash.AutoSize = true;
            this.rbTrash.Location = new System.Drawing.Point(62, 148);
            this.rbTrash.Name = "rbTrash";
            this.rbTrash.Size = new System.Drawing.Size(121, 21);
            this.rbTrash.TabIndex = 1;
            this.rbTrash.TabStop = true;
            this.rbTrash.Text = "Take trash out";
            this.rbTrash.UseVisualStyleBackColor = true;
            // 
            // rbDishes
            // 
            this.rbDishes.AutoSize = true;
            this.rbDishes.Location = new System.Drawing.Point(62, 189);
            this.rbDishes.Name = "rbDishes";
            this.rbDishes.Size = new System.Drawing.Size(116, 21);
            this.rbDishes.TabIndex = 2;
            this.rbDishes.TabStop = true;
            this.rbDishes.Text = "Do the dishes";
            this.rbDishes.UseVisualStyleBackColor = true;
            // 
            // rbGroceries
            // 
            this.rbGroceries.AutoSize = true;
            this.rbGroceries.Location = new System.Drawing.Point(62, 237);
            this.rbGroceries.Name = "rbGroceries";
            this.rbGroceries.Size = new System.Drawing.Size(110, 21);
            this.rbGroceries.TabIndex = 3;
            this.rbGroceries.TabStop = true;
            this.rbGroceries.Text = "Do groceries";
            this.rbGroceries.UseVisualStyleBackColor = true;
            // 
            // rbClean
            // 
            this.rbClean.AutoSize = true;
            this.rbClean.Location = new System.Drawing.Point(62, 282);
            this.rbClean.Name = "rbClean";
            this.rbClean.Size = new System.Drawing.Size(158, 21);
            this.rbClean.TabIndex = 4;
            this.rbClean.TabStop = true;
            this.rbClean.Text = "Clean common room";
            this.rbClean.UseVisualStyleBackColor = true;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(62, 332);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(193, 36);
            this.btnAssign.TabIndex = 5;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblTitle.Location = new System.Drawing.Point(-7, -2);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(810, 60);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Tasks";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tenant:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Due:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(263, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 22);
            this.textBox1.TabIndex = 9;
            // 
            // lblAssign
            // 
            this.lblAssign.AutoSize = true;
            this.lblAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAssign.Location = new System.Drawing.Point(487, 225);
            this.lblAssign.Name = "lblAssign";
            this.lblAssign.Size = new System.Drawing.Size(0, 32);
            this.lblAssign.TabIndex = 10;
            // 
            // CompanyTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAssign);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.rbClean);
            this.Controls.Add(this.rbGroceries);
            this.Controls.Add(this.rbDishes);
            this.Controls.Add(this.rbTrash);
            this.Controls.Add(this.comboBox1);
            this.Name = "CompanyTasks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "CompanyTasks";
            this.Load += new System.EventHandler(this.CompanyTasks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbTrash;
        private System.Windows.Forms.RadioButton rbDishes;
        private System.Windows.Forms.RadioButton rbGroceries;
        private System.Windows.Forms.RadioButton rbClean;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAssign;
    }
}