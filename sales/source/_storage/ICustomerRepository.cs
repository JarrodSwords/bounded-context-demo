using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public interface ICustomerRepository : IRepository<Customer>
{
    Customer Find(string name, string surname);
    CustomerDto QueryCustomer(string name, string surname);
}
