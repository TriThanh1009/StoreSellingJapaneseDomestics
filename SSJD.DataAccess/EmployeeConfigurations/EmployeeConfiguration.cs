using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSJD.Entities.EmployeeEntity;
using SSJD.Entities.GeneralEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.DataAccess.EmployeeConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");
            builder.HasKey("ID");
            builder.Property("ID").IsRequired();
            builder.Property("FullName").IsRequired().HasMaxLength(50);
            builder.Property("Sex").HasDefaultValue(Sex.Male);
            builder.Property("PhoneNumber").IsRequired().HasDefaultValue(15);
            builder.Property("Address").IsRequired().HasMaxLength(60);
            builder.Property("IdentityCard").IsRequired().HasMaxLength(20);
            builder.Property("Email").HasMaxLength(20);
            builder.HasOne(x => x.Position).WithOne(x => x.Employee).HasForeignKey<Employee>(x => x.PositionID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Level).WithOne(x => x.Employee).HasForeignKey<Employee>(x => x.LevelID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Account).WithOne(x => x.Employee).HasForeignKey<Employee>(x => x.AccountID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.Role).WithOne(x => x.Employee).HasForeignKey<Employee>(x => x.RoleID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
