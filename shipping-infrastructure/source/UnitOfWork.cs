namespace BoundedContextDemo.Shipping.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    private readonly Context _context;

    private IShipmentRepository? _shipments;

    #region Creation

    public UnitOfWork(Context context)
    {
        _context = context;
    }

    #endregion

    #region IUnitOfWork Implementation

    public IShipmentRepository Shipments => _shipments ??= new ShipmentRepository(_context);

    public void Commit()
    {
        _context.SaveChanges();
    }

    #endregion
}
