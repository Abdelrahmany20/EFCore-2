using EFCore_2.Entities;
using EFCore_2.session3;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_2.contexts
{
    class schemaDBcontext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("server=.;DataBase=EFcore_ITI;Trusted_Connection=true;TrustServerCertificate=true");


        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentID, sc.CourseID });

            modelBuilder.Entity<courseinstractor>().HasKey(ci=> new { ci.courseID, ci.instractorID });



            //modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employees>();
            //modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employees>();
            
        }


        public DbSet<Students> Students { get; set; }
        public DbSet<courses> courses { get; set; }
        public DbSet<Instractors> Instractors { get; set; }
        public DbSet<topics> topics { get; set; }
        public DbSet<Department> Department { get; set; }



        public DbSet<StudentCourse> StudentCourse { get; set; }
        public DbSet<courseinstractor> courseinstractor { get; set; }


        //--------------------------------------------------------------------------------//
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }


    }
}
