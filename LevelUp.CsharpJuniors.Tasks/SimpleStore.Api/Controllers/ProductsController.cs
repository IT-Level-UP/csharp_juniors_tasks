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
    public async Task<ActionResult<IEnumerable<ProductItem>>> GetProducts()
    {
        var products = await _productsService.GetProducts();
        return Ok(products);
    }

    [HttpPost("add")]
    public async Task<IActionResult> AddProduct(ProductItem productItem)
    {
        await _productsService.AddProduct(productItem);
        return Ok();
    }
}