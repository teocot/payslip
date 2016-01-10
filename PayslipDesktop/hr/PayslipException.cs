using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PayslipDesktop.hr
{
    public class PayslipException : Exception
    {
        public PayslipException(string message) : base(message)
        {
        }
    }
}
