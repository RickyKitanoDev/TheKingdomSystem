using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheKingdomSystem.Management.Domain.Entities;

namespace TheKingdomSystem.Management.Database.ModelConfiguration
{
    public class AddressModelConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Street).HasColumnName("Street");
            builder.Property(p => p.City).HasColumnName("City");
            builder.Property(p => p.PostalCode).HasColumnName("PostalCode");
            builder.Property(p => p.Country).HasColumnName("Country");
        }
    }
}
