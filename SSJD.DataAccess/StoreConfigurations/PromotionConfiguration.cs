using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSJD.Entities.StoreEntity;

namespace SSJD.DataAccess.StoreConfigurations
{
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotion");
            builder.HasKey("ID");
            builder.Property("ID").IsRequired();
            builder.Property("Name").IsRequired().HasMaxLength(50);
            builder.Property("CreateDate").HasDefaultValue(DateTime.Now);
            builder.Property("EndDate").HasDefaultValue(DateTime.Now);
            builder.Property("PercentDiscount").IsRequired();
        }
    }
}
