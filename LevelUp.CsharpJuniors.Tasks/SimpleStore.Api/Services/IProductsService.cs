using SimpleStore.Api.Models;

namespace SimpleStore.Api.Services;

public interface IProductsService
{
    Task<IEnumerable<ProductItem>> GetProducts();
}