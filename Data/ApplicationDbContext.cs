using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using session3.Models;
namespace session3.Data
{
    internal class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=future;Trusted_Connection=True;TrustServerCertificate=True");
    
        
        }
        //fluent api
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().Property(a=>a.Age).HasDefaultValue(22);
            modelBuilder.Entity<Employee>().Property(e=>e.Name).HasColumnType("varchar(30)");
            //modelBuilder.Entity<Employee>().ToTable("sos");
           /* modelBuilder.Entity<Department>().HasKey("DepId");
            modelBuilder.Entity<Department>().HasKey(nameof(Department.DepId));*/
           modelBuilder.Entity<Employee>().Property(n=>n.Name).HasColumnName("empName");


            modelBuilder.Entity<Department>().HasKey(d=>d.DepId);
        }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Department>Departments { get; set; }

    }
}
