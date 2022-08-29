using Microsoft.EntityFrameworkCore;
using TimeSheets.Data;
using TimeSheets.Infrastucture.Extentions;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//builder.Services.AddDbContext<TimeSheetDbContext>(options =>
//            options.UseNpgsql(connectionString/*, b=>b.MigrationsAssembly("TimeSheets")*/));

builder.Services.ConfigureDBContext(builder.Configuration);

builder.Services.ConfigureAuthentication(builder.Configuration);

builder.Services.ConfigureDataRepositories();

builder.Services.ConfigureServiceManagers();

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
