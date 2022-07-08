namespace BoundedContextDemo.Infrastructure.Customers;

using ShippingLineItem = Shipping.LineItem;

public class LineItem : Entity
{
    #region Public Interface

    public Guid ProductId { get; set; }
    public Guid ShipmentId { get; set; }
    public uint Units { get; set; }

    #endregion
}
