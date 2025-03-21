using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using SSJD.DataAccess.Extension;
using SSJD.DataAccess.GeneralConfigurations;
using SSJD.DataAccess.StoreConfigurations;
using SSJD.Entities.GeneralEntity;
using SSJD.Entities.StoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SSJD.DataAccess
{
    public class SSJDDbContext : IdentityDbContext<IdentityUser>
    {
        public SSJDDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductDetailConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new UnitShipConfiguration());
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=34.143.222.100,1433;Database=SSJDDB;User ID=sqlserver;Password=AF/@b[@&&yfkTc3^;TrustServerCertificate=True")
                .ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));
            /*optionsBuilder.UseSqlServer("Data Source=sdb;Database=SSJDDB;User ID=sa;Password=Thanh@123456;TrustServerCertificate=True")
                .ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));*/
        }

        
        public DbSet<Account> Account { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<MemberCard> MemberCard { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductDetail> ProductDetail { get; set; }
        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<UnitShip> UnitShip { get; set; }

    }
    
}
