using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Shipping;

public class Shipment : Aggregate
{
    private readonly List<LineItem> _lineItems = new();

    #region Creation

    public Shipment(Guid customerId, Guid id = default, params LineItem[] lineItems) : base(id)
    {
        CustomerId = customerId;
        _lineItems.AddRange(lineItems);
    }

    #endregion

    #region Public Interface

    public Guid CustomerId { get; }
    public IReadOnlyCollection<LineItem> LineItems => _lineItems.AsReadOnly();

    #endregion
}
