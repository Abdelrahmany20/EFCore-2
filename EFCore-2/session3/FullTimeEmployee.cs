using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2.session3
{
    class FullTimeEmployee : Employees
    {
        public decimal salary { get; set; }
        public DateTime startdate { get; set; }
    }
}
