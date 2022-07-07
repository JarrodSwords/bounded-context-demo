using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public record GetCustomer(
    string Name,
    string Surname
) : Query;
