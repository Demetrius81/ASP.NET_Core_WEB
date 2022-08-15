using Microsoft.EntityFrameworkCore;
using TimeSheets.Data;
using TimeSheets.Data.Implementation;
using TimeSheets.Data.Interfaces;
using TimeSheets.Services.Implementation;
using TimeSheets.Services.Interfaces;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Data

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<TimeSheetDbContext>(options =>
    options.UseNpgsql(connectionString)); 

//builder.Services.AddSingleton(typeof(TempData));   //Temprary item

//Repositories

builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddScoped<IClientRepo, ClientRepo>();
builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddScoped<IContractRepo, ContractRepo>();
builder.Services.AddScoped<IServiceRepo, ServiceRepo>();
builder.Services.AddScoped<ISheetRepo, SheetRepo>();

//Managers

builder.Services.AddScoped<IUserManager, UserManager>();
builder.Services.AddScoped<IClientManager, ClientManager>();
builder.Services.AddScoped<IEmployeeManager, EmployeeManager>();
builder.Services.AddScoped<IContractManager, ContractManager>();
builder.Services.AddScoped<ISerrviceManager, ServiceManager>();
builder.Services.AddScoped<ISheetManager, SheetManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
