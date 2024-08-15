using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using session3.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace session3.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(e => e.Name).HasColumnType("varchar(40)");
            builder.Property(e => e.createdAt).HasComputedColumnSql("GETDATE()");
        }
    }
}
