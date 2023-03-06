using SimpleStore.Api.DAL.Entities;

namespace SimpleStore.Api.DAL;

public interface IProductsRepository
{
    public Task<IEnumerable<ProductEntity>> GetAllProducts();
}