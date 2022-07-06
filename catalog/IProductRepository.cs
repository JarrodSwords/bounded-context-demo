using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Catalog;

public interface IProductRepository : IRepository<Product>
{
    public void Create(Product product);
}
