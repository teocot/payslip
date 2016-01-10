using System;
using NUnit.Framework;
using PayslipDesktop.calc;

namespace PayslipNunit.calc
{
    [TestFixture]
    class CalculatorTest
    {

        [Test]
        public void calculatePayslip()
        {
            String stringPayslipPeriod = "Dec 2015";
            uint annualSalary = 18000;
            uint superRate = 8;

            decimal expectedGrossIncome = 1500;
            decimal expectedIncomeTax = 0.00M;
            uint expectedNetIncome = 1500;
            uint expectedSuper = 120;

            Calculator calc = new Calculator(stringPayslipPeriod, annualSalary, superRate);

            uint grossIncome = calc.getGrossIncome();
            decimal netIncome = calc.getNetIncome();
            decimal incomeTax = calc.getIncomeTax();
            decimal super = calc.getSuper();

            // this will appear in the output of the testes, 
            // we could as well use log4net for that with the 
            // console setup
            Console.WriteLine("grossIncome = {0}", grossIncome);
            Console.WriteLine("netIncome = {0}", netIncome);
            Console.WriteLine("incomeTax = {0}", incomeTax);
            Console.WriteLine("super = {0}", super);

            Assert.AreEqual(expectedGrossIncome, grossIncome);
            Assert.AreEqual(expectedNetIncome, netIncome);
            Assert.AreEqual(expectedIncomeTax, incomeTax);
            Assert.AreEqual(expectedSuper, super);

            Console.WriteLine("test passed ok");

        }

        [Test]
        // this simply tests a division by 12
        // annual salary / 12
        public void calculateGrossIncomeTest()
        {
            String stringPayslipPeriod = "Dec 2015";
            uint annualSalary = 72000;
            uint superRate = 2;

            decimal expectedGrossIncome = 6000;
            Calculator calc = new Calculator(stringPayslipPeriod, annualSalary, superRate);
            decimal grossIncome = calc.getGrossIncome();
            Console.WriteLine("annualSalary = {0} expected grossIncome = {1}, actual grossIncome = {2}", 
                                    annualSalary, expectedGrossIncome, grossIncome);
            Assert.AreEqual(expectedGrossIncome, grossIncome);

            // a salary which doens't divide exactly to 12 months
            annualSalary = 61000;

            // rounded down from 5083.(3) where (3) means .333333333333
            expectedGrossIncome = 5083;
            calc = new Calculator(stringPayslipPeriod, annualSalary, superRate);
            grossIncome = calc.getGrossIncome();
            Console.WriteLine("annualSalary = {0} expected grossIncome = {1}, actual grossIncome = {2}",
                                    annualSalary, expectedGrossIncome, grossIncome);
            Assert.AreEqual(expectedGrossIncome, grossIncome);

            Console.WriteLine("test passed ok");
        }

