namespace BoundedContextDemo.Kernel;

public record Query
{
    public interface IHandler<in TArgs, out TResult> where TArgs : Query
    {
        TResult Handle(TArgs args);
    }
}
