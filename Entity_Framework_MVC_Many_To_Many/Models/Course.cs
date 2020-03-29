using System.Collections.Generic;

namespace Entity_Framework_MVC_Many_To_Many.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Course()
        {
            Students = new HashSet<Student>();
        }
    }
}