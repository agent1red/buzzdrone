using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetbyIdAsync(int id);
        Task<IReadOnlyList<T>> ListAllAsync();
    }
}