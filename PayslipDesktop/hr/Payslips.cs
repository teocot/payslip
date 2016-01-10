using System;
using System.Collections.Generic;

namespace PayslipDesktop.hr
{
    //----------------------------------------------------------------------------
    // here we load all the payslips 
    // we assume there is ony a small number of payslips in the storage,
    // the ones that employess already seen. 
    // not many of them, however we don't want to load all the existing payslips
    //----------------------------------------------------------------------------
    class Payslips
    {
        private ISet<Payslip> iSetPayslips = new HashSet<Payslip>();

        public Payslips()
        {
            //empty constructor, then we add payslips
        }

        // this can be called from reading a file with payslips, 
        // or after calculating a payslip
        // we may require same methods for the payslips
        // so next run will find them, but for that we require an installer
        // for the program
        public void add(Payslip payslip)
        {
            iSetPayslips.Add(payslip);
        }

        public bool hasPayslip(Payslips payslip)
        {
            foreach (Payslip iteratorPayslip in iSetPayslips)
            {
                if (iteratorPayslip.Equals(payslip)){
                    return true;
                }
            }
            return false;
        }

        // we assuming there is only one employee with those names and one payslip per month
        public Payslip getPayslip(String stringFirstName,
                                    String stringLastName,
                                    String stringPayslipPeriod)//,
//                                    uint uintAnnualSalary,
  //                                  uint uintSuperRate)
        {
            if (stringFirstName == null ||
                stringLastName == null ||
                stringPayslipPeriod == null)
            {
                return null;
            }

            foreach (Payslip iteratorPayslip in iSetPayslips)
            {
                if (iteratorPayslip != null &&
                    iteratorPayslip.stringFirstName.Equals(stringFirstName) &&
                    iteratorPayslip.stringLastName.Equals(stringLastName) &&
                    iteratorPayslip.stringPayslipPeriod.Equals(stringPayslipPeriod) //&&
//                    iteratorPayslip.uintGrossIncome.Equals(uintAnnualSalary) &&
  //                  iteratorPayslip.uintSuper.Equals(uintSuperRate)
                    )
                {
                    return iteratorPayslip;
                }
            }
            return null;
        }
    }
}
