using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2
{
    public class Department
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
       
    }
}
