namespace BoundedContextDemo.Sales;

public record LineItemDto(
    decimal Price,
    Guid ProductId,
    uint Units
);
