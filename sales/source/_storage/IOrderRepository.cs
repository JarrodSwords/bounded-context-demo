using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public interface IOrderRepository : IRepository<Order>
{
    void Create(Order order);
}
