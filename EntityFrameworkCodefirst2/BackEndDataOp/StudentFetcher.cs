using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2.BackEndDataOp
{
    public class StudentFetcher : IDbOperation<Student, int>
    {
        public IQueryable<Student> Fetch(int searchId) {

            using (var dbContext = new StudentContext())
            {
                try {
                    var searchStudent = (from studentRow in dbContext.Students
                                       where studentRow.Id == searchId
                                       select studentRow);
                    return searchStudent;
                }catch (Exception ex){
                    Console.WriteLine("Could't fetch file");
                    throw ex;
                }
                
            }
            
        }
        public Student Write(Student newStudent)
        {
            using (var dbContext = new StudentContext())
            {
                try {
                    dbContext.Students.Add(newStudent);
                    dbContext.SaveChanges();
                }catch (Exception ex){

                    throw new Exception("Writing Student Data Failed");
                }
                
            }
            return newStudent;
        }
    }
}
