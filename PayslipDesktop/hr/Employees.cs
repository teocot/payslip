using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayslipDesktop.hr
{

    public class Employees
    {
        private ISet<Employee> setEmployees = new HashSet<Employee>();

        public Employees(){}

        public bool add(Employee employee)
        {
            // variable ued for debugging, we could return directly from the set.
            bool employeeAdded = setEmployees.Add(employee);
            return employeeAdded;
        }

        public int count()
        {
            return setEmployees.Count;
        }
    }
}
