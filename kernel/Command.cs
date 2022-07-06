namespace BoundedContextDemo.Kernel;

public record Command
{
    public interface IHandler<in T> where T : Command
    {
        void Handle(T args);
    }
}
