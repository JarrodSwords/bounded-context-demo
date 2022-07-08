using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Shipping;

public interface ICustomerRepository : IRepository<Customer>
{
    Customer Find(string name, string surname);
}
