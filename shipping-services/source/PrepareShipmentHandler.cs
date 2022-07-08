using System.Transactions;

namespace BoundedContextDemo.Shipping.Services;

public class PrepareShipmentHandler : Handler<PrepareShipment>
{
    private readonly Warehouse.IUnitOfWork _whUow;

    #region Creation

    public PrepareShipmentHandler(IUnitOfWork uow, Warehouse.IUnitOfWork whUow) : base(uow)
    {
        _whUow = whUow;
    }

    #endregion

    #region Public Interface

    public override void Handle(PrepareShipment args)
    {
        var (customerId, lineItems) = args;

        using var scope = new TransactionScope();

        try
        {
            var items = new List<LineItem>();

            foreach (var lineItem in lineItems)
            {
                var product = _whUow.Products.Find(lineItem.Sku);
                items.Add(new LineItem(product.Id, lineItem.Units));
                product.ShipUnits(lineItem.Units);
                _whUow.Products.Update(product);
            }

            var shipment = new Shipment(customerId, default, items.ToArray());

            Uow.Shipments.Create(shipment);
            Uow.Commit();
            _whUow.Commit();

            scope.Complete();
        }
        catch (Exception e)
        {
            // do nothing
        }
    }

    #endregion
}
