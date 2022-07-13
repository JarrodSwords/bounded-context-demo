using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public record AddToShoppingCart(
    Guid ProductId,
    Guid ShoppingCartId,
    uint Units
) : Command;
