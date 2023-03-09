using SimpleStore.Api.DAL;
using SimpleStore.Api.DAL.Entities;
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
        var entities = await _productsRepository.GetAll();
        return entities.Select(e => new ProductItem(e.Id, e.Name, e.CategoryId, e.Description));
    }

    public async Task AddProduct(ProductItem productItem)
    {
        var productEntity = new ProductEntity
        {
            Id = productItem.Id,
            CategoryId = productItem.CategoryId,
            Name = productItem.Name,
            Description = productItem.Description
        };

        await _productsRepository.Create(productEntity);
    }
}