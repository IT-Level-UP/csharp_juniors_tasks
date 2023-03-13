using SimpleStore.Api.DAL.Entities;

namespace SimpleStore.Api.DAL;

public interface IProductsRepository
{
    public Task<IEnumerable<ProductEntity>> GetAll();

    public Task<ProductEntity?> GetById(Guid id);
    
    public Task Create(ProductEntity entity);
}