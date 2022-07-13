using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Warehouse;

public interface IOrderRepository : IRepository<Order>
{
    Order Find(Guid id);
}
