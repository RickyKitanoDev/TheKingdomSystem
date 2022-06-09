using Microsoft.EntityFrameworkCore;
using TheKingdomSystem.Management.Database.ModelConfiguration;
using TheKingdomSystem.Management.Domain;
using TheKingdomSystem.Management.Domain.Entities;                                                                                                                                                                                                                                                                          
namespace TheKingdomSystem.Management.Database.DatabaseContext
{
    public class ManagementDataContext : DbContext
    {
        public ManagementDataContext(DbContextOptions<ManagementDataContext> options)
            : base (options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<JobTitle> JobTitle { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserModelConfiguration());
            builder.ApplyConfiguration(new AddressModelConfiguration());
            builder.ApplyConfiguration(new EmployeeModelConfiguration());
            builder.ApplyConfiguration(new JobTitleModelConfiguration());
        }
    }
}
