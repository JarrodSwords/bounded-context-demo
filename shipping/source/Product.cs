using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Shipping;

public class Product : Aggregate
{
    #region Creation

    public Product(string sku, Guid id = default) : base(id)
    {
        Sku = sku;
    }

    #endregion

    #region Public Interface

    public string Sku { get; }

    #endregion
}
