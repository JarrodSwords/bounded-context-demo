namespace BoundedContextDemo.Sales.Services;

public class BeginShoppingHandler : Handler<BeginShopping>
{
    #region Creation

    public BeginShoppingHandler(IUnitOfWork uow) : base(uow)
    {
    }

    #endregion

    #region Public Interface

    public override void Handle(BeginShopping args)
    {
        var shoppingCart = new ShoppingCart(args.CustomerId);
        Uow.ShoppingCarts.Create(shoppingCart);
        Uow.Commit();
    }

    #endregion
}
