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
    public class AddressDbEntityConfiguration : IEntityTypeConfiguration<AddressDbEntity>
    {
        public void Configure(EntityTypeBuilder<AddressDbEntity> builder)
        {
            builder.ToTable("Address");
        }
    }
}
