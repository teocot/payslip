using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayslipDesktop
{
    // this is the link between the income and the tax

    public class IncomeTaxRate
    {
        // make sure we don't create empty rates
        // so default constructor can't be called
        private IncomeTaxRate() { } 

        // we have to use this constructor  
        public IncomeTaxRate(   uint lowerTaxableIncome, 
                                uint upperTaxableIncome, 
                                uint fixedTaxAmount,
                                decimal taxPerDollar)
        {
            this.lowerTaxableIncome = lowerTaxableIncome;
            this.upperTaxableIncome = upperTaxableIncome;
            this.fixedTaxAmount = fixedTaxAmount;
            // assume this is cents, so it's <= 1
            this.taxPerDollar = taxPerDollar;
        }

        // we should not allow setters because we can be in an inconsistent state
        // the constructor is used for that.
        public uint lowerTaxableIncome { get; }
        public uint upperTaxableIncome { get; }
        // this is the least amount is charged for being in the tax rate band
        // then on top the taxPerDollar is added
        public decimal fixedTaxAmount { get; }
        public decimal taxPerDollar { get; }

    }
}
