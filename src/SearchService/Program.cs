using MongoDB.Driver;
using MongoDB.Entities;
using SearchService.Data;
using SearchService.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();


var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

try
{
        await DbInitializer.InitDb(app);
}
catch (Exception ex)
{
        Console.WriteLine("Error initialiing the database", ex);
}

app.Run();
