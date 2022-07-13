using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public class LineItem : Entity
{
    #region Creation

    public LineItem(decimal price, Guid productId, uint quantity, Guid id = default) : base(id)
    {
        Price = price;
        ProductId = productId;
        Quantity = quantity;
    }

    #endregion

    #region Public Interface

    public decimal Price { get; }
    public Guid ProductId { get; }
    public uint Quantity { get; }
    public decimal Subtotal => Price * Quantity;

    #endregion
}
