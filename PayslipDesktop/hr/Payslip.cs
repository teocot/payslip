using System;

namespace PayslipDesktop.hr
{
    // here we store the payslip data
    public class Payslip
    {
        //input 
        public uint uintAnnualSalary { get; set; }
        public decimal decimalSuperRate { get; set; }
        //Output(firstname, lastname, pay period month, payperiod year, gross income, income tax, 
        // net income, super):
        public String stringFirstName { get; set; }
        public String stringLastName{ get; set; }
        public String stringPayslipPeriod { get; set; }
        public decimal decimalGrossIncome { get; set; }
        public decimal decimalIncomeTax { get; set; }
        public decimal decimalNetIncome { get; set; }
        public decimal decimalSuper { get; set; }

        public Payslip() { }

        // we create an employee out of a line read from the employees csv file
        public Payslip(String fileLine)
        {
            try
            {
                string[] values = fileLine.Split(',');
                stringFirstName = values[0].Trim();
                stringLastName = values[1].Trim();
                stringPayslipPeriod = values[2].Trim();

                decimalGrossIncome = Decimal.Parse(values[3].Trim());
                decimalIncomeTax = Decimal.Parse(values[4].Trim());
                decimalNetIncome = Decimal.Parse(values[5].Trim());
                decimalSuper = Decimal.Parse(values[6].Trim());

                uintAnnualSalary = (uint)Math.Round(decimalGrossIncome * 12);
                decimalSuperRate = decimalSuper / 100;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("{0}: Bad Format", fe.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine("{0}: Overflow", oe.Message);
            }
            catch (Exception e)
            {
                // couldn't create the payslip, wrong input
                throw new PayslipException("Can't read the payslip from file; wrong input: " + e.Message);
            }
        }

    }
}
