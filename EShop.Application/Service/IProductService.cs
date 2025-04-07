using EShopDomain.Models;

namespace EShop.Application.Service
{
    public interface IProductService
    {
        public Task<List<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<Product> AddProductAsync(Product product); 
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}
