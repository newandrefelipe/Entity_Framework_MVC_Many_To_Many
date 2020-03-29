using Entity_Framework_MVC_Many_To_Many.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_MVC_Many_To_Many.DAO
{
    public class CourseDAO
    {
        public void Add(Course course)
        {
            using (var context = new ManyToManyContext())
            {
                context.Courses.Add(course);
                context.SaveChanges();
            }
        }

        public IList<Course> ListAll()
        {
            using (var context = new ManyToManyContext())
            {
                return context.Courses.ToList();
            }
        }

        public Course FindById(int id)
        {
            using (var context = new ManyToManyContext())
            {
                return context.Courses.Find(id);
            }
        }

        public void Update(Course course)
        {
            using (var context = new ManyToManyContext())
            {
                context.Entry(course).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Remove(Course course)
        {
            using (var context = new ManyToManyContext())
            {
                context.Courses.Remove(course);
                context.SaveChanges();
            }
        }
    }
}
