using Microsoft.EntityFrameworkCore;
using TimeSheets.Data;
using TimeSheets.Infrastucture.Extentions;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();

builder.Services.ConfigureDBContext(builder.Configuration)
                .ConfigureAuthentication(builder.Configuration)
                .ConfigureDataRepositories()
                .ConfigureServiceManagers()
                .ConfigureBackendSwagger();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
