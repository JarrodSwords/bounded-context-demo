using BoundedContextDemo.Infrastructure;

namespace BoundedContextDemo.Sales.Infrastructure;

using SalesOrder = Sales.Order;

public class Order : Entity
{
    #region Creation

    public Order()
    {
    }

    public Order(SalesOrder source)
    {
        CustomerId = source.CustomerId;
        LineItems = source.LineItems.Select(x => (LineItem)x);
    }

    #endregion

    #region Public Interface

    public Guid CustomerId { get; set; }
    public IEnumerable<LineItem> LineItems { get; set; }

    #endregion

    #region Static Interface

    public static implicit operator Order(SalesOrder source) => new(source);

    #endregion
}
