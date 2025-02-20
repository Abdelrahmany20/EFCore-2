using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2.Entities
{
    class courses
    {


        public int id { get; set; }
        public TimeOnly duration { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        //public int top_id { get; set; }

        [InverseProperty("courses")]
        public ICollection<topics> topics { get; set; } = new HashSet<topics>();  // many




        public ICollection<Students> Students { get; set; } = new HashSet<Students>();  // many


    }
}
