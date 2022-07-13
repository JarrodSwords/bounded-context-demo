namespace BoundedContextDemo.Sales.Services;

public class AddToShoppingCartHandler : Handler<AddToShoppingCart>
{
    #region Creation

    public AddToShoppingCartHandler(IUnitOfWork uow) : base(uow)
    {
    }

    #endregion

    #region Public Interface

    public override void Handle(AddToShoppingCart args)
    {
        var (productId, shoppingCartId, units) = args;
        var product = Uow.Products.Find(productId);
        var shoppingCart = Uow.ShoppingCarts.Find(shoppingCartId);

        shoppingCart.Add(product, units);

        Uow.ShoppingCarts.Update(shoppingCart);
        Uow.Commit();
    }

    #endregion
}
