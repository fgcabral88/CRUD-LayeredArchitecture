using CRUD_LayeredArchitecture.Domain.Entities;

namespace CRUD_LayeredArchitecture.Domain.Interfaces.Repository
{
    public interface ITaxRepository
    {
        Task<IEnumerable<TaxEntity>> GetAllAsync();
        Task<TaxEntity?> GetByIdAsync(Guid id);
        Task AddAsync(TaxEntity tax);
        Task UpdateAsync(TaxEntity tax);
        Task DeleteAsync(Guid id);
    }
}
