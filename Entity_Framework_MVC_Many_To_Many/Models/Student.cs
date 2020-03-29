using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_MVC_Many_To_Many.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

        public Student()
        {
            Courses = new HashSet<Course>();
        }
    }
}
