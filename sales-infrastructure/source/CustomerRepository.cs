using BoundedContextDemo.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Sales.Infrastructure;

using SalesCustomer = Sales.Customer;

public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    #region Creation

    public CustomerRepository(Context context) : base(context)
    {
    }

    #endregion

    #region ICustomerRepository Implementation

    public SalesCustomer Find(string name, string surname) => Find(x => x.Name == name && x.Surname == surname);

    public CustomerDto QueryCustomer(string name, string surname)
    {
        var customer = (Context as Context).Customer
            .Include(x => x.ShoppingCarts)
            .Single(x => x.Name == name && x.Surname == surname);

        return customer;
    }

    #endregion
}
