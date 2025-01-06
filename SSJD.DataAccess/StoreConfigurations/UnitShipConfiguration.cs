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
    public class UnitShipConfiguration : IEntityTypeConfiguration<UnitShip>
    {
        public void Configure(EntityTypeBuilder<UnitShip> builder)
        {
            builder.ToTable("UnitShip");
            builder.HasKey("ID");
            builder.Property("ID").IsRequired();
            builder.Property("Name").IsRequired().HasMaxLength(50);
        }
    }
}
