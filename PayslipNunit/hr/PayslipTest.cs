using NUnit.Framework;
using PayslipDesktop.hr;
using System;

namespace PayslipNunit.hr
{
    [TestFixture]
    public class PayslipTest
    {
        // here we test the payslip constructor, 
        // which takes a line with values delimited by ","
        [Test]
        public void createPayslipFromLineStringTest()
        {
            string payslipLine1FromFile = "David, Rudd,Mar 2015,5004,922,4082,450";
            Payslip payslip1 = new Payslip(payslipLine1FromFile);
            Assert.AreEqual(payslip1.stringFirstName , "David" );
            Assert.AreEqual(payslip1.stringLastName, "Rudd");
            Assert.AreEqual(payslip1.stringPayslipPeriod, "Mar 2015");
            Assert.AreEqual(payslip1.decimalGrossIncome, 5004);
            Assert.AreEqual(payslip1.decimalIncomeTax, 922);
            Assert.AreEqual(payslip1.decimalNetIncome, 4082);
            Assert.AreEqual(payslip1.decimalSuper, 450);

            string payslipLine2FromFile = "Ryan, Chen , Mar 2015 , 10000 , 2696, 7304, 1000";
            Payslip payslip2 = new Payslip(payslipLine2FromFile);

            Assert.AreEqual(payslip2.stringFirstName, "Ryan");
            Assert.AreEqual(payslip2.stringLastName, "Chen");
            Assert.AreEqual(payslip2.stringPayslipPeriod, "Mar 2015");
            Assert.AreEqual(payslip2.decimalGrossIncome, 10000);
            Assert.AreEqual(payslip2.decimalIncomeTax, 2696);
            Assert.AreEqual(payslip2.decimalNetIncome, 7304);
            Assert.AreEqual(payslip2.decimalSuper, 1000);

            string payslipLine3FromFile = "Teodor, Cotruta, Apr 2012 , 1235.5, 912.2, 25.5, 17.99";
            try {
                Payslip payslip3 = new Payslip(payslipLine3FromFile);

                Assert.AreEqual(payslip3.stringFirstName, "Teodor");
                Assert.AreEqual(payslip3.stringLastName, "Cotruta");
                Assert.AreEqual(payslip3.stringPayslipPeriod, "Apr 2012");

                // the right hand side is converted to decimal, implicitely 
                Assert.AreEqual(payslip3.decimalGrossIncome, 1235.5);
                Assert.AreEqual(payslip3.decimalIncomeTax, 912.2);
                Assert.AreEqual(payslip3.decimalNetIncome, 25.5);
                Assert.AreEqual(payslip3.decimalSuper, 17.99);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("{0}: Bad Format", fe.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("{0}: Overflow", oe.Message);
            }
            catch(PayslipException pe)
            {
                Console.WriteLine("{0}: Overflow", pe.Message);
            }
        }
    }
}
