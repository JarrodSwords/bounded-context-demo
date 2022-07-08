namespace BoundedContextDemo.Infrastructure.Customers;

public abstract class Entity
{
    #region Creation

    protected Entity()
    {
    }

    protected Entity(Guid id)
    {
        Id = id;
    }

    #endregion

    #region Public Interface

    public Guid Id { get; set; }

    #endregion
}
