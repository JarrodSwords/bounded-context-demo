namespace BoundedContextDemo.Catalog;

public interface IUnitOfWork
{
    IProductRepository Products { get; }
}
