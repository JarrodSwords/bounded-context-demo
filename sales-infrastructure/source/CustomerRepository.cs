using BoundedContextDemo.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Sales.Infrastructure;

using SalesCustomer = Sales.Customer;

public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    #region Creation

    public CustomerRepository(DbContext context) : base(context)
    {
    }

    #endregion

    #region ICustomerRepository Implementation

    public SalesCustomer Find(string name, string surname) => Find(x => x.Name == name && x.Surname == surname);

    #endregion
}
