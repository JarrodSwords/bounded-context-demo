namespace BoundedContextDemo.Sales.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly Context _context;
    private ICustomerRepository? _customers;
    private IProductRepository? _products;
    private IShoppingCartRepository? _shoppingCarts;

    #region Creation

    public UnitOfWork(Context context)
    {
        _context = context;
    }

    #endregion

    #region IUnitOfWork Implementation

    public ICustomerRepository Customers => _customers ??= new CustomerRepository(_context);
    public IProductRepository Products => _products ??= new ProductRepository(_context);
    public IShoppingCartRepository ShoppingCarts => _shoppingCarts ??= new ShoppingCartRepository(_context);

    public void Commit() => _context.SaveChanges();

    #endregion
}
