using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2.UIFrontEnd
{
    public class UpdateMarksConsole : IUpdateMarks<StudentCourse>
    {
        public StudentCourse ReadMarks()
        {
            StudentCourse sm = new StudentCourse();

            Console.Write("Enter the student ID : ");
            sm.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Course ID : ");
            sm.CourseId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Marks : ");
            sm.Marks = Convert.ToDecimal(Console.ReadLine());

            return sm;
        }

      
    }
}
