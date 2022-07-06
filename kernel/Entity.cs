using static System.Guid;

namespace BoundedContextDemo.Kernel;

public abstract class Entity
{
    #region Creation

    protected Entity(Guid id = default)
    {
        Id = id == default ? NewGuid() : id;
    }

    #endregion

    #region Public Interface

    public Guid Id { get; }

    #endregion
}
