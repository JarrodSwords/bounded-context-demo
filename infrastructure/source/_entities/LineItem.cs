namespace BoundedContextDemo.Infrastructure;

public class LineItem : Entity
{
    #region Public Interface

    public decimal Price { get; set; }
    public Guid ProductId { get; set; }
    public decimal Subtotal => Price * Units;
    public uint Units { get; set; }

    #endregion
}
