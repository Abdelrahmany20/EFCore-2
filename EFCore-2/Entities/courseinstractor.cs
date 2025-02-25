using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2.Entities
{

    class courseinstractor
    {
        [ForeignKey("courses")]
        public int courseID { get; set; }

        [ForeignKey("Instractors")]

        public int instractorID { get; set; }
        public int evaluate { get; set; }




        public virtual Instractors Instractors { get; set; } // one

        public virtual courses courses { get; set; } // one

    }
}   
