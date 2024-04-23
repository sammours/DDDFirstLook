using DDDFirstLook.Infrastructure.Configurations;
using DDDFirstLook.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;

namespace DDDFirstLook.Infrastructure
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
             : base(options)
        {

        }

        public DbSet<ProductDbEntity> Products { get; set; }
        public DbSet<AddressDbEntity> Addresses { get; set; }
        public DbSet<AvailabilityDbEntity> Availabilities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductDbEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AddressDbEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AvailabilityDbEntityConfiguration());
        }
    }
}
