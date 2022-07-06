namespace BoundedContextDemo.Catalog.Services;

public class RegisterProductHandler : Handler<RegisterProduct>
{
    #region Creation

    public RegisterProductHandler(IUnitOfWork uow) : base(uow)
    {
    }

    #endregion

    #region Public Interface

    public override void Handle(RegisterProduct args)
    {
        var (description, name, sku) = args;

        var product = new Product(description, name, sku);

        Uow.Products.Create(product);
        Uow.Commit();
    }

    #endregion
}
