using BoundedContextDemo.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Sales.Infrastructure;

using SalesProduct = Sales.Product;

public class ProductRepository : Repository<Product>, IProductRepository
{
    #region Creation

    public ProductRepository(DbContext context) : base(context)
    {
    }

    #endregion

    #region IProductRepository Implementation

    public SalesProduct Find(string sku) => Find(x => x.Sku == sku);

    public void Update(SalesProduct salesProduct)
    {
        Find(x => x.Sku == salesProduct.Sku).Update(salesProduct);
    }

    #endregion
}
