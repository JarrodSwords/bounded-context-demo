using static BoundedContextDemo.Catalog.Product;

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
        var existingSkus = Uow.Products.FetchExistingSkus().ToArray();

        var isSuccess = TryRegister(out var registeredProduct, description, name, sku, existingSkus);

        if (!isSuccess)
            return;

        Uow.Products.Create(registeredProduct);
        Uow.Commit();
    }

    #endregion
}
