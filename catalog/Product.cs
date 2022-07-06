using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Catalog;

public class Product : Aggregate
{
    #region Creation

    public Product(string description, string name, string sku)
    {
        Description = description;
        Name = name;
        Sku = sku;
    }

    #endregion

    #region Public Interface

    public string Description { get; set; }
    public string Name { get; set; }
    public string Sku { get; }

    #endregion
}
