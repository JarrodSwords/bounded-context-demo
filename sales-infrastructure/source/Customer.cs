using BoundedContextDemo.Infrastructure;

namespace BoundedContextDemo.Sales.Infrastructure;

public class Customer : Entity
{
    #region Public Interface

    public string Name { get; set; }
    public string Surname { get; set; }

    #endregion

    #region Static Interface

    public static implicit operator Sales.Customer(Customer source) => new(source.Name, source.Surname, source.Id);

    #endregion
}
