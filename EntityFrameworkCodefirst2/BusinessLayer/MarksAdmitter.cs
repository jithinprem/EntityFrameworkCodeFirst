using EntityFrameworkCodefirst2.BackEndDataOp;
using EntityFrameworkCodefirst2.UIFrontEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityFrameworkCodefirst2.BusinessLayer
{
    public class MarksAdmitter : ICrudOp<int>
    {

        public int Delete()
        {
            Console.WriteLine("code to remove score of a student, cID");
            return 0;
        }

        public int Update()
        {
            Console.WriteLine("code to Update student ");
            return 0;
        }

        public int View()
        {
            IReadStudent<int> readStudentID = new ReadUnitDetail();
            IDbOperation<StudentCourse, int> fetcher = new MarkFetcher();

            int v = readStudentID.ReadStudentDetails();
            foreach (var lisItem in fetcher.Fetch(v).ToList()) { Console.WriteLine($"student ID : {lisItem.StudentId}\ncourse ID : {lisItem.CourseId} \nmarks : {lisItem.Marks}" ); }
            return 1;
        }

        public int Add()
        {
            IDbOperation<StudentCourse, int> marksWriter = new MarkFetcher();
            IUpdateMarks<StudentCourse> updateMarksConsole = new UpdateMarksConsole();

            StudentCourse studentMarks = updateMarksConsole.ReadMarks();
            marksWriter.Write(studentMarks);
            return 0;
        }
    }
}
