using BoundedContextDemo.Infrastructure;

namespace BoundedContextDemo.Sales.Infrastructure;

using SalesProduct = Sales.Product;

public class Product : Entity
{
    #region Public Interface

    public decimal Price { get; set; }
    public string Sku { get; set; }

    public Product Update(SalesProduct salesProduct)
    {
        Price = salesProduct.Price;
        return this;
    }

    #endregion

    #region Static Interface

    public static implicit operator SalesProduct(Product source) => new(source.Price, source.Sku, source.Id);

    #endregion
}
