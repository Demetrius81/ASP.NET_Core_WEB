using Microsoft.EntityFrameworkCore;
using TimeSheets.Data;
using TimeSheets.Data.Implementation;
using TimeSheets.Data.Interfaces;
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
            services.AddScoped<ILoginManager, LoginManager>();
        }

        public static void ConfigureDBContext(this IServiceCollection services, ConfigurationManager configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<TimeSheetDbContext>(options =>
                        options.UseNpgsql(connectionString));
        }
    }
}
