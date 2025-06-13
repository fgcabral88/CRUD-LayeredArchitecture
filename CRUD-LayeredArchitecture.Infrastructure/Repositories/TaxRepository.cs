using CRUD_LayeredArchitecture.Domain.Entities;
using CRUD_LayeredArchitecture.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

public class TaxRepository : ITaxRepository
{
    private readonly SQLContext _context;

    public TaxRepository(SQLContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TaxEntity>> GetAllAsync() => await _context.Taxes.ToListAsync();

    public async Task<TaxEntity?> GetByIdAsync(Guid id) => await _context.Taxes.FindAsync(id);

    public async Task AddAsync(TaxEntity tax)
    {
        await _context.Taxes.AddAsync(tax);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TaxEntity tax)
    {
        _context.Taxes.Update(tax);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var tax = await _context.Taxes.FindAsync(id);

        if (tax != null)
        {
            _context.Taxes.Remove(tax);
            await _context.SaveChangesAsync();
        }
    }
}
