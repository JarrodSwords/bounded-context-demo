using BoundedContextDemo.Infrastructure.Customers;

namespace BoundedContextDemo.Shipping.Infrastructure;

using ShippingLineItem = Shipping.LineItem;

public class LineItem : Entity
{
    #region Creation

    public LineItem()
    {
    }

    public LineItem(Guid shipmentId, ShippingLineItem source)
    {
        ProductId = source.ProductId;
        ShipmentId = shipmentId;
        Units = source.Units;
    }

    #endregion

    #region Public Interface

    public Guid ProductId { get; set; }
    public Guid ShipmentId { get; set; }
    public uint Units { get; set; }

    #endregion
}
