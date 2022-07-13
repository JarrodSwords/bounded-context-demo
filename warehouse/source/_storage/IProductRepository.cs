using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Warehouse;

public interface IProductRepository : IRepository<Product>
{
    Product Find(string sku);
    void Update(Product product);
}

public interface IOrderRepository : IRepository<Order>
{
    Order Find(Guid id);
}
