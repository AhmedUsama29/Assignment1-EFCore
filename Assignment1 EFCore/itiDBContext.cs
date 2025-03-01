using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_EFCore
{
    class itiDBContext : DbContext
    {

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=IIZEEX;Database=iti;Trusted_Connection=True;TrustServerCertificate=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().Property(d => d.name).IsRequired();

            modelBuilder.Entity<Stud_Course>(e => 
            { 
            e.HasKey(sc => new { sc.stud_id, sc.course_id });
            } );

            modelBuilder.Entity<Course_Inst>().HasKey(ci => new { ci.inst_id, ci.course_id });

            modelBuilder.Entity<Course>()
                        .HasOne(c => c.Topic)
                        .WithMany(t => t.Courses)
                        .HasForeignKey(c => c.Topicid);

            modelBuilder.Entity<Department>()
                        .HasMany(d => d.Instructors)
                        .WithOne(i => i.Department)
                        .HasForeignKey(i => i.Dept_id);

            modelBuilder.Entity<Department>()
                        .HasOne(d => d.Manager)
                        .WithOne(i => i.ManagedDepartment)
                        .HasForeignKey<Department>(d => d.Instructorid)
                        .OnDelete(DeleteBehavior.NoAction);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
    }
}
