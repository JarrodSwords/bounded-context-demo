using BoundedContextDemo.Infrastructure;

namespace BoundedContextDemo.Sales.Infrastructure;

public class Product : Entity
{
    #region Public Interface

    public decimal Price { get; set; }
    public string Sku { get; set; }

    public Product Update(Sales.Product salesProduct)
    {
        Price = salesProduct.Price;
        return this;
    }

    #endregion

    #region Static Interface

    public static implicit operator Sales.Product(Product source) => new(source.Price, source.Sku);

    #endregion
}
