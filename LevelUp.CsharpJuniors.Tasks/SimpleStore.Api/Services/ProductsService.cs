using SimpleStore.Api.DAL;
using SimpleStore.Api.Models;

namespace SimpleStore.Api.Services;

public sealed class ProductsService : IProductsService
{
    private readonly IProductsRepository _productsRepository;

    public ProductsService(IProductsRepository productsRepository)
    {
        _productsRepository = productsRepository;
    }
    
    public async Task<IEnumerable<ProductItem>> GetProducts()
    {
        var entities = await _productsRepository.GetAllProducts();
        return entities.Select(e => new ProductItem(e.Id, e.Name, e.Description));
    }
}