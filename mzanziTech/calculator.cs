using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mzanziTech
{
    public class calculator
    {
        //hourly rate constant
        public double hourlyRate = 950.0;

        //Method to calculate gross pay
        public double calcGrossPay(int hoursWorked)
        {
            return hoursWorked * hourlyRate;
        }

        //Method to calculate UIF deduction
        public double calcUifDeduction(double grossPay)
        {
            return grossPay * 0.01; // 1% UIF deduction
        }

        //Method to calculate PAYE deduction
        public double calcPayeDeduction(double grossPay, int numDependents)
        {
            return (grossPay - (grossPay * 0.0575 * numDependents)) * 0.25; //PAYE deduction with 5.75% per dependent
        }

        //  Method to calculate membership fee
        public double calcMembershipFee(double grossPay)
        {
            return grossPay * 0.13; // 13% membership fee
        }

        // Method integrating all functions to calculate total deductions
        public double calcTotalDeductions(double grossPay, int numDependents)
        {
            double uifDeduction = calcUifDeduction(grossPay);
            double payeDeduction = calcPayeDeduction(grossPay, numDependents);
            double membershipFee = calcMembershipFee(grossPay);
            return uifDeduction + payeDeduction + membershipFee;
        }

        public double calcNetPay(double grossPay, int numDependents)
        {
            double totalDeductions = calcTotalDeductions(grossPay, numDependents);
            return grossPay - totalDeductions;
        }

        public bool test()
        {
            return false;
        }
    }
}
