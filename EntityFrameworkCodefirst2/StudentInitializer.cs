using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodefirst2
{
    public class StudentDBInitializer : DropCreateDatabaseAlways<StudentContext>
    {
        protected override void Seed(StudentContext context)
        {
            IList<Student> studentList = new List<Student>();
            IList<Institution> instutionList = new List<Institution>();
            IList<Department> departmentList = new List<Department>();
            IList<DepartmentDetail> departmentDetailsList = new List<DepartmentDetail>();
            IList<Course> courses = new List<Course>();
            IList<StudentCourse> studentCourses = new List<StudentCourse>();

            // adding Institution details
            instutionList.Add(new Institution() { Id = 1, Name = "TKM", Address = "Kollam", ContactName = "Tangal Kunju", Phone = "8934345322" });
            instutionList.Add(new Institution() { Id = 2, Name = "CET", Address = "Tvm", ContactName = "Hari", Phone = "8934345822" });
            instutionList.Add(new Institution() { Id = 3, Name = "SET", Address = "Tvm", ContactName = "Priyan", Phone = "9934345322" });

            // adding student details
            studentList.Add(new Student() { Id = 1, Name = "Abhiram", DepartmentId = 1, Dob = new DateTime(2000, 04, 03), InstitutionId = 1 });
            studentList.Add(new Student() { Id = 2, Name = "Anil", DepartmentId = 2, Dob = new DateTime(2000, 01, 01), InstitutionId = 2 });
            studentList.Add(new Student() { Id = 3, Name = "Ankit", DepartmentId = 3, Dob = new DateTime(2000, 04, 01), InstitutionId = 3 });
            studentList.Add(new Student() { Id = 4, Name = "Pranav", DepartmentId = 1, Dob = new DateTime(2000, 08, 01), InstitutionId = 1 });

            // adding Department Details
            departmentList.Add(new Department() { Id = 1, Name = "Computer" });
            departmentList.Add(new Department() { Id = 2, Name = "Mech" });
            departmentList.Add(new Department() { Id = 3, Name = "EC" });

            // department details
            departmentDetailsList.Add(new DepartmentDetail() { Id = 1, InstutionId = 1, DepartmentId = 1, HeadName = "Nisa" });
            departmentDetailsList.Add(new DepartmentDetail() { Id = 2, InstutionId = 1, DepartmentId = 2, HeadName = "Ansamma" });
            departmentDetailsList.Add(new DepartmentDetail() { Id = 3, InstutionId = 1, DepartmentId = 3, HeadName = "Sreeraj" });
            departmentDetailsList.Add(new DepartmentDetail() { Id = 4, InstutionId = 2, DepartmentId = 1, HeadName = "Anice" });
            departmentDetailsList.Add(new DepartmentDetail() { Id = 5, InstutionId = 2, DepartmentId = 2, HeadName = "Thushu" });
            departmentDetailsList.Add(new DepartmentDetail() { Id = 6, InstutionId = 2, DepartmentId = 3, HeadName = "Nikhil" });
            departmentDetailsList.Add(new DepartmentDetail() { Id = 7, InstutionId = 3, DepartmentId = 1, HeadName = "Chinju" });
            departmentDetailsList.Add(new DepartmentDetail() { Id = 8, InstutionId = 3, DepartmentId = 2, HeadName = "Malavakia" });
            departmentDetailsList.Add(new DepartmentDetail() { Id = 9, InstutionId = 3, DepartmentId = 3, HeadName = "Sangeetha" });

            // course details
            courses.Add(new Course() { Id = 1, DepartmentId = 1, Name = "cloud", Credits = 1 });
            courses.Add(new Course() { Id = 2, DepartmentId = 2, Name = "induction motor", Credits = 1 });
            courses.Add(new Course() { Id = 3, DepartmentId = 3, Name = "switch", Credits = 1 });

            // student Course
            studentCourses.Add(new StudentCourse() { StudentId = 1, CourseId = 1, Marks = 100 });
            studentCourses.Add(new StudentCourse() { StudentId = 2, CourseId = 2, Marks = 99 });
            studentCourses.Add(new StudentCourse() { StudentId = 3, CourseId = 3, Marks = 98 });
            studentCourses.Add(new StudentCourse() { StudentId = 4, CourseId = 1, Marks = 97 });

            context.Institutions.AddRange(instutionList);
            context.Students.AddRange(studentList);
            context.Departments.AddRange(departmentList);
            context.DepartmentDetails.AddRange(departmentDetailsList);
            context.Courses.AddRange(courses);
            context.StudentCourses.AddRange(studentCourses);

            base.Seed(context);
        }
    }
}
