using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheKingdomSystem.Management.Domain.Entities;

namespace TheKingdomSystem.Management.Database.ModelConfiguration
{
    public class EmployeeModelConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name);
            builder.Property(p => p.Cpf);
            builder.Property(p => p.DateBirth);
            builder.Property(p => p.Gender);
            builder.Property(p => p.Photo);
            builder.Property(p => p.Status);
            builder.Property(p => p.DateOfEntry);
            builder.HasOne(p => p.JobTitle);
            builder.HasOne(p => p.Address);
        }
    }
}
