using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using TimeSheets.Data;
using TimeSheets.Data.Implementation;
using TimeSheets.Data.Interfaces;
using TimeSheets.Models.Dto.Auth;
using TimeSheets.Services.Implementation;
using TimeSheets.Services.Interfaces;

namespace TimeSheets.Infrastucture.Extentions
{
    public static class ServiceCollectionExtention
    {
        public static void ConfigureDataRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IClientRepo, ClientRepo>();
            services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            services.AddScoped<IContractRepo, ContractRepo>();
            services.AddScoped<IServiceRepo, ServiceRepo>();
            services.AddScoped<ISheetRepo, SheetRepo>();
        }

        public static void ConfigureServiceManagers(this IServiceCollection services)
        {
            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IClientManager, ClientManager>();
            services.AddScoped<IEmployeeManager, EmployeeManager>();
            services.AddScoped<IContractManager, ContractManager>();
            services.AddScoped<ISerrviceManager, ServiceManager>();
            services.AddScoped<ISheetManager, SheetManager>();           
        }

        public static void ConfigureDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<TimeSheetDbContext>(options =>
                        options.UseNpgsql(connectionString));
        }

        public static void ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtAccessOptions>(configuration.GetSection("Authentication:JwtAccessOptions"));

            var jwtSettings = new JwtOptions();

            configuration.Bind("Authentication:JwtAccessOptions", jwtSettings);

            services.AddTransient<ILoginManager, LoginManager>();

            services.AddAuthentication(x=>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                }).AddJwtBearer(options =>
                    options.TokenValidationParameters = jwtSettings.GetTokenValidationParameters());
        }
    }
}
