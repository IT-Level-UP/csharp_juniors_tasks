using SimpleStore.Api.DAL.Entities;

namespace SimpleStore.Api.DAL;

public sealed class ProductsRepository : IProductsRepository
{
    private readonly ProductsDbContext _dbContext;

    public ProductsRepository(ProductsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<IEnumerable<ProductEntity>> GetAllProducts()
    {
        return Task.FromResult(Enumerable.Empty<ProductEntity>());
    }
}