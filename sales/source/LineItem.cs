using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public class LineItem : Entity
{
    #region Creation

    public LineItem(decimal price, Guid productId, uint units, Guid id = default) : base(id)
    {
        Price = price;
        ProductId = productId;
        Units = units;
    }

    #endregion

    #region Public Interface

    public decimal Price { get; }
    public Guid ProductId { get; }
    public decimal Subtotal => Price * Units;
    public uint Units { get; }

    #endregion
}
