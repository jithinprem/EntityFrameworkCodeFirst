using EntityFrameworkCodefirst2.UIFrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2.BackEndDataOp
{
    public class MarkFetcher : IDbOperation<StudentCourse, int>
    {
        public IQueryable<StudentCourse> Fetch(int studentID)
        {
            using (var dbContext = new StudentContext()) {
                var searchMarks = (from studentRow in dbContext.StudentCourses
                                   where studentRow.StudentId == studentID
                                   select studentRow);
                return searchMarks;
            }
            
                
        }

        public StudentCourse Write(StudentCourse newMarks)
        {
            using (var dbContext = new StudentContext())
            {
                try
                {
                    dbContext.StudentCourses.Add(newMarks);
                    dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw new Exception("Marks Adding Failed");
                }
            }
            return newMarks;
        }
    }
}
