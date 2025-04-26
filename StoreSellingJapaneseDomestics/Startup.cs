using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MongoDB.Driver.Core.Configuration;
using SSJD.DataAccess;
using SSJD.Entities.StoreEntity;
using SSJD.Services.GeneralService.Account;
using SSJD.Services.GeneralService.Storage.CloudStorage;
using SSJD.Services.GeneralService.Storage.FileStorage;
using SSJD.Services.GeneralService.Storage.Swagger;
using SSJD.Services.StoreService.Brand;
using SSJD.Services.StoreService.Category;
using SSJD.Services.StoreService.Login;
using SSJD.Services.StoreService.MemberCard;
using SSJD.Services.StoreService.Order;
using SSJD.Services.StoreService.OrderDetail;
using SSJD.Services.StoreService.Product;
using SSJD.Services.StoreService.ProductDetail;
using SSJD.Services.StoreService.Promotion;
using SSJD.Services.StoreService.Role;
using SSJD.Services.StoreService.UnitShip;
using SSJD.Services.StoreService.User;
using StoreSellingJapaneseDomestics;
using StoreSellingJapaneseDomestics.Services;
using Swashbuckle.AspNetCore.Filters;
using System.Text;

namespace StoreSellingJapaneseDomestics
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();
            services.AddDbContext<SSJDDbContext>(options =>
            {
                options.UseSqlServer("SSJDdb");
                options.EnableSensitiveDataLogging(); // Log chi tiết lỗi SQL
                options.EnableDetailedErrors(); // Log lỗi chi tiết
            });
            services.AddEndpointsApiExplorer();
            services.AddHttpContextAccessor();
            services.AddTransient<SSJDDbContext>();
            services.AddTransient<CloudStorageService>();
            services.AddTransient<FileStorageService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IBrandService, BrandService>();
            services.AddTransient<ICategoryService, CategorySerivce>();
            services.AddTransient<IMemberCardService, MemberCardService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IOrderDetailService, OrderDetailService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IProductDetailService, ProductDetailService>();
            services.AddTransient<IPromotionService, PromotionService>();
            services.AddTransient<IUnitShipService, UnitShipService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<ILoginService, LoginSerivce>();
            services.AddTransient<IRoleService, RoleService>();
            services.AddTransient<IFileStorageService, FileStorageService>();
            services.AddTransient<RoleManager<IdentityRole>>();
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddSingleton<ICloudStorageService, CloudStorageService>();
            services.AddControllersWithViews();
            services.AddIdentity<User,IdentityRole>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<SSJDDbContext>()
                .AddDefaultTokenProviders();
            services.AddCors(o => o.AddPolicy("CorsPolicy", b =>
            {
                b.AllowAnyMethod()
                .AllowAnyHeader()
                //.AllowAnyOrigin()
                .AllowCredentials()
                .SetIsOriginAllowed((host) => true);
            }));
            services.AddSignalRCore();
            services.AddSignalR();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Swagger Timekeeping Solution", Version = "v1" });

                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                options.OperationFilter<SecurityRequirementsOperationFilter>();
                options.OperationFilter<SwaggerFileOperationFilter>();
            });
            services.AddAWSLambdaHosting(LambdaEventSource.RestApi);
            services.AddSingleton(provider =>
            {
                var credentialPath = "firebaseconfig.json";
                return FirebaseApp.Create(new AppOptions
                {
                    Credential = GoogleCredential.FromFile(credentialPath)
                });
            });
            services.AddSingleton(provider =>
            {
                var app = provider.GetRequiredService<FirebaseApp>();
                return FirebaseAuth.GetAuth(app); // Lấy FirebaseAuth từ FirebaseApp
            });
            //
            services.AddSingleton(provider => FirebaseAuth.GetAuth(provider.GetRequiredService<FirebaseApp>()));
            services
                .AddAuthentication(options =>
                {
                    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                            Configuration.GetSection("JwtBearer:Token").Value!))
                };
           
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.UseHttpsRedirection();
            var uploadsPath = Path.Combine(env.ContentRootPath, "Uploads");
            if (!Directory.Exists(uploadsPath))
            {
                Directory.CreateDirectory(uploadsPath);
            }
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                       Path.Combine(env.ContentRootPath, "Uploads")),
                RequestPath = "/uploads"
            });

            app.UseRouting();

            app.UseCors("CorsPolicy");
            app.UseWebSockets();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "DD Store");
            });

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHub<OrderHub>("/orderhub");
                    
                endpoints.MapControllers();
            });
        }
    }
}

