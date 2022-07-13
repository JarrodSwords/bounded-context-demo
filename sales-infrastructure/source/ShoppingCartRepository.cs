using BoundedContextDemo.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Sales.Infrastructure;

using SalesShoppingCart = Sales.ShoppingCart;

public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
{
    #region Creation

    public ShoppingCartRepository(DbContext context) : base(context)
    {
    }

    #endregion

    #region IShoppingCartRepository Implementation

    public void Create(SalesShoppingCart shoppingCart) => base.Create(shoppingCart);
    public SalesShoppingCart Find(Guid id) => Find(x => x.Id == id);

    public void Update(SalesShoppingCart shoppingCart)
    {
        Find(x => x.Id == shoppingCart.Id).Update(shoppingCart);
    }

    #endregion
}
