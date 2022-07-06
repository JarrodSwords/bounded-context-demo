namespace BoundedContextDemo.Catalog.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly Context _context;
    private IProductRepository? _products;

    #region Creation

    public UnitOfWork(Context context)
    {
        _context = context;
    }

    #endregion

    #region IUnitOfWork Implementation

    public IProductRepository Products => _products ??= new ProductRepository(_context);

    #endregion
}
