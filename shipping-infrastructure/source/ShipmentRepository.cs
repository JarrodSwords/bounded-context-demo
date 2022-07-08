using BoundedContextDemo.Infrastructure.Customers;
using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Shipping.Infrastructure;

using ShippingShipment = Shipping.Shipment;

public class ShipmentRepository : Repository<Shipment>, IShipmentRepository
{
    #region Creation

    public ShipmentRepository(DbContext context) : base(context)
    {
    }

    #endregion

    #region IShipmentRepository Implementation

    public void Create(ShippingShipment shipment) => base.Create(shipment);

    #endregion
}
