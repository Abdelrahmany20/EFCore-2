using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2.Entities
{
    class Instractors
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public decimal bouns { get; set; }
        public decimal salary { get; set; }
        public string Address { get; set; }
        public int hourRate { get; set; }



        [InverseProperty("Instractors")]
        public virtual Department Department { get; set; } //one


        //public int DepartmentID { get; set; }//mange





        public virtual ICollection<courseinstractor> instractorscourse { get; set; } = new HashSet<courseinstractor>();  // many


    }
}
