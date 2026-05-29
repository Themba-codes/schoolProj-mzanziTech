using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mzanziTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //exit the application
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Clear all input and output fields
            contractorNameTxtBox.Clear();
            hoursTxtBox.Clear();
            numDependentsTxtBox.Clear();

            grossPayTxtBox.Clear();
            PayeTxtBox.Clear();
            uifTxtBox.Clear();
            membershipFeeTxtBox.Clear();
            totalDeductionsTxtBox.Clear();
            netPayTxtBox.Clear();
        }

        private void calcNetPayBtn_Click(object sender, EventArgs e)
        {
            //create an instance of the calculator class
            calculator calculator = new calculator();
            
            //initialising variables
            string nameText = contractorNameTxtBox.Text;

            string hoursText = hoursTxtBox.Text;
            int hoursInt = 0;

            string dependentsText = numDependentsTxtBox.Text;
            int dependentsInt = 0;

            double grossPay = 0;
            double totalDeductions = 0;
            double netPay = 0;

            
            //Empty field validation for name
            if (string.IsNullOrEmpty(nameText))
            {
                MessageBox.Show("Please enter the contractor's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Empty field validation for hours + parsing to double
            if (string.IsNullOrEmpty(hoursText))
            {
                MessageBox.Show("Please enter the hours worked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                hoursInt = int.Parse(hoursText); //safely parse to int because value is validated in hoursTxtBox_TextChanged event handler
            }

            //empty field validation for number of dependents + parsing to int
            if (string.IsNullOrEmpty(dependentsText))
            {
                MessageBox.Show("Please enter the number of dependents.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                dependentsInt = int.Parse(dependentsText); //safely parse to int because value is validated in numDependentsTxtBox_TextChanged event handler
            }

            //calc gross pay
            grossPay = calculator.calcGrossPay((int)hoursInt);

            //display results
            displayResults(grossPay, dependentsInt);
        }

        //input validation for hours worked field. This event handler is triggered whenever the text in the hoursTxtBox changes.
        //It checks if the input is a valid number and displays an error message if it's not.
        private void hoursTxtBox_TextChanged(object sender, EventArgs e)
        {
            string hoursText = hoursTxtBox.Text;

            if (string.IsNullOrEmpty(hoursText))
            {
                return; // Allow empty input, user might be in the process of typing
            }

            //check if input is a valid number
            if (!double.TryParse(hoursText, out double hours))
            {
                MessageBox.Show("Please enter a valid number for hours worked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hoursTxtBox.Clear();
            }

            //check if hours is negative
            if (hours < 0)
            {
                MessageBox.Show("Number of hours worked cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hoursTxtBox.Clear();
            }
        }

        //input validation for number of dependents field.
        //This event handler is triggered whenever the text in the numDependentsTxtBox changes,
        //constantly ensuring that input is numeric and between 0 and 10

        private void numDependentsTxtBox_TextChanged(object sender, EventArgs e)
        {
            string numDependentsText = numDependentsTxtBox.Text;

            if (string.IsNullOrEmpty(numDependentsText))
            {
                return; // Allow empty input, user might be in the process of typing
            }

            //check if input is a valid integer
            if (!int.TryParse(numDependentsText, out int numDependents))
            {
                MessageBox.Show("Please enter an INTEGER number for the number of dependents.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numDependentsTxtBox.Clear();
            }

            //check if number of dependents is negative or greater than 10
            if (numDependents < 0 || numDependents > 10)
            {
                MessageBox.Show("Number of dependents cannot be negative or greater than 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numDependentsTxtBox.Clear();
            }
        }

        //this method is responsible for displaying the calculated results in the appropriate text boxes on the form
        private void displayResults(double grossPay, int numDependents)
        {
            calculator calculator = new calculator();

            grossPayTxtBox.Text = $"R{grossPay:F2}";
            PayeTxtBox.Text = $"R{calculator.calcPayeDeduction(grossPay, numDependents):F2}"; //returned in the following order: uifDeduction, payeDeduction, membershipFee, totalDeductions
            uifTxtBox.Text = $"R{calculator.calcUifDeduction(grossPay):F2}";
            membershipFeeTxtBox.Text = $"R{calculator.calcMembershipFee(grossPay):F2}";
            totalDeductionsTxtBox.Text = $"R{calculator.calcTotalDeductions(grossPay, numDependents):F2}";
            netPayTxtBox.Text = $"R{calculator.calcNetPay(grossPay, numDependents):F2}";
        }
    }
}
