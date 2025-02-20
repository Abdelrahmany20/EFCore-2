using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2.Entities
{
    class Students
    {

        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }


        [InverseProperty("Students")]
        public Department Department { get; set; }    // one



        public ICollection<courses> courses { get; set; } = new HashSet<courses>();  // many






    }
}
