using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public interface IShoppingCartRepository : IRepository<ShoppingCart>
{
    void Create(ShoppingCart shoppingCart);
    ShoppingCart Find(Guid id);
    void Update(ShoppingCart shoppingCart);
}
