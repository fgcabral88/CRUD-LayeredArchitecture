using CRUD_LayeredArchitecture.Domain.Entities;
using CRUD_LayeredArchitecture.Domain.Interfaces.Repository;

namespace CRUD_LayeredArchitecture.Application.Services
{
    public class TaxService
    {
        private readonly ITaxRepository _taxRepository;

        public TaxService(ITaxRepository taxRepository)
        {
            _taxRepository = taxRepository;
        }

        public Task<IEnumerable<TaxEntity>> GetAllAsync() => _taxRepository.GetAllAsync();
        public Task<TaxEntity?> GetByIdAsync(Guid id) => _taxRepository.GetByIdAsync(id);
        public Task AddAsync(TaxEntity tax) => _taxRepository.AddAsync(tax);
        public Task UpdateAsync(TaxEntity tax) => _taxRepository.UpdateAsync(tax);
        public Task DeleteAsync(Guid id) => _taxRepository.DeleteAsync(id);
    }
}
