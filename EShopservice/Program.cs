using EShop.Application.Service;
using EShop.Application.Services;
using EShopDomain.Repositories;
using EShop.Domain.Seeders;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Dodaj rejestrację DataContext
builder.Services.AddDbContext<DataContext>(options =>
    options.UseInMemoryDatabase("EShopDb")); // Możesz zmienić na SQL Server np.: UseSqlServer(connectionString)

// 🔹 Dodaj repozytorium generyczne
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// 🔹 Dodaj serwis ProductService i CreditCardService
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICreditCardService, CreditCardService>();
builder.Services.AddScoped<IEShopSeeder, EShopSeeder>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
