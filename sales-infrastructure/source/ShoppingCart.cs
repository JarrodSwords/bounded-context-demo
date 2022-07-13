using BoundedContextDemo.Infrastructure;

namespace BoundedContextDemo.Sales.Infrastructure;

using SalesShoppingCart = Sales.ShoppingCart;

public class ShoppingCart : Entity
{
    private readonly List<LineItem> _lineItems = new();

    #region Public Interface

    public Guid CustomerId { get; set; }

    public IEnumerable<LineItem> LineItems
    {
        get => _lineItems;
        set => _lineItems.AddRange(value);
    }

    public ShoppingCart Update(SalesShoppingCart shoppingCart)
    {
        foreach (var lineItem in shoppingCart.LineItems.Where(x => x.Id == Guid.Empty))
            _lineItems.Add(lineItem);

        return this;
    }

    #endregion

    #region Static Interface

    public static explicit operator ShoppingCartDto(ShoppingCart source) => new(source.Id);
    public static implicit operator SalesShoppingCart(ShoppingCart source) => new(source.CustomerId, source.Id);

    public static implicit operator ShoppingCart(SalesShoppingCart source) =>
        new()
        {
            Id = source.Id,
            CustomerId = source.CustomerId
        };

    #endregion
}
