using Microsoft.OpenApi.Models;
using MySql.Data.MySqlClient;
using System.Data;
using Template_Arquitetura_Camadas_Dapper.ServiceConfigs;
//docker run --name example-mysql -e MYSQL_ROOT_PASSWORD=102030 -d -p 32770:3306 mysql:latest
//Script está na pasta init.txt
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddTransient<IDbConnection>(sp =>
    new MySqlConnection(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.WireDependencyInjections(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Titulo API",
        Description = "Descrição da API",
    });
});


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
