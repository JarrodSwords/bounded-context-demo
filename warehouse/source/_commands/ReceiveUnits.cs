using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Warehouse;

public record ReceiveUnits(
    string Sku,
    uint Units
) : Command;
