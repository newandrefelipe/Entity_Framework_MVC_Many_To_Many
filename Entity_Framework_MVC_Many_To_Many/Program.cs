using Entity_Framework_MVC_Many_To_Many.DAO;
using Entity_Framework_MVC_Many_To_Many.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_MVC_Many_To_Many
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting");

            //AddCourses();
            //AddStudents();
            UpdateWithRelationship();
            //AddWithRelationship();

            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void AddWithRelationship()
        {
            var course = new Course()
            {
                Name = "Test Course"
            };

            var student = new Student()
            {
                Name = "Test Student",
            };

            student.Courses.Add(course);

            var courseDAO = new CourseDAO();
            var studentDAO = new StudentDAO();

            courseDAO.Add(course);
            studentDAO.Add(student);
        }

        private static void UpdateWithRelationship()
        {
            var courseDAO = new CourseDAO();
            var studentDAO = new StudentDAO();

            var course1 = courseDAO.FindById(1);
            var course2 = courseDAO.FindById(2);

            var student1 = studentDAO.FindById(1);
            student1.Courses.Add(course1);
            student1.Courses.Add(course2);

            studentDAO.Update(student1);
        }

        private static void AddStudents()
        {
            var student1 = new Student()
            {
                Name = "André Felipe"
            };

            var student2 = new Student()
            {
                Name = "João da Silva"
            };

            var student3 = new Student()
            {
                Name = "Mario Gomes"
            };

            var student4 = new Student()
            {
                Name = "Maria Santos"
            };

            var dao = new StudentDAO();
            dao.Add(student1);
            dao.Add(student2);
            dao.Add(student3);
            dao.Add(student4);
        }

        private static void AddCourses()
        {
            var course1 = new Course()
            {
                Name = "Entity Framework 6"
            };

            var course2 = new Course()
            {
                Name = "ASP.NET MVC 5"
            };

            var course3 = new Course()
            {
                Name = "Complete C#"
            };

            var dao = new CourseDAO();
            dao.Add(course1);
            dao.Add(course2);
            dao.Add(course3);
        }
    }
}
