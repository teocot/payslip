using PayslipDesktop.hr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayslipDesktop.calc
{
    // this calculates the payslip
    // How to use it
    // Create a calculator
    // get the values out of hte new created object
    // How it works:
    // the constructor sets the values required by the calculator 
    //  then calls calculate to calculates the results
    // the results are available in getters 
    // there are no setters for the values, and the use of the calculator is atomic
    // we only create an instance and use that instance right away to get the values
    public class Calculator
    {
        // input values
        // through the constructor only
        // no setters to avoid inconsistent states for the calculator
        private String payPeriodStart; // derived value, from teh period, we assume first day of the month
        private String payPeriodEnd; // derived value, from the period, we assume last day of the month
        private uint annualSalary; // this is per year
        private uint superRate; // 2 means 2%

        // storage values, we return calling methods, not getters, 
        // to avoid any possible race conditions.
        private uint grossIncome;
        private decimal incomeTax;
        private decimal netIncome;
        private decimal super;

        // can't call it, have to set the values in the overloaded contructor
        private Calculator() { }

        /**
         •       pay period = per calendar month
         •       gross income = annual salary / 12 months
         •       income tax = based on the tax table provide below
         •       net income = gross income - income tax
         •       super = gross income x super rate
         */
        public Calculator(String stringPayslipPeriod, uint annualSalary, uint superRate)
        {
            this.payPeriodStart = getPeriodStart(stringPayslipPeriod);
            this.payPeriodEnd = getPeriodEnd(stringPayslipPeriod);
            this.annualSalary = annualSalary;
            this.superRate = superRate;

            // this will set all the values, so we always have a consistent state
            // where the values are all together the results of the calculation
            calculate();
        }

        private String getPeriodStart(String stringPayslipPeriod)
        {
            return "01-" + stringPayslipPeriod;
        }

        // TODO: dates manipulation or a case "month"
        private String getPeriodEnd(String stringPayslipPeriod)
        {
            return "31-" + stringPayslipPeriod;
        }

        // made it public so we can test it.
        public IncomeTaxRate getIrdIncomeTaxRate(uint salary)
        {
            IncomeTaxRate incomeTaxRate = null;
            incomeTaxRate = IncomeTaxRates.getInstance().getRateForIncome(salary);

            return incomeTaxRate;
        }

        /*
        •       pay period = per calendar month
        •       gross income = annual salary / 12 months
        •       income tax = based on the tax table provide below
        •       net income = gross income - income tax
        •       super = gross income x super rate
        */
        // could be public, no difference, just we could test it, 
        // but how do we access the values?
        // maybe return a hash
        private int calculate()
        {
            //this is what we calculate:
            //    public uint grossIncome;
            //    public uint incomeTax;
            //    public uint netIncome;
            //    public uint super;

            // pay period = per calendar month
            // gross income = annual salary / 12 months
            this.grossIncome = (uint)Math.Round(this.annualSalary / 12.00);
            // income tax = based on the tax table provide below
            //just the sample here:
            // so the start tax
            IncomeTaxRate incomeTaxRate = getIrdIncomeTaxRate(annualSalary);
            // now we can calculate the band
            //            incomeTax  = (3572 + (60050 - 37000) * 0.325) / 12;
            decimal fixedTaxAmount = incomeTaxRate.fixedTaxAmount;
            // lower taxable income is one dollar ore than the basis for calculation.
            // lower is 18001 and the amount is salary-18000, it is why we have minus 1.
            uint variableTaxAmount = annualSalary - (incomeTaxRate.lowerTaxableIncome-1);
            decimal variableTaxValue = variableTaxAmount * incomeTaxRate.taxPerDollar ;
            this.incomeTax = Math.Round((fixedTaxAmount + variableTaxValue) / 12);
            //•       net income = gross income - income tax
            this.netIncome = grossIncome - (uint) incomeTax;
            //super = gross income x super rate
            // TODO: Have to manage integers divided by 100.
            // 2/100 is 0, not 0.02
            this.super = grossIncome * superRate / 100;

            return 0;
        }

        // we are always ready to get the values
        public uint getGrossIncome()
        {
            return grossIncome;
        }

        public decimal getIncomeTax()
        {
            return incomeTax;
        }

        // already calculated, as there are no default accessors.
        public decimal getNetIncome()
        {
            return netIncome;
        }
        // this was already calculated
        public decimal getSuper()
        {
            return super;
        }
    }
}
