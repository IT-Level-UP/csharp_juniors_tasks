using SimpleStore.UI.Models;

namespace SimpleStore.UI.Services;

public interface IProductsServiceProxy
{
    Task<IEnumerable<ProductItem>> GetAllProducts();
    Task<ProductItem> GetProductById(Guid id);
}