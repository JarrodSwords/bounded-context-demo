using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public class LineItem : Entity
{
    #region Public Interface

    public decimal Price { get; }
    public Guid ProductId { get; }
    public uint Quantity { get; }
    public decimal Subtotal => Price * Quantity;

    #endregion
}