        [Test]
        // here we should test all the tax ranges and boundaries conditions
        // for example the tax rate changes at 18000 dollarts, we should
        // test for 17999, 18000, 18001 and 18002 dollars salary.
        // However, even after $18000, the tax is still 0, till the salary 
        // is 18231. Then the tax will be 12 dollars per year, so in the payslip
        // we can read 1 dollar/month
        public void calculateIncomeTaxTest()
        {
            String stringPayslipPeriod = "Dec 2015";
            uint annualSalary = 17999;
            uint superRate = 8;

            decimal expectedIncomeTax = 0;
            Calculator calc = new Calculator(stringPayslipPeriod, annualSalary, superRate);
            decimal incomeTax = calc.getIncomeTax();
            Console.WriteLine("annualSalary = {0} expected incomeTax = {1}, actual incomeTax = {2}", annualSalary, expectedIncomeTax, incomeTax);
            Assert.AreEqual(expectedIncomeTax, incomeTax);

            // this is the limit for which tax is 0
            stringPayslipPeriod = "Dec 2015";
            annualSalary = 18000;
            superRate = 8;

            expectedIncomeTax = 0;
            calc = new Calculator(stringPayslipPeriod, annualSalary, superRate);
            incomeTax = calc.getIncomeTax();
            Console.WriteLine("annualSalary = {0} expected incomeTax = {1}, actual incomeTax = {2}", annualSalary, expectedIncomeTax, incomeTax);
            Assert.AreEqual(expectedIncomeTax, incomeTax);

            // this is over the limit of 0 tax
            // however up to 18231, the employee still doesn't pay 
            // anything, after 18231, the tax is one dollar
            // so we can test the limit where the tax is 1 dollar.
            stringPayslipPeriod = "Dec 2015";
            annualSalary = 18231;
            superRate = 8;
            expectedIncomeTax = 0;

            calc = new Calculator(stringPayslipPeriod, annualSalary, superRate);
            incomeTax = calc.getIncomeTax();
            Console.WriteLine("annualSalary = {0} expected incomeTax = {1}, actual incomeTax = {2}", annualSalary, expectedIncomeTax, incomeTax);
            Assert.AreEqual(expectedIncomeTax, incomeTax);

            stringPayslipPeriod = "Dec 2015";
            annualSalary = 18232;
            superRate = 8;
            expectedIncomeTax = 1;
            calc = new Calculator(stringPayslipPeriod, annualSalary, superRate);
            incomeTax = calc.getIncomeTax();
            Console.WriteLine("annualSalary = {0} expected incomeTax = {1}, actual incomeTax = {2}", annualSalary, expectedIncomeTax, incomeTax);
            Assert.AreEqual(expectedIncomeTax, incomeTax);

            Console.WriteLine("test passed ok");
        }

        [Test]
        // net income is the gross income minus income tax
        public void calculateNetIncomeTest()
        {
            String stringPayslipPeriod = "Dec 2015";
            uint annualSalary = 80000;
            uint superRate = 2;

            // this is 80000/12 - 1462 = 5205
            decimal expectedNetIncome = 5205;
            Calculator calc = new Calculator(stringPayslipPeriod, annualSalary, superRate);
            decimal netIncome = calc.getNetIncome();
            Console.WriteLine("annualSalary = {0} expected net Income = {1}, actual net Income = {2}",
                                    annualSalary, expectedNetIncome, netIncome);
            Assert.AreEqual(expectedNetIncome, netIncome);

            // we should check boundary condition as well, 
            // when the tax threshold changes, here just one
            annualSalary = 180000;

            // this is 15000 gross - 4546 tax
            expectedNetIncome = 10454;
            calc = new Calculator(stringPayslipPeriod, annualSalary, superRate);
            netIncome = calc.getNetIncome();
            Console.WriteLine("annualSalary = {0} expected net Income = {1}, actual net Income = {2}",
                                    annualSalary, expectedNetIncome, netIncome);
            Assert.AreEqual(expectedNetIncome, netIncome);

            Console.WriteLine("test passed ok");

        }

        [Test]
        // this should test the formula for calculating the super, which is:
        // grossIncome * superRate / 100;
        // however this is encapsultaed in the Calculator, 
        // so we let the calculator to do it then check the result
        public void calculateSuperTest()
        {
            String stringPayslipPeriod = "Dec 2015";
            uint annualSalary = 80000;
            uint superRate = 2;

            // this is 80000/12 - 1462 = 5205
            decimal expectedSuper = 133;
            Calculator calc = new Calculator(stringPayslipPeriod, annualSalary, superRate);
            decimal super = calc.getSuper();
            Console.WriteLine("annualSalary = {0} expected super = {1}, actual super = {2}",
                                    annualSalary, expectedSuper, super);
            Assert.AreEqual(expectedSuper, super);

            // we should do more tests, like for 0%, 100%, over 100%

            Console.WriteLine("test passed ok");
        }

    }
}

