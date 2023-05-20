using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FIAP.Bizzar.Services
{
    public interface IData<T>
    {
        Task<bool> AddAsync(T item);
        Task<bool> UpdateAsync(T item);
        Task<bool> DeleteAsync(Guid id);
        Task<T> GetAsync(Guid id);
        Task<IEnumerable<T>> GetAsync(bool forceRefresh = false);
    }
}
