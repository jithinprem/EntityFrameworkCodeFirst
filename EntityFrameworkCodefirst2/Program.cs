using EntityFrameworkCodefirst2;
using EntityFrameworkCodefirst2.BusinessLayer;
using EntityFrameworkCodefirst2.UIFrontEnd;
using Microsoft.VisualBasic.FileIO;
using System.Security.Cryptography;
using System.Security.Policy;

class MainClass {

    
    


    public static void FindTop() {
        using (var dbContext = new StudentContext())
        {
            var topStudents = dbContext.StudentCourses.Join(dbContext.Students, sc => sc.StudentId, s => s.Id, (sc, s) => new { StudentCourse = sc, Student = s })
                .Join(dbContext.Courses, joined => joined.StudentCourse.CourseId, c => c.Id, (joined, c) => new { joined.StudentCourse, joined.Student, Course = c })
                .GroupBy(joined => new { joined.Student.DepartmentId, joined.Student.InstitutionId })
                .Select(group => new
                {
                    DeptId = group.Key.DepartmentId,
                    InstId = group.Key.InstitutionId,
                    TopStudents = group.OrderByDescending(g => g.StudentCourse.Marks)
                                     .Take(3)
                                     .Select(g => new
                                     {
                                         StudentId = g.Student.Id,
                                         StudentName = g.Student.Name,
                                         Marks = g.StudentCourse.Marks
                                     })
                })
                .ToList();


            var studentTable = dbContext.Students;
            var courseTable = dbContext.Courses;
            var studentCourseTable = dbContext.StudentCourses;

            var markList = (from courseMarks in studentCourseTable
                            join course in courseTable
                            on courseMarks.CourseId equals course.Id
                            join student in studentTable
                            on courseMarks.StudentId equals student.Id
                            group new { c = course, cm = courseMarks, s = student } by new { InID = student.InstitutionId, StID = courseMarks.StudentId, DepID = student.DepartmentId } into g
                            orderby g.Sum(entry => entry.cm.Marks)
                            select new
                            {
                                tStudentId = g.Key.StID,
                                tStudentIn = g.Key.InID,
                                tStudentMark = g.Sum(entry => entry.cm.Marks),
                                tDpetId = g.Key.DepID

                            });
            var finalmarkList = (from mark in markList
                                 group new { m = mark } by new { inst = mark.tStudentIn, dept = mark.tDpetId } into g
                                 select new
                                 {
                                     studentId = g.Max(entry => entry.m.tStudentId),
                                     instution = g.Key.inst,
                                     department = g.Key.dept
                                 }

                                ).ToList();


            var topStudentsByInstitutionAndDept = markList
                .GroupBy(totMark => new
                {
                    totMark.tStudentIn,
                    totMark.tDpetId
                })
                .Select(group => new
                {
                    InstitutionID = group.Key.tStudentIn,
                    DeptID = group.Key.tDpetId,
                    TopStudents = group.OrderByDescending(student => student.tStudentMark)
                                        .Take(3)
                }).ToList();




            foreach (var listItem in topStudentsByInstitutionAndDept)
            {
                Console.WriteLine("INSTUTION ID : " + listItem.InstitutionID);
                Console.WriteLine("DEPARTMENT ID : " + listItem.DeptID);
                Console.Write("Topper Students ID's :");
                foreach (var studentIDs in listItem.TopStudents.ToList())
                {
                    Console.Write($"{studentIDs.tStudentId}, ");
                }
                Console.WriteLine("\n");

            }
            Console.WriteLine("\n");

        }

    }

    public static void FindLast() {

        using (var dbContext = new StudentContext())
        {
            var topStudents = dbContext.StudentCourses.Join(dbContext.Students, sc => sc.StudentId, s => s.Id, (sc, s) => new { StudentCourse = sc, Student = s })
                .Join(dbContext.Courses, joined => joined.StudentCourse.CourseId, c => c.Id, (joined, c) => new { joined.StudentCourse, joined.Student, Course = c })
                .GroupBy(joined => new { joined.Student.DepartmentId, joined.Student.InstitutionId })
                .Select(group => new
                {
                    DeptId = group.Key.DepartmentId,
                    InstId = group.Key.InstitutionId,
                    TopStudents = group.OrderByDescending(g => g.StudentCourse.Marks)
                                     .Take(3)
                                     .Select(g => new
                                     {
                                         StudentId = g.Student.Id,
                                         StudentName = g.Student.Name,
                                         Marks = g.StudentCourse.Marks
                                     })
                })
                .ToList();


            var studentTable = dbContext.Students;
            var courseTable = dbContext.Courses;
            var studentCourseTable = dbContext.StudentCourses;

            var markList = (from courseMarks in studentCourseTable
                            join course in courseTable
                            on courseMarks.CourseId equals course.Id
                            join student in studentTable
                            on courseMarks.StudentId equals student.Id
                            group new { c = course, cm = courseMarks, s = student } by new { InID = student.InstitutionId, StID = courseMarks.StudentId, DepID = student.DepartmentId } into g
                            orderby g.Sum(entry => entry.cm.Marks)
                            select new
                            {
                                tStudentId = g.Key.StID,
                                tStudentIn = g.Key.InID,
                                tStudentMark = g.Sum(entry => entry.cm.Marks),
                                tDpetId = g.Key.DepID

                            });
            var finalmarkList = (from mark in markList
                                 group new { m = mark } by new { inst = mark.tStudentIn, dept = mark.tDpetId } into g
                                 select new
                                 {
                                     studentId = g.Max(entry => entry.m.tStudentId),
                                     instution = g.Key.inst,
                                     department = g.Key.dept
                                 }

                                ).ToList();


            var topStudentsByInstitutionAndDept = markList
                .GroupBy(totMark => new
                {
                    totMark.tStudentIn,
                    totMark.tDpetId
                })
                .Select(group => new
                {
                    InstitutionID = group.Key.tStudentIn,
                    DeptID = group.Key.tDpetId,
                    TopStudents = group.OrderBy(student => student.tStudentMark)
                                        .Take(3)
                }).ToList();




            foreach (var listItem in topStudentsByInstitutionAndDept)
            {
                Console.WriteLine("INSTUTION ID : " + listItem.InstitutionID);
                Console.WriteLine("DEPARTMENT ID : " + listItem.DeptID);
                Console.Write("Topper Students ID's :");
                foreach (var studentIDs in listItem.TopStudents.ToList())
                {
                    Console.Write($"{studentIDs.tStudentId}, ");
                }
                Console.WriteLine("\n");

            }
            Console.WriteLine("\n");

        }
    }

    public static void Main()
    {

        Console.WriteLine("WELCOME TO EDU_START");
        IMenu<int> MainMenu = new MainMenu();
        ICrudOp<int> studentAdmitter = new StudentAdmitter();
        ICrudOp<int> marksAdmitter = new MarksAdmitter();

        while (true) {
            int choice = MainMenu.DisplayMenu();
            switch (choice) {
                case 1:
                    Console.WriteLine("----- Add Student ---- ");
                    studentAdmitter.Add();
                    break;
                case 2:
                    Console.WriteLine("--- Add Student Marks ---");
                    marksAdmitter.Add();
                    break;
                case 3:
                    Console.WriteLine("--- Find Top 3 Student ---");
                    FindTop();
                    break;
                case 4:
                    Console.WriteLine("--- Find LastTop 3 Student ---");
                    FindLast();
                    break;
               
            }
            
        }

    }
}