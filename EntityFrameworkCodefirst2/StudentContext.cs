using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }  
        public DbSet<Course> Courses { get; set; }
        public DbSet<DepartmentDetail> DepartmentDetails { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }


        public StudentContext() : base("data source=127.0.0.1,1405;initial catalog=StudentContext;persist security info=True;user id=sa;password=Sql@2022!;MultipleActiveResultSets=True;App=EntityFramework")
        {

        }
    }
}
