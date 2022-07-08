namespace BoundedContextDemo.Shipping;

public interface IUnitOfWork
{
    IShipmentRepository Shipments { get; }
    void Commit();
}
