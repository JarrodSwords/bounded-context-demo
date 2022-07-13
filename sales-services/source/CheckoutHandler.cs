using static BoundedContextDemo.Kernel.EventProcessor;

namespace BoundedContextDemo.Sales.Services;

public class CheckoutHandler : Handler<Checkout>
{
    #region Creation

    public CheckoutHandler(IUnitOfWork uow) : base(uow)
    {
    }

    #endregion

    #region Public Interface

    public override void Handle(Checkout args)
    {
        var shoppingCart = Uow.ShoppingCarts.Find(args.ShoppingCartId);

        var order = new Order(
            shoppingCart.CustomerId,
            shoppingCart.LineItems.ToArray()
        );

        Uow.Orders.Create(order);
        Uow.Commit();

        Dispatch(new OrderSubmitted(order.Id));
    }

    #endregion
}
