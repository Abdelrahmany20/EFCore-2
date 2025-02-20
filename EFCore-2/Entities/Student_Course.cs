using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2.Entities
{
    class Student_Course
    {

        [Key]
        public int Student_ID { get; set; }

        public int Course_ID { get; set; }
        public int Grade { get; set; }




        public Students Students { get; set; } //one


        public courses courses { get; set; } //one
    }
}
