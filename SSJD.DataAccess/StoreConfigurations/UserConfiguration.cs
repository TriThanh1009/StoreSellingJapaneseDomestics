using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SSJD.Entities.GeneralEntity;
using SSJD.Entities.StoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.DataAccess.StoreConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.Property("FullName").IsRequired().HasMaxLength(50);
            builder.Property("Sex").HasDefaultValue(Sex.Male);
            builder.Property("PhoneNumber").IsRequired().HasDefaultValue(15);
            builder.Property("Address").IsRequired().HasMaxLength(60);
            builder.Property("IdentityCard").IsRequired().HasMaxLength(20);
            builder.Property("Email").HasMaxLength(20);      
            builder.HasOne(x => x.Account).WithOne(x => x.User).HasForeignKey<User>(x => x.AccountID).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.MemberCard).WithOne(x => x.User).HasForeignKey<User>(x => x.MemberCardID).OnDelete(DeleteBehavior.Restrict);
        }
    }

}
