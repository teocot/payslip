using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayslipDesktop
{
    // I prefer composition instead of inheritance to be able to wrap 
    // operations for adding values, using the problem vocabulary
    public class IncomeTaxRates // : Dictionary<int, IncomeTaxRate>
    {
//        private Dictionary<int, IncomeTaxRate> rates = new Dictionary<int, IncomeTaxRate>();
        private ISet<IncomeTaxRate> incomeTaxRates = new HashSet<IncomeTaxRate>();

        // rates valid from 1 July 2012
        // assume still valid to date
        DateTime dateValidFrom = new DateTime(2012, 7, 1);
        // long in the future, this shold be loaded from config
        DateTime dateValidTo = new DateTime(2050, 7, 1);

        /*
            The rates given are below, we construct tha table 
            instead of Nil we use 0c/dollar
            0 - $18,200     Nil
            $18,201 - $37,000       19c for each $1 over $18,200
            $37,001 - $80,000       $3,572 plus 32.5c for each $1 over $37,000
            $80,001 - $180,000      $17,547 plus 37c for each $1 over $80,000
            $180,001 and over       $54,547 plus 45c for each $1 over $180,000
        */

        private static IncomeTaxRates instance = null;
        public static IncomeTaxRates getInstance()
        {
            if(instance == null)
            {
                instance = new IncomeTaxRates();
            }
            return instance;
        }

        // this list could be dynamically loaded from a file
        // then load it from a list created using the file
        private IncomeTaxRates()
        {
            // we use variables here to be able to debug 
            // latter we can change to directly add the new values to the set
            IncomeTaxRate incomeTaxRate1 = new IncomeTaxRate(     0,     18200,     0, 0.00M );
            IncomeTaxRate incomeTaxRate2 = new IncomeTaxRate( 18201,     37000,     0, 0.19M );
            IncomeTaxRate incomeTaxRate3 = new IncomeTaxRate( 37001,     80000,  3572, 0.325M);
            IncomeTaxRate incomeTaxRate4 = new IncomeTaxRate( 80001,    180000, 17547, 0.37M );
            IncomeTaxRate incomeTaxRate5 = new IncomeTaxRate(180001, 100000000, 54547, 0.45M );

            addRate(incomeTaxRate1);
            addRate(incomeTaxRate2);
            addRate(incomeTaxRate3);
            addRate(incomeTaxRate4);
            addRate(incomeTaxRate5);

        }

        public void addRate(IncomeTaxRate incomeTaxRate)
        {
            incomeTaxRates.Add(incomeTaxRate);
        }

        // here we return the corresponding IncomeTaxRate bean
        public IncomeTaxRate getRateForIncome(uint income)
        {
            foreach(IncomeTaxRate incomeTaxRate in incomeTaxRates)
            {
                if( income >= incomeTaxRate.lowerTaxableIncome && 
                    income <= incomeTaxRate.upperTaxableIncome)
                {
                    return incomeTaxRate;
                }
            }

            // if we can't find a rate, we don't tax
            return new IncomeTaxRate(0, 0, 0, 0);
        }





    }

}
