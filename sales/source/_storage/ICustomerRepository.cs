using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public interface ICustomerRepository : IRepository<Customer>
{
    CustomerDto QueryCustomer(string name, string surname);
}
