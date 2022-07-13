using BoundedContextDemo.Kernel;
using BoundedContextDemo.Sales;
using BoundedContextDemo.Warehouse.Infrastructure;

namespace BoundedContextDemo.Warehouse.Services;

public class OrderSubmittedHandler : IEventHandler<OrderSubmitted>
{
    #region IEventHandler<OrderSubmitted> Implementation

    public void Handle(OrderSubmitted args)
    {
        var context = new Context();
        var uow = new UnitOfWork(context);


        //var order = uow.Orders.Find(args.OrderId);
    }

    #endregion
}
