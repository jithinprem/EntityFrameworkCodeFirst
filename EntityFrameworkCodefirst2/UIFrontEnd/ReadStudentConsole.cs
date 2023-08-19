using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2.UIFrontEnd
{
    public class ReadStudentConsole : IReadStudent<Student>
    {
        public Student ReadStudentDetails()
        {
            Student student = new Student();

            Console.Write("Enter the Student Name : ");
            student.Name = Console.ReadLine();
            Console.Write("Enter the DepartmentID : ");
            student.DepartmentId = Convert.ToInt32(Console.ReadLine());
            student.Dob = DateTime.Today;  // set to avoid unnessary read of date
            Console.Write("Enter the Instution ID : ");
            student.InstitutionId = Convert.ToInt32(Console.ReadLine());

            return student;
            
        }

        


    }
}
