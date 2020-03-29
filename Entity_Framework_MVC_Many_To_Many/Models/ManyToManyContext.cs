using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_MVC_Many_To_Many.Models
{
    public class ManyToManyContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }

        public ManyToManyContext() : base("name=ManyToManyConnectionString")
        {
            Database.SetInitializer<ManyToManyContext>(new CreateDatabaseIfNotExists<ManyToManyContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
