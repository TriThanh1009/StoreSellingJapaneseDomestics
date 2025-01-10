using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using StoreSellingJapaneseDomestics;

namespace StoreSellingJapaneseDomestics
{
    public static class ExtensionMethods
    {
        public static IHost MigrateDatabase<T>(this IHost host) where T : DbContext
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var db = services.GetRequiredService<T>();
                    db.Database.Migrate();
                }
                catch (Exception ex)
                {
                    var message = services.GetRequiredService<ILogger<Program>>();
                    message.LogError(ex, "Error");
                }
            }
            return host;
        }
    }
}