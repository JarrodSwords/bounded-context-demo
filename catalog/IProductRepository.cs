using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Catalog;

public interface IProductRepository : IRepository<Product>
{
    public void Create(Product product);
    public IEnumerable<string> FetchExistingSkus();
}
