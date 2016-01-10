using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayslipDesktop.hr
{
    public class Employee
    {
        String stringFirstName { get; set; }
        String stringLastName { get; set; }
        uint uintAnnualSalary { get; set; }
        uint uintSuperRate { get; set; } //super rate(%), 
        DateTime datePaymentStartDate { get; set; } // no payslips before that.

        private Employee() { }

        // we create an employee out of a line read from the employees csv file
        public Employee (String fileLine)
        {
            try
            {
                string[] values = fileLine.Split(',');
                stringFirstName = values[0];
                stringLastName = values[1];
                uintAnnualSalary = uint.Parse(values[2]);
                uintSuperRate = uint.Parse(values[3]);
                datePaymentStartDate = DateTime.ParseExact(values[4], "dd-MM-yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception e)
            {
                Console.WriteLine("couldn't create the employee, wrong input {0}", e.Message);
            }
        }
    }
}
