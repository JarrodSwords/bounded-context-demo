namespace BoundedContextDemo.Infrastructure;

public class Order : Entity
{
    #region Public Interface

    public Guid CustomerId { get; set; }
    public IEnumerable<LineItem> LineItems { get; set; }

    #endregion
}
