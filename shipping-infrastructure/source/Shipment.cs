using BoundedContextDemo.Infrastructure.Customers;

namespace BoundedContextDemo.Shipping.Infrastructure;

using ShippingShipment = Shipping.Shipment;

public class Shipment : Entity
{
    private readonly List<LineItem> _lineItems = new();

    #region Creation

    public Shipment()
    {
    }

    public Shipment(ShippingShipment source)
    {
        CustomerId = source.CustomerId;

        foreach (var lineItem in source.LineItems)
            _lineItems.Add(new LineItem(source.Id, lineItem));
    }

    #endregion

    #region Public Interface

    public Guid CustomerId { get; set; }
    public IEnumerable<LineItem> LineItems => _lineItems;

    #endregion

    #region Static Interface

    public static implicit operator Shipment(ShippingShipment source) => new(source);

    #endregion
}
