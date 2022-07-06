namespace BoundedContextDemo.Catalog.Infrastructure;

public abstract class Repository<T> where T : Entity
{
    private readonly Context _context;

    #region Creation

    protected Repository(Context context)
    {
        _context = context;
    }

    #endregion

    #region Public Interface

    public void Create(T entity) => _context.Set<T>().Add(entity);

    #endregion
}
