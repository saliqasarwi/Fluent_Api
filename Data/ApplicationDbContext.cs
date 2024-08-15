using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using session3.Models;
using session3.Configurations;
using System.Reflection;
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
            //modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Department>Departments { get; set; }

    }
}
