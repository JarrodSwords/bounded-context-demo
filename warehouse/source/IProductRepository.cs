using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Warehouse;

using WarehouseProduct = Product;

public interface IProductRepository : IRepository<Product>
{
    public WarehouseProduct Find(string sku);
    public void Update(WarehouseProduct product);
}
