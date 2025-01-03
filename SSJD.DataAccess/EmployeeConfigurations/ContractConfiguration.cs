using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSJD.Entities.EmployeeEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.DataAccess.EmployeeConfigurations
{
    public class ContractConfiguration : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.ToTable("Contract");
            builder.HasKey("ID");
            builder.Property("ID").IsRequired();
            builder.HasOne(x => x.Employee).WithMany(x=>x.Contract).HasForeignKey(x=>x.EmployeeID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Position).WithOne(x => x.Contract).HasForeignKey<Contract>(x => x.PositionID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Level).WithOne(x => x.Contract).HasForeignKey<Contract>(x => x.LevelID).OnDelete(DeleteBehavior.Restrict);
            builder.Property("CreateDate").HasDefaultValue(DateTime.Now);
            builder.Property("EndDate").HasDefaultValue(DateTime.Now);
            builder.Property("Salary").IsRequired().HasMaxLength(20);
            builder.Property("Active").IsRequired().HasMaxLength(10);
        }
    }
}
