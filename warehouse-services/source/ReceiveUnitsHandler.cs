namespace BoundedContextDemo.Warehouse.Services;

public class ReceiveUnitsHandler : Handler<ReceiveUnits>
{
    #region Creation

    public ReceiveUnitsHandler(IUnitOfWork uow) : base(uow)
    {
    }

    #endregion

    #region Public Interface

    public override void Handle(ReceiveUnits args)
    {
        var (sku, units) = args;
        var product = Uow.Products.Find(sku);

        product.ReceiveUnits(units);

        Uow.Products.Update(product);
        Uow.Commit();
    }

    #endregion
}
