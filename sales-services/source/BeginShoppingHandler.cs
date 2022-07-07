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
        var (name, surname) = args;
        var customer = Uow.Customers.Find(name, surname);

        var shoppingCart = new ShoppingCart(customer.Id);

        Uow.ShoppingCarts.Create(shoppingCart);
        Uow.Commit();
    }

    #endregion
}
