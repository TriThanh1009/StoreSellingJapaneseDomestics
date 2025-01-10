using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using SSJD.DataAccess;
using SSJD.Entities.StoreEntity;
using SSJD.Services.GeneralService.Account;
using SSJD.Services.GeneralService.Base;
using SSJD.Services.StoreService.Category;
using SSJD.Services.StoreService.MemberCard;
using SSJD.Services.StoreService.Order;
using SSJD.Services.StoreService.OrderDetail;
using SSJD.Services.StoreService.Product;
using SSJD.Services.StoreService.ProductDetail;
using SSJD.Services.StoreService.Promotion;
using SSJD.Services.StoreService.UnitShip;
using SSJD.Services.StoreService.User;

namespace StoreSellingJapaneseDomestics
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();
            services.AddDbContext<SSJDDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("SSJDdb"))
                );       

            services.AddEndpointsApiExplorer();
            services.AddHttpContextAccessor();
            services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<SSJDDbContext>().AddDefaultTokenProviders();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<ICategoryService, CategorySerivce>();
            services.AddTransient<IMemberCardService, MemberCardService>();
            services.AddTransient<IOrderService,OrderService>();
            services.AddTransient<IOrderDetailService, OrderDetailService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductDetailService, ProductDetailService>();
            services.AddTransient<IPromotionService, PromotionService>();
            services.AddTransient<IUnitShipService, UnitShipService>();
            services.AddTransient<IUserService, UserService>();
            services.AddControllersWithViews();


            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger Timekeeping Solution", Version = "v1" });
     
            });
            services.AddCors(o => o.AddPolicy("CorsPolicy", b =>
            {
                b.AllowAnyMethod()
                .AllowAnyHeader()
                .AllowAnyOrigin();
            }));
            
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseCors("CorsPolicy");
            app.UseWebSockets();

            app.UseSwagger();

            /*app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Store Selling Japanese Domestics");
            });*/
            app.UseSwaggerUI();
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllers();
            });
        }
    }
}

