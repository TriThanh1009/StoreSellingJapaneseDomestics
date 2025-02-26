using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSJD.Entities.StoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.DataAccess.StoreConfigurations
{
    public class ProductDetailConfiguration : IEntityTypeConfiguration<ProductDetail>
    {
        public void Configure(EntityTypeBuilder<ProductDetail> builder)
        {
            builder.ToTable("ProductDetail");
            builder.HasKey("ID");
            builder.Property("ID").IsRequired();
            builder.HasOne(x => x.Product).WithOne(x => x.ProductDetail).HasForeignKey<ProductDetail>(x => x.ProductID).OnDelete(DeleteBehavior.Restrict);
            builder.Property("Description").IsRequired().HasMaxLength(150);
            builder.Property("Warranty").HasDefaultValue(DateTime.Now);
            builder.Property("Origin").IsRequired().HasMaxLength(30);
        }
    }
}
