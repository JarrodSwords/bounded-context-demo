using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public record BeginShopping(
    string Name,
    string Surname
) : Command;
