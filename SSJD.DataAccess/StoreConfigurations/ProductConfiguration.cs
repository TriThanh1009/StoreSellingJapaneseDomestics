using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSJD.Entities.GeneralEntity;
using SSJD.Entities.StoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.DataAccess.StoreConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey("ID");
            builder.Property("ID").IsRequired();
            builder.Property("Name").IsRequired().HasMaxLength(30);
            builder.Property("Brand").IsRequired().HasMaxLength(30);
            builder.HasOne(x => x.Category).WithOne(x => x.Product).HasForeignKey<Product>(x => x.CategoryID).OnDelete(DeleteBehavior.Restrict);
            builder.Property("Price").IsRequired().HasMaxLength(20).HasPrecision(10, 2);
            builder.Property("Stock").IsRequired().HasMaxLength(20);
            builder.Property("isActive").HasDefaultValue(Active.No);
            builder.Property("Image").HasMaxLength(30);
        }
    }
}
