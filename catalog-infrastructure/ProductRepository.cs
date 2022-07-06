using BoundedContextDemo.Infrastructure;

namespace BoundedContextDemo.Catalog.Infrastructure;

using CatalogProduct = Catalog.Product;

public class ProductRepository : Repository<Product>, IProductRepository
{
    #region Creation

    public ProductRepository(Context context) : base(context)
    {
    }

    #endregion

    #region IProductRepository Implementation

    public void Create(CatalogProduct product) => base.Create(product);
    public IEnumerable<string> FetchExistingSkus() => Context.Set<Product>().Select(x => x.Sku);

    #endregion
}
