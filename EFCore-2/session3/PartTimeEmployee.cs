using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2.session3
{
    class PartTimeEmployee : Employees
    {
        public decimal hourRate { get; set; }
        public int countOfHour { get; set; }
    }
}
