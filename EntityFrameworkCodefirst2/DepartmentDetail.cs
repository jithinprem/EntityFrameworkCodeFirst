using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2
{
    public class DepartmentDetail
    {
        [Key]
        public int Id { get; set; }

        public int InstutionId { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public string HeadName { get; set; }

        public virtual Department Department { get; set; }

    }
}
