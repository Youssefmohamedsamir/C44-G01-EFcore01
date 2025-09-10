using AssignmentQ02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentQ02.DataText
{
    internal class AirDbContext : DbContext
    {
        public AirDbContext():base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =. ; Database = AirDb; Trusted_Connection = true ; TrustServerCertificate = true");
        }

        public DbSet<Route> Routes { get; set; } 

        public DbSet<Emp_Qualifications> Emp_Qualifications { get; set; }   

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Aircraft_Routes> Aircraft_Routes { get; set; }

        public DbSet<AirCraft> Aircrafts { get; set; } 

        public DbSet<Transaction> Transactions { get; set; }  

        public DbSet<Airline> Airlines { get; set; }

        public DbSet<Airline_Phones> Airline_Phones { get; set; }




    }

    
}
