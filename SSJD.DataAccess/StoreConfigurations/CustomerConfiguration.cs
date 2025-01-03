using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSJD.Entities.EmployeeEntity;
using SSJD.Entities.GeneralEntity;
using SSJD.Entities.StoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.DataAccess.StoreConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.HasKey("ID");
            builder.Property("ID").IsRequired();
            builder.Property("FullName").IsRequired().HasMaxLength(50);
            builder.Property("Sex").HasDefaultValue(Sex.Male);
            builder.Property("PhoneNumber").IsRequired().HasDefaultValue(15);
            builder.Property("Address").IsRequired().HasMaxLength(60);
            builder.Property("IdentityCard").IsRequired().HasMaxLength(20);
            builder.Property("Email").HasMaxLength(20);
            builder.HasOne(x => x.Account).WithOne(x => x.Customer).HasForeignKey<Customer>(x => x.AccountID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.MemberCard).WithOne(x => x.Customer).HasForeignKey<Customer>(x => x.MemberCardID).OnDelete(DeleteBehavior.Restrict);
        }
    }

}
