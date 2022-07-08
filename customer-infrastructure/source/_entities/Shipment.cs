namespace BoundedContextDemo.Infrastructure.Customers;

using ShippingShipment = Shipping.Shipment;

public class Shipment : Entity
{
    #region Public Interface

    public Guid CustomerId { get; set; }
    public IEnumerable<LineItem> LineItems { get; set; }

    #endregion
}
