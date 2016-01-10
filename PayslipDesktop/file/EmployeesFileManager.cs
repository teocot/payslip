using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace PayslipDesktop.FileManager
{
    // this class will create and read records from the employees file
    class EmployeesFileManager
    {
        // this could be setup from a form
//        String inputEmployeesFilePath = @"../data/input-employees.csv";
        string inputEmployeesFilePath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\data\input-employees.csv";

        private static EmployeesFileManager instance = null;
        private hr.Employees employees = new hr.Employees();

        private EmployeesFileManager()
        {
            readFile();
        }

        // this returns the singleton instance.
        public static EmployeesFileManager getInstance()
        {
            if (instance == null)
            {
                instance = new EmployeesFileManager();
            }
            return instance;
        }

        private void readFile()
        {
            StreamReader reader = null;
            try {
                reader = new StreamReader(File.OpenRead(inputEmployeesFilePath));
            }catch(DirectoryNotFoundException dnfe)
            {
                // we should ask the user to point to the file
                Console.WriteLine("Exception : {0}", dnfe.ToString());
            }

            // we skip the header, so we read first line without soring it
            if (reader == null)
            {
                return;
            }
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                hr.Employee employee = new hr.Employee(line);
                this.employees.add(employee);
            }
        }

        // no requirements to check if the file was read many times.
        // it is read only once when the instance is created.
        // however we have to evict this, once we add employees,
        // for now there is no such facility, this deals only with payslips
        public hr.Employees getEmployees()
        {
            return employees;
        }
    }
}
