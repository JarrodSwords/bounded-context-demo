using BoundedContextDemo.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Warehouse.Infrastructure;

using WarehouseProduct = Warehouse.Product;

public class ProductRepository : Repository<Product>, IProductRepository
{
    #region Creation

    public ProductRepository(DbContext context) : base(context)
    {
    }

    #endregion

    #region IProductRepository Implementation

    public WarehouseProduct Find(string sku) => Find(x => x.Sku == sku);

    public void Update(WarehouseProduct warehouseProduct)
    {
        var product = Find(x => x.Sku == warehouseProduct.Sku);

        product.Update(warehouseProduct);
    }

    #endregion
}
