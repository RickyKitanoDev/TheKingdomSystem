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
    class JobTitleModelConfiguration : IEntityTypeConfiguration<JobTitle>
    {
        public void Configure(EntityTypeBuilder<JobTitle> builder)
        {
            builder.ToTable("JobTitle");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Description).HasColumnName("Desctiption");
            builder.Property(p => p.Status).HasColumnName("Status");
        }
    }
}
