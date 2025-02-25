using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2.Entities
{
    class StudentCourse
    {

        [ForeignKey("Students")]
        public int StudentID { get; set; }
        [ForeignKey("courses")]
        public int CourseID { get; set; }
        public int Grade { get; set; }




        public virtual Students Students { get; set; } //one


        public virtual courses courses { get; set; } //one
    }
}
