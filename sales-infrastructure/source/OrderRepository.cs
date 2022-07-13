using BoundedContextDemo.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Sales.Infrastructure;

using SalesOrder = Sales.Order;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    #region Creation

    public OrderRepository(DbContext context) : base(context)
    {
    }

    #endregion

    #region IOrderRepository Implementation

    public void Create(SalesOrder order) => base.Create(order);

    #endregion
}
