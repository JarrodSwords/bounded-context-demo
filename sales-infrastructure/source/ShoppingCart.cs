using BoundedContextDemo.Infrastructure;

namespace BoundedContextDemo.Sales.Infrastructure;

using SalesShoppingCart = Sales.ShoppingCart;

public class ShoppingCart : Entity
{
    #region Public Interface

    public Customer Customer { get; set; }
    public Guid CustomerId { get; set; }

    #endregion

    #region Static Interface

    public static implicit operator ShoppingCart(SalesShoppingCart source) =>
        new()
        {
            Id = source.Id,
            CustomerId = source.CustomerId
        };

    #endregion
}
