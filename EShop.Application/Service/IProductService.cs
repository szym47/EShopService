using EShopDomain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShop.Application.Service
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);
        Task<Product> AddProductAsync(Product product);
        Task UpdateProductAsync(Product product); // Dodaj tę metodę
        Task DeleteProductAsync(int id);
    }

}
