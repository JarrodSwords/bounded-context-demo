namespace BoundedContextDemo.Sales.Services;

public class SetPriceHandler : Handler<SetPrice>
{
    #region Creation

    public SetPriceHandler(IUnitOfWork uow) : base(uow)
    {
    }

    #endregion

    #region Public Interface

    public override void Handle(SetPrice args)
    {
        var (price, sku) = args;
        var product = Uow.Products.Find(sku);

        product.SetPrice(price);

        Uow.Products.Update(product);
        Uow.Commit();
    }

    #endregion
}
