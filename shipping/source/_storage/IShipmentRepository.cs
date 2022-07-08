using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Shipping;

public interface IShipmentRepository : IRepository<Shipment>
{
    void Create(Shipment shipment);
}
