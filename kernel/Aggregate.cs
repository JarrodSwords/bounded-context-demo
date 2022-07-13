namespace BoundedContextDemo.Kernel;

public abstract class Aggregate : Entity
{
    private readonly List<Event> _events = new();

    #region Creation

    protected Aggregate(Guid id = default) : base(id)
    {
    }

    #endregion

    #region Public Interface

    public IReadOnlyList<Event> Events => _events;

    #endregion

    #region Protected Interface

    protected void Append(Event @event) => _events.Add(@event);

    #endregion
}
