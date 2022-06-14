using System.Collections.Concurrent;

namespace BlazorServerApp.Data.Shop;

public class ProductCatalogService
{
    private ProductCatalog _catalog = new ProductCatalog();
    public Task<List<Product>> GetCatalogAsyng()
    {
        return Task.FromResult(_catalog.GetCatalog());
    }
}