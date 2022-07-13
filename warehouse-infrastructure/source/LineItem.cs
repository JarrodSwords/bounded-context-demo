using BoundedContextDemo.Infrastructure;

namespace BoundedContextDemo.Warehouse.Infrastructure;

public class LineItem : Entity
{
    #region Public Interface

    public decimal Price { get; set; }
    public Guid ProductId { get; set; }
    public uint Units { get; set; }

    #endregion
}
