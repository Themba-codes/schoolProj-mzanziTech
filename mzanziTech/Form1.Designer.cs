namespace mzanziTech
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contractorNameTxtBox = new System.Windows.Forms.TextBox();
            this.horsTxtBox = new System.Windows.Forms.TextBox();
            this.numDependentsTxtBox = new System.Windows.Forms.TextBox();
            this.calcNetPayBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.grossPayTxtBox = new System.Windows.Forms.TextBox();
            this.netPayTxtBox = new System.Windows.Forms.TextBox();
            this.totalDeductionsTxtBox = new System.Windows.Forms.TextBox();
            this.membershipFeeTxtBox = new System.Windows.Forms.TextBox();
            this.uifTxtBox = new System.Windows.Forms.TextBox();
            this.PayeTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mzanzi Tech Contractors";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contractor Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours Worked";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number of Dependents";
            // 
            // contractorNameTxtBox
            // 
            this.contractorNameTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractorNameTxtBox.Location = new System.Drawing.Point(203, 147);
            this.contractorNameTxtBox.Name = "contractorNameTxtBox";
            this.contractorNameTxtBox.Size = new System.Drawing.Size(222, 22);
            this.contractorNameTxtBox.TabIndex = 4;
            // 
            // horsTxtBox
            // 
            this.horsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horsTxtBox.Location = new System.Drawing.Point(203, 194);
            this.horsTxtBox.Name = "horsTxtBox";
            this.horsTxtBox.Size = new System.Drawing.Size(222, 22);
            this.horsTxtBox.TabIndex = 5;
            // 
            // numDependentsTxtBox
            // 
            this.numDependentsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDependentsTxtBox.Location = new System.Drawing.Point(202, 232);
            this.numDependentsTxtBox.Name = "numDependentsTxtBox";
            this.numDependentsTxtBox.Size = new System.Drawing.Size(222, 22);
            this.numDependentsTxtBox.TabIndex = 6;
            // 
            // calcNetPayBtn
            // 
            this.calcNetPayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcNetPayBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calcNetPayBtn.Location = new System.Drawing.Point(57, 342);
            this.calcNetPayBtn.Name = "calcNetPayBtn";
            this.calcNetPayBtn.Size = new System.Drawing.Size(148, 35);
            this.calcNetPayBtn.TabIndex = 7;
            this.calcNetPayBtn.Text = "Calculate Net Pay";
            this.calcNetPayBtn.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetBtn.Location = new System.Drawing.Point(211, 342);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(72, 35);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBtn.Location = new System.Drawing.Point(297, 342);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(63, 35);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gross Pay:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(503, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "PAYE Deduction:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(555, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Net Pay:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(496, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Total Deductions:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(503, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Membership fee:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(515, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "UIF Deduction:";
            // 
            // grossPayTxtBox
            // 
            this.grossPayTxtBox.Enabled = false;
            this.grossPayTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grossPayTxtBox.Location = new System.Drawing.Point(630, 141);
            this.grossPayTxtBox.Name = "grossPayTxtBox";
            this.grossPayTxtBox.Size = new System.Drawing.Size(168, 22);
            this.grossPayTxtBox.TabIndex = 16;
            // 
            // netPayTxtBox
            // 
            this.netPayTxtBox.Enabled = false;
            this.netPayTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netPayTxtBox.Location = new System.Drawing.Point(630, 345);
            this.netPayTxtBox.Name = "netPayTxtBox";
            this.netPayTxtBox.Size = new System.Drawing.Size(168, 22);
            this.netPayTxtBox.TabIndex = 17;
            // 
            // totalDeductionsTxtBox
            // 
            this.totalDeductionsTxtBox.Enabled = false;
            this.totalDeductionsTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDeductionsTxtBox.Location = new System.Drawing.Point(630, 304);
            this.totalDeductionsTxtBox.Name = "totalDeductionsTxtBox";
            this.totalDeductionsTxtBox.Size = new System.Drawing.Size(168, 22);
            this.totalDeductionsTxtBox.TabIndex = 18;
            // 
            // membershipFeeTxtBox
            // 
            this.membershipFeeTxtBox.Enabled = false;
            this.membershipFeeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.membershipFeeTxtBox.Location = new System.Drawing.Point(630, 261);
            this.membershipFeeTxtBox.Name = "membershipFeeTxtBox";
            this.membershipFeeTxtBox.Size = new System.Drawing.Size(168, 22);
            this.membershipFeeTxtBox.TabIndex = 19;
            // 
            // uifTxtBox
            // 
            this.uifTxtBox.Enabled = false;
            this.uifTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uifTxtBox.Location = new System.Drawing.Point(630, 224);
            this.uifTxtBox.Name = "uifTxtBox";
            this.uifTxtBox.Size = new System.Drawing.Size(168, 22);
            this.uifTxtBox.TabIndex = 20;
            // 
            // PayeTxtBox
            // 
            this.PayeTxtBox.Enabled = false;
            this.PayeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayeTxtBox.Location = new System.Drawing.Point(630, 181);
            this.PayeTxtBox.Name = "PayeTxtBox";
            this.PayeTxtBox.Size = new System.Drawing.Size(168, 22);
            this.PayeTxtBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(857, 454);
            this.Controls.Add(this.PayeTxtBox);
            this.Controls.Add(this.uifTxtBox);
            this.Controls.Add(this.membershipFeeTxtBox);
            this.Controls.Add(this.totalDeductionsTxtBox);
            this.Controls.Add(this.netPayTxtBox);
            this.Controls.Add(this.grossPayTxtBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.calcNetPayBtn);
            this.Controls.Add(this.numDependentsTxtBox);
            this.Controls.Add(this.horsTxtBox);
            this.Controls.Add(this.contractorNameTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Mzanzi Tech Contractors Payroll System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox contractorNameTxtBox;
        private System.Windows.Forms.TextBox horsTxtBox;
        private System.Windows.Forms.TextBox numDependentsTxtBox;
        private System.Windows.Forms.Button calcNetPayBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox grossPayTxtBox;
        private System.Windows.Forms.TextBox netPayTxtBox;
        private System.Windows.Forms.TextBox totalDeductionsTxtBox;
        private System.Windows.Forms.TextBox membershipFeeTxtBox;
        private System.Windows.Forms.TextBox uifTxtBox;
        private System.Windows.Forms.TextBox PayeTxtBox;
    }
}

