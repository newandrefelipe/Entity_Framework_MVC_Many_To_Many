using Entity_Framework_MVC_Many_To_Many.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_MVC_Many_To_Many.DAO
{
    public class StudentDAO
    {
        public void Add(Student student)
        {
            using (var context = new ManyToManyContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public IList<Student> ListAll()
        {
            using (var context = new ManyToManyContext())
            {
                return context.Students.ToList();
            }
        }

        public Student FindById(int id)
        {
            using (var context = new ManyToManyContext())
            {
                var student = context
                    .Students
                    .Include("Courses")
                    .Where(s => s.Id == id)
                    .FirstOrDefault();

                return student;
            }
        }

        public void Update(Student student)
        {
            using (var context = new ManyToManyContext())
            {
                context.Entry(student).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Remove(Student student)
        {
            using (var context = new ManyToManyContext())
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }
    }
}
