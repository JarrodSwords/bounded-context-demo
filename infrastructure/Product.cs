namespace BoundedContextDemo.Infrastructure;

public class Product : Entity
{
    #region Public Interface

    public string Description { get; set; }
    public string Name { get; set; }
    public string Sku { get; set; }

    #endregion
}
