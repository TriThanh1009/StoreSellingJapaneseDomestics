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
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");
            builder.HasKey("ID");
            builder.Property("ID").IsRequired();
            builder.HasOne(x => x.Order).WithOne(x => x.OrderDetail).HasForeignKey<OrderDetail>(x => x.OrderID).OnDelete(DeleteBehavior.Restrict);
            builder.HasMany(x => x.Product).WithMany(x => x.OrderDetails);
            builder.Property("HeadType").IsRequired().HasMaxLength(30);
            builder.Property("Quantity").IsRequired().HasMaxLength(20);
            builder.Property("Subtotal").IsRequired().HasMaxLength(20).HasPrecision(10, 2);
            builder.HasOne(x => x.Promotion).WithMany(x => x.OrderDetail).HasForeignKey(x => x.PromotionID);
        }
    }
}
