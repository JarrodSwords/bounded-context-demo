namespace BoundedContextDemo.Kernel;

public abstract class Aggregate : Entity
{
    #region Creation

    protected Aggregate(Guid id = default) : base(id)
    {
    }

    #endregion
}
