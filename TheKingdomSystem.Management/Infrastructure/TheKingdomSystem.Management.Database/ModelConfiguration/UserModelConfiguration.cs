using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheKingdomSystem.Management.Domain.Entities;

namespace TheKingdomSystem.Management.Database.ModelConfiguration
{
    public class UserModelConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Login).HasColumnName("Login");
            builder.Property(p => p.Password).HasColumnName("Password");
            builder.Property(p => p.Status).HasColumnName("Status");
            builder.HasOne(p => p.Employee);
        }
    }
}
