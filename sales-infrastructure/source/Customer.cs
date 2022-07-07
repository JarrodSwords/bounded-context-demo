using BoundedContextDemo.Infrastructure;

namespace BoundedContextDemo.Sales.Infrastructure;

using SalesCustomer = Sales.Customer;

public class Customer : Entity
{
    #region Public Interface

    public string Name { get; set; }
    public List<ShoppingCart> ShoppingCarts { get; set; }
    public string Surname { get; set; }

    #endregion

    #region Static Interface

    public static implicit operator SalesCustomer(Customer source) => new(source.Name, source.Surname, source.Id);

    public static implicit operator CustomerDto(Customer source) =>
        new(source.Id, source.Name, source.Surname, source.ShoppingCarts.Select(x => (ShoppingCartDto)x).ToList());

    #endregion
}
