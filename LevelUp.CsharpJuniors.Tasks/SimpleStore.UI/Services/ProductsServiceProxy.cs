using Microsoft.Extensions.Options;
using SimpleStore.UI.Models;

namespace SimpleStore.UI.Services;

public sealed class ProductsServiceProxy : IProductsServiceProxy
{
    private readonly HttpClient _client;

    private readonly BackendEndpoints _endpoints;

    public ProductsServiceProxy(HttpClient client, IOptions<BackendEndpoints> endpoints)
    {
        _client = client;
        _endpoints = endpoints.Value;
    }

    public Task<IEnumerable<ProductItem>> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public Task<ProductItem> GetProductById(Guid id)
    {
        throw new NotImplementedException();
    }

    private async Task<T?> MakeGet<T>(string requestUri)
    {
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(requestUri)
        };
        
        using var response = await _client.SendAsync(request);
        var item = await response.Content.ReadFromJsonAsync<T>();

        return item;
    }
}