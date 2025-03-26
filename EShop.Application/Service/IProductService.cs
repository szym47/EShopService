using EShopDomain.Models;

namespace EShop.Application.Service
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task<Product> AddProductAsync(Product product);  // Dodaj tę linię
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}
