using PayslipDesktop.calc;
using PayslipDesktop.FileManager;
using PayslipDesktop.hr;
using System;
using System.Diagnostics;

using System.Windows.Forms;
using System.IO;

namespace PayslipDesktop
{
    public partial class PayslipForm : Form
    {
        //values of the controls in the form
        String stringFirstName;
        String stringLastName;
        // we assume the annual salary in an integer
        // the salary per month maybe decimal
        uint uintAnnualSalary;
        // we assume the rate % is an integer number
        uint uintSuperRate;
        String stringPayslipPeriod;

        // we set the rates to be used in the calculation
        // read the employees file, if we want to check some employees
        Employees employees = EmployeesFileManager.getInstance().getEmployees();
        // read the payslips file, in case we ask for one payslip from the file
        Payslips payslips = PayslipsFileManager.getInstance().getPayslips();

        public PayslipForm()
        {
            InitializeComponent();
            this.ActiveControl = this.textBoxFirstName;
            StartPosition = FormStartPosition.CenterScreen;
            //have to make sure it's at the top of z order
            // it can be minimized if started from the install script
            // this will be set to false, as soon as it's activated
            this.TopMost = true;
        }

        // this is the main method, which manages the main use case scenario:
        // get the payslip
        // 1. get info from user input: user and period
        // 2. search for an existing payslip for the emplyee+period
        // 2.1 if payslip is not found
        // 2.2 find rates for the employee
        // 2.3 calculates the pay slip
        // 2.4 stores the pay slip in a file or database
        // 3. get the payslip from the storage 
        // 4. displays the payslip
        private void buttonGeneratePayslip_Click(object sender, EventArgs e)
        {
            // 1. get info from user input: user and period
            getInfoFromUserInput();

            // 2. search for an existing payslip for the emplyee+period
            Payslip payslip = searchForAnExistingPayslipForUserAndPeriod();

            // 2.1 if payslip is not found
            if(payslip == null)
            {
                // 2.3 calculates the pay slip
                payslip = calculateThePaySlip();

                // 2.4 stores the pay slip in a file or database
                // for now only in memory
                payslips.add(payslip);
                // we should persist the payslip in the file
            }

            // 3. get teh payslip from teh storage
            // here we skip the step, as the payslip is in memory
            // 4. displays the payslip
            displayThePayslip(payslip);
            // done.
        }

        private void displayThePayslip(Payslip payslip)
        {
            //set the labels in the payslip
            this.labelNameValue.Text = payslip.stringFirstName + " " + payslip.stringLastName;
            this.labelGrossIncomeValue.Text = payslip.decimalGrossIncome.ToString();
            this.labelIncomeTaxValue.Text = payslip.decimalIncomeTax.ToString();
            this.labelNetIncomeValue.Text = payslip.decimalNetIncome.ToString();
            this.labelPayPeriodValue.Text = payslip.stringPayslipPeriod;
            this.labelSuperValue.Text = payslip.decimalSuper.ToString();
            this.labelAnnualSalaryValue.Text = uintAnnualSalary.ToString();
            this.labelSuperRatePayslip.Text = uintSuperRate.ToString() + "%";

        }

        private Payslip calculateThePaySlip()
        {
            Payslip payslip = new Payslip();

            //set the user details, say header of the payslip
            payslip.stringFirstName = this.stringFirstName;
            payslip.stringLastName = this.stringLastName;
            payslip.stringPayslipPeriod = this.dateTimePickerPaysleepPeriod.Value.ToString("MMM yyyy");

            // set the calculated values
            // this is mm yyyy
            // we should get the number of days after the start date of employment
            // here we assume the employee has been working the full month
            // and we don't check the employment start date
            Calculator calculator = new Calculator(stringPayslipPeriod, uintAnnualSalary, uintSuperRate);
            payslip.decimalGrossIncome = calculator.getGrossIncome();
            payslip.decimalIncomeTax = calculator.getIncomeTax();
            payslip.decimalNetIncome = calculator.getNetIncome();
            payslip.decimalSuper = calculator.getSuper();

            // ready for display
            return payslip;
        }

        private void getInfoFromUserInput()
        {
            // here we set the variables using the data from the text controls
            stringFirstName = this.textBoxFirstName.Text;
            stringLastName = this.textBoxLastName.Text;
            try {
                uintAnnualSalary = uint.Parse(this.textBoxAnnualSalary.Text);
                uintSuperRate = uint.Parse(this.textBoxSuperRate.Text);
            }
            catch (FormatException fe)
            {
                //we should validate the input, so we don't get exceptions
                Console.WriteLine("Input for annual salary or super is not an integer {0}", fe.Message);
            }
            stringPayslipPeriod = dateTimePickerPaysleepPeriod.Value.ToString("MMM yyyy");
        }

        // we could store tha payslips and return the one we searching for
        // that will be faster, no calculation required.
        private hr.Payslip searchForAnExistingPayslipForUserAndPeriod()
        {
            // for now there are no stored payslips
            // a real program would search the payslips in a file or database
            return null;
        }

        private IncomeTaxRate getRatesForIncome()
        {
            uint income = 0;
            try
            {
                income = uint.Parse(this.textBoxAnnualSalary.Text);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("annual salary shold be an integer {0}", fe.Message);
            }
            return IncomeTaxRates.getInstance().getRateForIncome(income);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGeneratePayslip_Click_1(object sender, EventArgs e)
        {
            buttonGeneratePayslip_Click(sender, e);
        }

        private void buttonCalculatorTest_Click(object sender, EventArgs e)
        {
            // For the example
            string path = Directory.GetCurrentDirectory();
//            System.Windows.Forms.MessageBox.Show(path);

            // this is to make sure that we have set the directory
            // where the application is running in  
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
//            System.Windows.Forms.MessageBox.Show(appPath);
            Directory.SetCurrentDirectory(appPath);

//            const string nunitPath = @"C:\dev\payslip\nunit\NUnit-2.6.2\bin\nunit.exe";
            const string nunitPath = @"NUnit-2.6.2\bin\nunit.exe";
//            const string dllTestsPath = @"C:\dev\payslip\git\csharp\PayslipDesktop\PayslipNunit\bin\Release\PayslipNunit.dll";
            const string dllTestsPath = @"test\PayslipNunit.dll";

            try
            {
                using (Process exeProcess = Process.Start(nunitPath, dllTestsPath))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch
            {
                Console.WriteLine("Program can't run on your platform, please contact the vendor");
            }
        }

        private void PayslipForm_Activated(object sender, EventArgs e)
        {
            //this removes the top most z order, as soon as it starts.
            if (this.TopMost)
            {
                this.TopMost = false;
            }
        }

        // allow only numbers, so the value is an integer
        private void textBoxAnnualSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // we could limit the size to 7 digits
            textBoxAnnualSalary.MaxLength = 7;
        }

        private void textBoxSuperRate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            // limit the size to 2 digits,
            // so we can't set it to 100, only between 0 and 99.
            textBoxSuperRate.MaxLength = 2;
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //first name can be made up of multiple words, letters only
            validateEntryForNames(e);
        }

        private void textBoxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //last name can be made up of multiple words, letters only
            validateEntryForNames(e);
        }
        
        // names can have any letter and spaces
        private static void validateEntryForNames(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Payslip 1.0.0 Author Teodor Cotruta, 10 Jan 2016");
        }
    }
}
