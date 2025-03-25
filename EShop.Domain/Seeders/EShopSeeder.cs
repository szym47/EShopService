using EShopDomain.Models;
using EShopDomain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace EShopDomain.Seeders
{
    public static class EShopSeeder
    {
        public static void Seed(DataContext context)
        {
            if (!context.Products.Any())
            {
                var categories = new List<Category>
                {
                    new Category { Id = 1, Name = "Electronics" },
                    new Category { Id = 2, Name = "Books" },
                    new Category { Id = 3, Name = "Clothing" }
                };
                context.Categories.AddRange(categories);
                context.SaveChanges();

                var products = new List<Product>
                {
                    new Product { Id = 1, Name = "Smartphone", Ean = "1234567890123", Price = 599.99m, Stock = 10, Sku = "SPH-001", Category = categories[0] },
                    new Product { Id = 2, Name = "Laptop", Ean = "9876543210987", Price = 999.99m, Stock = 5, Sku = "LTP-002", Category = categories[0] },
                    new Product { Id = 3, Name = "T-Shirt", Ean = "1112223334445", Price = 19.99m, Stock = 50, Sku = "TSH-003", Category = categories[2] }
                };
                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
