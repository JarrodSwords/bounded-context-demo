using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public record SetPrice(
    decimal price,
    string sku
) : Command;
