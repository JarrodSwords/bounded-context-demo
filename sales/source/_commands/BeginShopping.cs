using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public record BeginShopping(Guid CustomerId) : Command;
