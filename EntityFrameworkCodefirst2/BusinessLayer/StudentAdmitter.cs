using EntityFrameworkCodefirst2.BackEndDataOp;
using EntityFrameworkCodefirst2.UIFrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2.BusinessLayer
{
    public class StudentAdmitter : ICrudOp<int>
    {
       
        public int Delete()
        {
            Console.WriteLine("code to delete student ");
            return 0;
        }

        public int Update()
        {
            Console.WriteLine("code to Update student ");
            return 0;
        }

        public int View()
        {
            Console.WriteLine("Code to view ");
            return 0;   
        }

        public int Add()
        {
            IReadStudent<Student> studentReader = new ReadStudentConsole();
            IDbOperation<Student, int> studentFetcher = new StudentFetcher();

            Student newStudent = studentReader.ReadStudentDetails();
            studentFetcher.Write(newStudent);
            
            return 0;
        }
    }
}
