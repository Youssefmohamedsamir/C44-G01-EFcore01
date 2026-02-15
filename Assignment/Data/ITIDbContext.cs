using Assignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.ITIDbContext
{
    internal class ITIDbContext :DbContext
    {

        public ITIDbContext():base()
        {
        
        
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =. ; Database = ITIStudent; Trusted_Connection = true ; TrustServerCertificate = true");
        }


       
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; } 
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Instructor> Course_Instructors { get; set; }





    }
}
