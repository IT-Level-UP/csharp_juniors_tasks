using Microsoft.EntityFrameworkCore;
using SimpleStore.Api.DAL.Entities;

namespace SimpleStore.Api.DAL;

public sealed class ProductsRepository : IProductsRepository
{
    private readonly ProductsDbContext _dbContext;

    public ProductsRepository(ProductsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<IEnumerable<ProductEntity>> GetAll()
    {
        return Task.FromResult<IEnumerable<ProductEntity>>(_dbContext.Products!.ToList());
    }

    public Task<ProductEntity?> GetById(Guid id)
    {
        return _dbContext.Products!
            .FirstOrDefaultAsync(e => e.Id.Equals(id));
    }

    public async Task Create(ProductEntity entity)
    {
        await _dbContext.Products!.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }
}