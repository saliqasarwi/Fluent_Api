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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
