using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MotoPro.Models;

namespace MotoPro.Services.Interfaces
{
    public interface IAsyncRepository<T> where T : class, IBaseModel
    {
        Task<T> GetByIdAsync(int id);
        Task<T> GetByIdAsync(int id, IEnumerable<string> includeProperties);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<IReadOnlyList<T>> ListAllAsync(IEnumerable<string> includeProperties);
        Task<T> AddAsync(T entity);
        Task UpdateAsync();
        Task DeleteAsync(T entity);
    }
}
