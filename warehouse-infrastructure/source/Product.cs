using BoundedContextDemo.Infrastructure;

namespace BoundedContextDemo.Warehouse.Infrastructure;

using WarehouseProduct = Warehouse.Product;

public class Product : Entity
{
    #region Public Interface

    public string Sku { get; set; }
    public uint UnitsOnHand { get; set; }

    public Product Update(WarehouseProduct warehouseProduct)
    {
        UnitsOnHand = warehouseProduct.UnitsOnHand;
        return this;
    }

    #endregion

    #region Static Interface

    public static implicit operator WarehouseProduct(Product product) => new(product.Sku, product.UnitsOnHand);

    #endregion
}

public class LineItem : Entity
{
    #region Public Interface

    public decimal Price { get; set; }
    public Guid ProductId { get; set; }
    public uint Units { get; set; }

    #endregion
}

public class Order : Entity
{
    #region Public Interface

    public Guid CustomerId { get; set; }
    public IEnumerable<LineItem> LineItems { get; set; }

    #endregion
}
