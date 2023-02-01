using Microsoft.EntityFrameworkCore;
using MindboxDb;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MindboxDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

using var scope = app.Services.CreateScope();
scope.ServiceProvider.GetService<MindboxDbContext>();

app.MapGet("/", () => "Hello World!");

app.Run();
