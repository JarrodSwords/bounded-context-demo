using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public class Order : Aggregate
{
    private readonly List<LineItem> _lineItems = new();

    #region Creation

    public Order(Guid customerId, params LineItem[] lineItems)
    {
        CustomerId = customerId;
        _lineItems.AddRange(lineItems);
    }

    #endregion

    #region Public Interface

    public Guid CustomerId { get; }
    public IReadOnlyList<LineItem> LineItems => _lineItems;
    public decimal Total => _lineItems.Sum(x => x.Subtotal);

    #endregion
}
