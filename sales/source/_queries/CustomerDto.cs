namespace BoundedContextDemo.Sales;

public record CustomerDto(Guid Id, string Name, string Surname, List<ShoppingCartDto> ShoppingCarts);
