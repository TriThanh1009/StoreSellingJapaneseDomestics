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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey("ID");
            builder.Property("ID").IsRequired();
            builder.HasOne(x => x.User).WithMany(x => x.Orders).HasForeignKey(x => x.UserID).OnDelete(DeleteBehavior.Restrict);
            builder.Property(x => x.CustomerName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.CustomerPhone).IsRequired().HasMaxLength(20);
            builder.Property(x => x.OrderDate).HasDefaultValue(DateTime.Now);
            builder.HasOne(x => x.UnitShip).WithMany(x => x.Orders).HasForeignKey(x => x.ShippingUnitID).OnDelete(DeleteBehavior.Restrict);
            builder.Property(x => x.ShippingAddress).IsRequired().HasMaxLength(50);
            builder.Property(x => x.OrderStatus).IsRequired();
            builder.Property(x => x.TotalPrice).IsRequired().HasMaxLength(50).HasPrecision(10, 2);
            builder.Property(x => x.PaymentMethod).IsRequired().HasMaxLength(20);
            builder.Property(x => x.PaymentStatus).IsRequired().HasMaxLength(20);
        }
    }
}
