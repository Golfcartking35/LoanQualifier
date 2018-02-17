namespace LoanQualifier
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
            this.annualSalaryLabel = new System.Windows.Forms.Label();
            this.yearsAtJobLabel = new System.Windows.Forms.Label();
            this.annualSalaryTextBox = new System.Windows.Forms.TextBox();
            this.yearsAtJobTextBox = new System.Windows.Forms.TextBox();
            this.loanDescriptionLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.qualificationButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // annualSalaryLabel
            // 
            this.annualSalaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualSalaryLabel.Location = new System.Drawing.Point(28, 47);
            this.annualSalaryLabel.Name = "annualSalaryLabel";
            this.annualSalaryLabel.Size = new System.Drawing.Size(109, 30);
            this.annualSalaryLabel.TabIndex = 0;
            this.annualSalaryLabel.Text = "Annual Salary:";
            this.annualSalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yearsAtJobLabel
            // 
            this.yearsAtJobLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearsAtJobLabel.Location = new System.Drawing.Point(27, 119);
            this.yearsAtJobLabel.Name = "yearsAtJobLabel";
            this.yearsAtJobLabel.Size = new System.Drawing.Size(109, 30);
            this.yearsAtJobLabel.TabIndex = 1;
            this.yearsAtJobLabel.Text = "Years At Job:";
            this.yearsAtJobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // annualSalaryTextBox
            // 
            this.annualSalaryTextBox.Location = new System.Drawing.Point(187, 53);
            this.annualSalaryTextBox.Name = "annualSalaryTextBox";
            this.annualSalaryTextBox.Size = new System.Drawing.Size(110, 20);
            this.annualSalaryTextBox.TabIndex = 2;
            // 
            // yearsAtJobTextBox
            // 
            this.yearsAtJobTextBox.Location = new System.Drawing.Point(187, 125);
            this.yearsAtJobTextBox.Name = "yearsAtJobTextBox";
            this.yearsAtJobTextBox.Size = new System.Drawing.Size(110, 20);
            this.yearsAtJobTextBox.TabIndex = 3;
            // 
            // loanDescriptionLabel
            // 
            this.loanDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loanDescriptionLabel.Location = new System.Drawing.Point(12, 195);
            this.loanDescriptionLabel.Name = "loanDescriptionLabel";
            this.loanDescriptionLabel.Size = new System.Drawing.Size(163, 30);
            this.loanDescriptionLabel.TabIndex = 4;
            this.loanDescriptionLabel.Text = "Loan Description:";
            this.loanDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.descriptionLabel.Location = new System.Drawing.Point(38, 248);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(258, 51);
            this.descriptionLabel.TabIndex = 5;
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qualificationButton
            // 
            this.qualificationButton.Location = new System.Drawing.Point(198, 317);
            this.qualificationButton.Name = "qualificationButton";
            this.qualificationButton.Size = new System.Drawing.Size(98, 44);
            this.qualificationButton.TabIndex = 6;
            this.qualificationButton.Text = "Check Qualification";
            this.qualificationButton.UseVisualStyleBackColor = true;
            this.qualificationButton.Click += new System.EventHandler(this.qualificationButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(198, 378);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 44);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(39, 378);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(98, 44);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 434);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.qualificationButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.loanDescriptionLabel);
            this.Controls.Add(this.yearsAtJobTextBox);
            this.Controls.Add(this.annualSalaryTextBox);
            this.Controls.Add(this.yearsAtJobLabel);
            this.Controls.Add(this.annualSalaryLabel);
            this.Name = "Form1";
            this.Text = "Loan Qualifier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label annualSalaryLabel;
        private System.Windows.Forms.Label yearsAtJobLabel;
        private System.Windows.Forms.TextBox annualSalaryTextBox;
        private System.Windows.Forms.TextBox yearsAtJobTextBox;
        private System.Windows.Forms.Label loanDescriptionLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button qualificationButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

