using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Infrastructure;

public abstract class Repository<T> where T : Entity
{
    protected readonly DbContext Context;

    #region Creation

    protected Repository(DbContext context)
    {
        Context = context;
    }

    #endregion

    #region Public Interface

    public void Create(T entity) => Context.Set<T>().Add(entity);

    #endregion
}
