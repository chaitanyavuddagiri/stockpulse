using StockPulse.Core.Models;

namespace StockPulse.Core.Interfaces;
public interface IRepository<T> where T : BaseEntity
{
    Task<T?> GetByIdAsync(string id);
    Task<List<T>> GetAllAsync();
    Task<T> CreateAsync(T entity);
    Task<bool> UpdateAsync(string id, T entity);
    Task<bool> DeleteAsync(string id);
}