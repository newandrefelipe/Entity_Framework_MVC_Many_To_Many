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

            Console.WriteLine("Done");

            Console.ReadKey();
        }
    }
}
