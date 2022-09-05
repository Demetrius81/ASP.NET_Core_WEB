using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
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
        public static IServiceCollection ConfigureDataRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserRepo, UserRepo>();
            services.AddScoped<IClientRepo, ClientRepo>();
            services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            services.AddScoped<IContractRepo, ContractRepo>();
            services.AddScoped<IServiceRepo, ServiceRepo>();
            services.AddScoped<ISheetRepo, SheetRepo>();

            return services;
        }

        public static IServiceCollection ConfigureServiceManagers(this IServiceCollection services)
        {
            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IClientManager, ClientManager>();
            services.AddScoped<IEmployeeManager, EmployeeManager>();
            services.AddScoped<IContractManager, ContractManager>();
            services.AddScoped<ISerrviceManager, ServiceManager>();
            services.AddScoped<ISheetManager, SheetManager>();

            return services;
        }

        public static IServiceCollection ConfigureDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<TimeSheetDbContext>(options =>
                        options.UseNpgsql(connectionString, b=>b.MigrationsAssembly("TimeSheets")));

            return services;
        }

        public static IServiceCollection ConfigureAuthentication(this IServiceCollection services, IConfiguration configuration)
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

            return services;
        }

        public static IServiceCollection ConfigureBackendSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "TimeSheets", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.Http,
                    Scheme = "bearer",
                    BearerFormat = "JWT"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme()
                        {
                            Reference = new OpenApiReference(){Type = ReferenceType.SecurityScheme, Id = "Bearer"}
                        },
                        Array.Empty<string>()
                    }
                });
            });

            return services;
        }
    }
}
