using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace PayslipDesktop.FileManager
{
    // this class will create and read records from the payslip file
    class PayslipsFileManager
    {
        // this could be setup from a form
        string inputPayslipsFilePath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\data\output-payslips.csv";
        private static PayslipsFileManager instance = null;
        private hr.Payslips payslips = new hr.Payslips();

        private PayslipsFileManager()
        {
            readFile();
        }

        // this returns the singleton instance.
        public static PayslipsFileManager getInstance()
        {
            if (instance == null)
            {
                instance = new PayslipsFileManager();
            }
            return instance;
        }

        private void readFile()
        {
            StreamReader reader = null;

            try
            {
                reader = new StreamReader(File.OpenRead(inputPayslipsFilePath));
            }
            catch (DirectoryNotFoundException dnfe)
            {
                // it's ok, we don't have payslips yet.
                Console.WriteLine("DirectoryNotFoundException {0}", dnfe.Message);
                return;
            }

            try
            {
                // we skip the header, so we read first line without soring it
                reader.ReadLine();
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine("No reader created, wrong path to file {0}", nre.Message);
                return;
            }
            catch (IOException io)
            {
                Console.WriteLine("No reader created, wrong path to file  {0}", io.Message);
                return;
            }

            try { 

                while (!reader.EndOfStream)
                {
                    String line = reader.ReadLine();
                    if(line != null && line.Trim().Count() > 0)
                    {
                        hr.Payslip payslip = new hr.Payslip(line);
                        this.payslips.add(payslip);
                    }
                }
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine("Null reference: {0}", nre.Message);
                return;
            }
            catch (IOException io)
            {
                Console.WriteLine("IOException: {0}", io.Message);
                return;
            }
        }

        public hr.Payslips getPayslips()
        {
            return payslips;
        }
    }
}
