namespace BoundedContextDemo.Sales;

public interface IUnitOfWork
{
    ICustomerRepository Customers { get; }

    //IOrderRepository Orders { get; }
    IProductRepository Products { get; }
    IShoppingCartRepository ShoppingCarts { get; }

    void Commit();
}
