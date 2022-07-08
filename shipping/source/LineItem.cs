using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Shipping;

public class LineItem : Entity
{
    #region Creation

    public LineItem(Guid productId, uint units, Guid id = default) : base(id)
    {
        ProductId = productId;
        Units = units;
    }

    #endregion

    #region Public Interface

    public Guid ProductId { get; }
    public uint Units { get; }

    #endregion
}
