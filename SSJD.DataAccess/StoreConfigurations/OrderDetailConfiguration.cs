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
            builder.Property("UnitPrice").IsRequired().HasMaxLength(20);
            builder.Property("Quantity").IsRequired().HasMaxLength(20);
            builder.HasOne(x => x.Promotion).WithOne(x => x.OrderDetail).HasForeignKey<OrderDetail>(x => x.PromotionID).OnDelete(DeleteBehavior.Restrict);
            builder.Property("Subtotal").IsRequired().HasMaxLength(20);
        }
    }
}
