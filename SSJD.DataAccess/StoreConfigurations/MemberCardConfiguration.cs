using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using SSJD.Entities.StoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.DataAccess.StoreConfigurations
{
    public class MemberCardConfiguration : IEntityTypeConfiguration<MemberCard>
    {
        public void Configure(EntityTypeBuilder<MemberCard> builder)
        {
            builder.ToTable("MemberCard");
            builder.HasKey("ID");
            builder.Property("ID").IsRequired();
            builder.Property("Point").IsRequired().HasMaxLength(50);
            builder.Property("MemberClass").HasDefaultValue(DateTime.Now);
            builder.Property("Discount").IsRequired();
        }
    }
}
