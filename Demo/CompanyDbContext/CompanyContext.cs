using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.CompanyDbContext
{
    internal class CompanyContext : DbContext
    {
        public CompanyContext() : base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =. ; Database = Company3; Trusted_Connection = true ; TrustServerCertificate = true");
        }


        DbSet<Employee> Employees { get; set; }



        }
}
