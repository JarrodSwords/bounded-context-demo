using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public record SetPrice(
    decimal Price,
    string Sku
) : Command;

public record LineItemDto(
    decimal Price,
    string Sku,
    uint Units
);

public record SubmitOrder(
    Guid CustomerId,
    IEnumerable<LineItemDto> LineItems
) : Command;

public record OrderSubmitted(Guid OrderId) : Event;
