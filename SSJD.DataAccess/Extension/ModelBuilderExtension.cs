using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SSJD.Entities.GeneralEntity;
using SSJD.Entities.StoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.DataAccess.Extension
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<User>().HasData(
                new User() {UserName = "Nguyen Tri Thanh",Sex = Entities.GeneralEntity.Sex.Male,PhoneNumber="123123", Address = "Viet Nam",IdentityCard="123",AccountID = "1",MemberCardID="1",Image="122"}
                );
            modelbuilder.Entity<Account>().HasData(
                new Account() { ID = "1",UserName="admin",Password="admin",PasswordCheck="admin",Email="admin@gmail.com"}
                );
            modelbuilder.Entity<MemberCard>().HasData(
                new MemberCard() { ID = "1",Point=2000,MemberClass="Gold",Discount=30}
                );
            modelbuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() {Name = "Admin"},
                new IdentityRole() {Name = "Customer" }
                );
            modelbuilder.Entity<Brand>().HasData(
                new Brand() { ID = "2", Name = "ohuhu" }
                );
            modelbuilder.Entity<Category>().HasData(
                new Category() { ID = "2", Name = "book" }
                );
        }
    }
}
