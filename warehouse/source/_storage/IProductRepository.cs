using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Warehouse;

public interface IProductRepository : IRepository<Product>
{
    public Product Find(string sku);
    public void Update(Product product);
}
