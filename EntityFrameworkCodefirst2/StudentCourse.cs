using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2
{
    public class StudentCourse
    {
        [Key]
        public int StudentCourseId { get; set; }
       
        public int StudentId { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }

        public decimal Marks {get; set;}

        public virtual Course Course { get; set; }
    }
}
