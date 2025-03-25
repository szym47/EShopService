using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShopDomain.Models;

namespace EShopDomain.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseModel
    {
        private readonly List<T> _data = new List<T>();

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Task.FromResult(_data);
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await Task.FromResult(_data.FirstOrDefault(e => (e as Product)?.Id == id));
        }

        public async Task<T> AddAsync(T entity)
        {
            _data.Add(entity);
            return await Task.FromResult(entity);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            var index = _data.FindIndex(e => (e as Product)?.Id == (entity as Product)?.Id);
            if (index == -1) return false;

            _data[index] = entity;
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = _data.FirstOrDefault(e => (e as Product)?.Id == id);
            if (entity == null) return false;

            _data.Remove(entity);
            return await Task.FromResult(true);
        }
    }
}
