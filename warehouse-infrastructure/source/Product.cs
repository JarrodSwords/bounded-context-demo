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