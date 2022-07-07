namespace BoundedContextDemo.Infrastructure;

public class Product : Entity
{
    #region Public Interface

    public string Description { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Sku { get; set; }
    public uint UnitsOnHand { get; set; }

    #endregion
}
