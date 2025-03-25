using EShop.Application.Service;
using EShop.Application.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Rejestracja serwis�w
builder.Services.AddScoped<ICreditCardService, CreditCardService>();
builder.Services.AddScoped<IProductService, ProductService>(); // Dodaj ProductService

// Dodanie kontroler�w
builder.Services.AddControllers();

// Swagger (dokumentacja API)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// �rodowisko deweloperskie
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
