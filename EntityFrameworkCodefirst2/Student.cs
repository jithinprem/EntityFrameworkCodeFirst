using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        
        public int DepartmentId { get; set; }
        public DateTime Dob { get; set; }

        [ForeignKey("Institution")]
        public int InstitutionId { get; set; }

        public virtual Institution Institution { get; set; }
        
    }
}
