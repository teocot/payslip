using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PayslipDesktop
{
    public partial class ReadmeForm : Form
    {
        public ReadmeForm()
        {
            InitializeComponent();
            this.textBox1.Text = "... " +
"please complete the below coding exercise. " +
"It can be done in a language of choice (but preferably C# and/ or javascript) and needs to be put into Github. " +
"We suggest candidates takes as much time as they need as we perform these tests to get a feel for" +
"how they approach problems, " +
"";
        }
    }
}
