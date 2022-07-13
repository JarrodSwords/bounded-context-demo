﻿using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public interface IProductRepository : IRepository<Product>
{
    Product Find(Guid id);
    Product Find(string sku);
    void Update(Product product);
}
