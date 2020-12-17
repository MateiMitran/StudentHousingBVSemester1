
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
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // rbTrash
            // 
            this.rbTrash.AutoSize = true;
            this.rbTrash.Location = new System.Drawing.Point(91, 93);
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
            this.rbDishes.Location = new System.Drawing.Point(91, 134);
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
            this.rbGroceries.Location = new System.Drawing.Point(91, 182);
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
            this.rbClean.Location = new System.Drawing.Point(91, 232);
            this.rbClean.Name = "rbClean";
            this.rbClean.Size = new System.Drawing.Size(158, 21);
            this.rbClean.TabIndex = 4;
            this.rbClean.TabStop = true;
            this.rbClean.Text = "Clean common room";
            this.rbClean.UseVisualStyleBackColor = true;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(91, 277);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(193, 36);
            this.btnAssign.TabIndex = 5;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = true;
            // 
            // CompanyTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.rbClean);
            this.Controls.Add(this.rbGroceries);
            this.Controls.Add(this.rbDishes);
            this.Controls.Add(this.rbTrash);
            this.Controls.Add(this.comboBox1);
            this.Name = "CompanyTasks";
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
    }
}