namespace asprs3.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public static Model1 Create()
        {
            return new Model1();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Activity> Activities { get; set; }


    }

}