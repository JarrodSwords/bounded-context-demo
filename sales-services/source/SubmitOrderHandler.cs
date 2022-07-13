using static BoundedContextDemo.Kernel.EventProcessor;

namespace BoundedContextDemo.Sales.Services;

public class SubmitOrderHandler : Handler<SubmitOrder>
{
    #region Creation

    public SubmitOrderHandler(IUnitOfWork uow) : base(uow)
    {
    }

    #endregion

    #region Public Interface

    public override void Handle(SubmitOrder args)
    {
        var (customerId, lineItems) = args;

        //var items = new List<LineItem>();

        //var products = Uow.Products.Fetch();

        var order = new Order(customerId, new LineItem(1.10m, Guid.NewGuid(), 1));

        //Uow.Orders.Create(order);
        Uow.Commit();

        Dispatch(new OrderSubmitted(order.Id));
    }

    #endregion
}
