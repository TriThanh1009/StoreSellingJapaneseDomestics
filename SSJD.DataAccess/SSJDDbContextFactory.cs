using SSJD.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSJD.DataAccess
{
    public class SSJDDbContextFactory : IDesignTimeDbContextFactory<SSJDDbContext>
    {
        public SSJDDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = configuration.GetConnectionString("SSJDdb");
            var optionsBuilder = new DbContextOptionsBuilder<SSJDDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new SSJDDbContext(optionsBuilder.Options);
        }
    }
   
}
