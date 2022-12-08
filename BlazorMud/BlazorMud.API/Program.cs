using BlazorMud.API;
using BlazorMud.API.Adapters.Database.Postgres;
using BlazorMud.API.Domain;
using BlazorMud.API.Ports.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = EnvironmentSettings.GetConnectionString();

var contextOptions = new DbContextOptionsBuilder<DatabaseContext>()
    .UseNpgsql(connectionString, p =>
    {
        p.EnableRetryOnFailure(
            10, TimeSpan.FromSeconds(5), 
            new List<string>());
    }).Options;

builder.Services.AddTransient(_ => new DatabaseContext(contextOptions));
builder.Services.AddTransient<IPostRepository, PostRepository>();
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using var scope = app.Services.CreateScope();
using var context = scope.ServiceProvider.GetRequiredService<DatabaseContext>();
context.Database.EnsureCreated();

app.MapControllers();

app.Run();