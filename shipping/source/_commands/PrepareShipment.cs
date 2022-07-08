using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Shipping;

public record PrepareShipment(
    Guid CustomerId,
    params CreateLineItemDto[] LineItemDtos
) : Command;
