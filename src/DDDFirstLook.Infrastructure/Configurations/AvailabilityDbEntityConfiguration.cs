using DDDFirstLook.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDFirstLook.Infrastructure.Configurations
{
    public class AvailabilityDbEntityConfiguration : IEntityTypeConfiguration<AvailabilityDbEntity>
    {
        public void Configure(EntityTypeBuilder<AvailabilityDbEntity> builder)
        {
            builder.ToTable("Availability");
        }
    }
}
