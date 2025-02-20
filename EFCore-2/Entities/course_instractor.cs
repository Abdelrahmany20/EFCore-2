using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2.Entities
{

    class course_instractor
    {
        [Key]
        public int course_id { get; set; }
        public int instractor_id { get; set; }
        public int evaluate { get; set; }


        [InverseProperty("course_instractor")]
        public Instractors Instractors { get; set; } // one

    }
}   
