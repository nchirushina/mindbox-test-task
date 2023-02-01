using Microsoft.EntityFrameworkCore;
using MindboxDb;
using MindboxDb.Repositories;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonConverter = Newtonsoft.Json.JsonConverter;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MindboxDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddTransient<IProductRepository, ProductRepository>(provider =>
    new ProductRepository(builder.Configuration.GetConnectionString("SqlServer")));

var app = builder.Build();

using var scope = app.Services.CreateScope();
scope.ServiceProvider.GetService<MindboxDbContext>();

var productRepository = scope.ServiceProvider.GetService<IProductRepository>();

var productsJson = JsonConvert.SerializeObject(
    productRepository.GetAllProductsAsync().Result,
    Formatting.Indented,
    new JsonConverter[] { new StringEnumConverter() });

app.MapGet("/", () => $"We have products: \r\n{productsJson}");

app.Run();
