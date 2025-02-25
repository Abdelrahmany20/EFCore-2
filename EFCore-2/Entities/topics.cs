using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2.Entities
{
    class topics
    {

        public int Id { get; set; }
        public string Name { get; set; }


        [InverseProperty("topics")]
        public virtual courses courses { get; set; }    // one



    }
}
