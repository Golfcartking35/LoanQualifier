using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanQualifier
{
    public partial class Form1 : Form
    {
        //Define Qualification Constants
        const decimal MIN_SALARY = 40000m;
        const double MIN_YEARS_AT_JOB = 2.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void qualificationButton_Click(object sender, EventArgs e)
        {
            //Clear descriptionLabel
            descriptionLabel.Text = "";
            
            //Take User inputs
            decimal salary = decimal.Parse(annualSalaryTextBox.Text);
            double yearsAtJob = double.Parse(yearsAtJobTextBox.Text);

            //Make Decisions
            if (salary >= MIN_SALARY)
            {
                if (yearsAtJob >= MIN_YEARS_AT_JOB)
                {
                    descriptionLabel.Text = "You are pre-qualified for a loan.";
                }
                else
                {
                    descriptionLabel.Text = 
                        $"You need at least {MIN_YEARS_AT_JOB} years at your job to be pre-qualified.";
                }
            }
            else
            {
                descriptionLabel.Text =
                    $"You need at least {MIN_SALARY} per year to be pre-qualified.";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            descriptionLabel.Text = "";
            annualSalaryTextBox.Clear();
            yearsAtJobTextBox.Clear();

            annualSalaryTextBox.Focus();
        }
    }
}
