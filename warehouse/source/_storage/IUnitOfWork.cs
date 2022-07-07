namespace BoundedContextDemo.Warehouse;

public interface IUnitOfWork
{
    IProductRepository Products { get; }
    void Commit();
}
