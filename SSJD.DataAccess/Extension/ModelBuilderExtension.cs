﻿using Microsoft.AspNetCore.Identity;
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
            modelbuilder.Entity<MemberCard>().HasData(
                new MemberCard() { ID = "1", Point = 0, MemberClass = "None Class", Discount = 30 }
                );
            modelbuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole() { Name = "Customer", NormalizedName = "CUSTOMER" }
                );

        }
    }
}
