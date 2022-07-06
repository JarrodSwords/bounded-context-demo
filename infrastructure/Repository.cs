using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Infrastructure;

public abstract class Repository<T> where T : Entity
{
    private readonly DbContext _context;

    #region Creation

    protected Repository(DbContext context)
    {
        _context = context;
    }

    #endregion

    #region Public Interface

    public void Create(T entity) => _context.Set<T>().Add(entity);

    #endregion
}
