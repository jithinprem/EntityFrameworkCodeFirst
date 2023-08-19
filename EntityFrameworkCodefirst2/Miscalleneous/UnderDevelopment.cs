using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2.Miscalleneous
{
    public class UnderDevelopment
    {
        public static void DeleteStudent(int studentId)
        {
            using (var context = new StudentContext())
            {

                var studentToDelete = context.Students.Find(studentId);
                if (studentToDelete != null)
                {
                    context.Students.Remove(studentToDelete);
                    context.SaveChanges();
                    Console.WriteLine($"Student with ID {studentId} has been deleted.");
                }
                else
                {
                    Console.WriteLine($"Student with ID {studentId} not found.");
                }
            }
        }


        public static void UpdateStudent(int studentId, Student student)
        {
            using (var context = new StudentContext())
            {
                var studentToUpdate = context.Students.Find(studentId);
                if (studentToUpdate != null)
                {
                    studentToUpdate.Name = student.Name;
                    studentToUpdate.DepartmentId = student.DepartmentId;
                    studentToUpdate.Dob = DateTime.Today;
                    studentToUpdate.InstitutionId = student.InstitutionId;

                    // Save changes to the database
                    context.SaveChanges();

                    Console.WriteLine($"Student with ID {studentId} has been updated.");
                }
                else
                {
                    Console.WriteLine($"Student with ID {studentId} not found.");
                }
            }
        }
    }
}
