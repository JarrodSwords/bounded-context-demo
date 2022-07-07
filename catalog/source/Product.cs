using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Catalog;

public class Product : Aggregate
{
    public static Product NullProduct = new("", "", "");

    #region Creation

    private Product(string description, string name, string sku)
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

    #region Static Interface

    public static bool TryRegister(
        out Product registeredProduct,
        string description,
        string name,
        string sku,
        params string[] existingSkus
    )
    {
        registeredProduct = existingSkus.Contains(sku)
            ? NullProduct
            : new(description, name, sku);

        return registeredProduct != NullProduct;
    }

    #endregion
}
