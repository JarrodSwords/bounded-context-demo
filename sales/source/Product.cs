using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public class Product : Aggregate
{
    #region Creation

    public Product(decimal price, string sku, Guid id = default) : base(id)
    {
        Price = price;
        Sku = sku;
    }

    #endregion

    #region Public Interface

    public decimal Price { get; private set; }
    public string Sku { get; }

    public Product SetPrice(decimal price)
    {
        Price = price;
        return this;
    }

    #endregion
}
