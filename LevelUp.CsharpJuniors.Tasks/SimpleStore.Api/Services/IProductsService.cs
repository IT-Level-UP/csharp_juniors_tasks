using SimpleStore.Api.Models;

namespace SimpleStore.Api.Services;

public interface IProductsService
{
    IEnumerable<ProductItem> GetProducts();
}