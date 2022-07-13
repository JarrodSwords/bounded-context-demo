using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public record Checkout(Guid ShoppingCartId) : Command;
