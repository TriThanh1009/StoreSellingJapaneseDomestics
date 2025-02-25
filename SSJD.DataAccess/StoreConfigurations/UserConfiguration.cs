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
            builder.Property("Id").IsRequired().HasMaxLength(50).HasDefaultValueSql("NEWID()"); ;
            builder.Property("Sex").HasDefaultValue(Sex.Male);
            builder.Property("PhoneNumber").HasDefaultValue(15);
            builder.Property("Address").HasMaxLength(60);
            builder.Property("IdentityCard").HasMaxLength(20);
            builder.Property("Email").HasMaxLength(20);      
            builder.HasOne(x => x.Account).WithOne(x => x.User).HasForeignKey<User>(x => x.AccountID);
            builder.HasOne(x => x.MemberCard).WithMany(x => x.User).HasForeignKey(x => x.MemberCardID);
        }
    }

}
