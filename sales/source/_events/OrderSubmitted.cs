using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public record OrderSubmitted(Guid OrderId) : Event;
