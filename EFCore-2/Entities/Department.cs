using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2.Entities
{
    class Department
    {

        public int ID { get; set; }
        public string Name { get; set; }

        //public int Instractor_ID { get; set; }

        public DateOnly HiringDate { get; set; }




        [InverseProperty("Department")]
        public virtual ICollection<Students> Students { get; set; } = new HashSet<Students>();  // many


        [InverseProperty("Department")]

        public virtual ICollection<Instractors> Instractors { get; set; } = new HashSet<Instractors>();  // many




        //public Instractors? Instructors { get; set; } mange
    }
}
