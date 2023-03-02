using Microsoft.AspNetCore.Mvc;
using SimpleStore.Api.Models;
using SimpleStore.Api.Services;

namespace SimpleStore.Api.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class ProductsController : ControllerBase
{
    private readonly IProductsService _productsService;

    public ProductsController(IProductsService productsService)
    {
        _productsService = productsService;
    }

    [HttpGet("all")]
    public ActionResult<IEnumerable<ProductItem>> GetProducts()
    {
        var products = _productsService.GetProducts();
        return Ok(products);
    }
}