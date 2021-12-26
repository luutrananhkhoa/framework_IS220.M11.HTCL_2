using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OTDStore.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OTDStore.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(200);

            builder.Property(x => x.Description).IsRequired();

            builder.Property(x => x.YearRelease).IsRequired();

            builder.Property(x => x.Insurance).IsRequired();

            builder.Property(x => x.Color).IsRequired();

            builder.Property(x => x.CPU).IsRequired();

            builder.Property(x => x.Memory).IsRequired();

            builder.Property(x => x.RAM).IsRequired();       

            builder.Property(x => x.Camera).IsRequired();

            builder.Property(x => x.Bluetooth).IsRequired();

            builder.Property(x => x.Monitor).IsRequired();

            builder.Property(x => x.Battery).IsRequired();

            builder.Property(x => x.Size).IsRequired();

            builder.Property(x => x.OS).IsRequired();

            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.OriginalPrice).IsRequired();

            builder.Property(x => x.Stock).IsRequired().HasDefaultValue(0);

            builder.Property(x => x.ViewCount).IsRequired().HasDefaultValue(0);
        }
    }
}
