using BoundedContextDemo.Infrastructure;

namespace BoundedContextDemo.Catalog.Infrastructure;

using CatalogProduct = Catalog.Product;

public class Product : Entity
{
    #region Creation

    public Product()
    {
    }

    public Product(CatalogProduct source)
    {
        Description = source.Description;
        Name = source.Name;
        Sku = source.Sku;
    }

    #endregion

    #region Public Interface

    public string Description { get; set; }
    public string Name { get; set; }
    public string Sku { get; set; }

    #endregion

    #region Static Interface

    public static implicit operator Product(CatalogProduct source) => new(source);

    #endregion
}
