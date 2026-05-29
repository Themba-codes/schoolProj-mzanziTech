using mzanziTech;
using NUnit.Framework;

namespace payroll.nUnitTests
{
    public class calculatorTests
    {
        private calculator calculator { get; set; } =  null!;

        [SetUp]
        public void Setup()
        {
            calculator = new calculator();
        }

        //GROSS PAY TESTS
        [Test]
        [Category("Unit Test")]
        public void calcGrossPayTest_Return38000_WhenHoursIs40()
        {
            //Assign
            int hours = 40;

            //Act
            double grossPay = calculator.calcGrossPay(hours);

            Console.WriteLine($"TestContext Message:" +
                $"\nGross pay: R{grossPay}");

            Assert.That(grossPay, Is.EqualTo(38000));
        }

        //-- DEDUCTIONS TESTS --

        //UIF TEST
        [Test]
        [Category("Unit Test")]
        public void calcUifTest_Return380_WhenGrossPayIs38000()
        {
            //Assign
            double grossPay = 38000;

            //Act
            double uifDeduction = calculator.calcUifDeduction(grossPay);

            Console.WriteLine($"TestContext Message:" +
                $"\nUIF Deduction: R{uifDeduction}");

            Assert.That(uifDeduction, Is.EqualTo(380));
        }

        //PAYE TEST
        [Test]
        [Category("Unit Test")]
        public void calcPayeTest_Return8407_50_WhenGrossPayIs38000_AndNumDependentsIs2()
        {
            //Assign
            double grossPay = 38000;
            int numDependents = 2;

            //Act
            double payeDeduction = calculator.calcPayeDeduction(grossPay, numDependents);

            Console.WriteLine($"TestContext Message:" +
                $"\nPAYE Deduction: R{payeDeduction}");

            Assert.That(payeDeduction, Is.EqualTo(8407.50));
        }


        //Membership Fee TEST
        [Test]
        [Category("Unit Test")]
        public void calcMembershipFeeTest_Return4940_WhenGrossPayIs38000()
        {
            //Assign
            double grossPay = 38000;

            //Act
            double membershipFee = calculator.calcMembershipFee(grossPay);

            Console.WriteLine($"TestContext Message:" +
                $"\nMembership Fee: R{membershipFee}");

            Assert.That(membershipFee, Is.EqualTo(4940));
        }

        //Total Deductions TEST
        [Test]
        public void calcTotalDeductionsTest()
        {
            //Assign
            double grossPay = 38000;
            int numDependents = 2;

            //Act
            double totalDeductions = calculator.calcTotalDeductions(grossPay, numDependents);

            Console.WriteLine($"TestContext Message:" +
                $"\nTotal Deductions: R{totalDeductions}");

            Assert.That(totalDeductions, Is.EqualTo(5880));
        }

        //Net Pay TEST
        [Test]
        [Category("Integration Test")]
        public void calcNetPayTest_Return2427250_WhenGrossPayIs38000_AndNumDependentsIs2()
        {
            //Assign
            double grossPay = 38000;
            int numDependents = 2;

            //Act
            double netPay = calculator.calcNetPay(grossPay, numDependents);
            double uifDeduction = calculator.calcUifDeduction(grossPay);
            double payeDeduction = calculator.calcPayeDeduction(grossPay, numDependents);
            double membershipFee = calculator.calcMembershipFee(grossPay);


            Console.WriteLine($"TestContext Message:" +
                $"\nGross Pay: R{grossPay}" +
                $"\nUIF: R{uifDeduction}" +
                $"\nPAYE: R{payeDeduction}" +
                $"\nMembership Fee: R{membershipFee}" +
                $"\nNet Pay: R{netPay}");

            Assert.That(netPay, Is.EqualTo(24272.50));
        }
    }
}
