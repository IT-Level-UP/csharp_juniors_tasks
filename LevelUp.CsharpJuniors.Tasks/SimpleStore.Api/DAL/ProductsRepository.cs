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

    public async Task Create(ProductEntity entity)
    {
        await _dbContext.Products!.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }
}