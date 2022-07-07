namespace BoundedContextDemo.Sales;

public interface IUnitOfWork
{
    IProductRepository Products { get; }
    void Commit();
}
