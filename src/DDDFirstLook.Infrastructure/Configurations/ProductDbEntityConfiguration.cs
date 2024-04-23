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
    public class ProductDbEntityConfiguration : IEntityTypeConfiguration<ProductDbEntity>
    {
        public void Configure(EntityTypeBuilder<ProductDbEntity> builder)
        {
            builder.ToTable("Product");
        }
    }
}
