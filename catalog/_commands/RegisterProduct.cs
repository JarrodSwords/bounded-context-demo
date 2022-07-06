using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Catalog;

public record RegisterProduct(
    string Description,
    string Name,
    string Sku
) : Command;
