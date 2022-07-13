namespace BoundedContextDemo.Kernel;

public interface IEventHandler<in T> where T : Event
{
    void Handle(T args);
}
