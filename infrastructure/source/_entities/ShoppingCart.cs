namespace BoundedContextDemo.Infrastructure;

public class ShoppingCart : Entity
{
    #region Public Interface

    public Customer Customer { get; set; }
    public Guid CustomerId { get; set; }

    #endregion
}
