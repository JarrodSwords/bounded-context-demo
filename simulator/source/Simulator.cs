using BoundedContextDemo.Catalog;
using BoundedContextDemo.Sales;
using BoundedContextDemo.Shipping;
using BoundedContextDemo.Warehouse;
using static BoundedContextDemo.Kernel.Command;
using static BoundedContextDemo.Kernel.Query;
using CustomerDto = BoundedContextDemo.Sales.CustomerDto;

namespace BoundedContextDemo.Simulator;

public class Simulator
{
    private const string ReelMowerSku = "mower-reel-01";
    private const string RidingMowerSku = "mower-riding-01";
    private const string ScytheSku = "mower-manual-01";
    private readonly IHandler<BeginShopping> _beginShoppingHandler;
    private readonly IHandler<GetCustomer, CustomerDto> _getCustomerHandler;
    private readonly IHandler<PrepareShipment> _prepareShipmentHandler;
    private readonly IHandler<ReceiveUnits> _receiveUnitsHandler;
    private readonly IHandler<RegisterProduct> _registerProductHandler;
    private readonly IHandler<SetPrice> _setPriceHandler;

    #region Creation

    public Simulator(
        IHandler<BeginShopping> beginShoppingHandler,
        IHandler<GetCustomer, CustomerDto> getCustomerHandler,
        IHandler<PrepareShipment> prepareShipmentHandler,
        IHandler<ReceiveUnits> receiveUnitsHandler,
        IHandler<RegisterProduct> registerProductHandler,
        IHandler<SetPrice> setPriceHandler
    )
    {
        _beginShoppingHandler = beginShoppingHandler;
        _getCustomerHandler = getCustomerHandler;
        _prepareShipmentHandler = prepareShipmentHandler;
        _receiveUnitsHandler = receiveUnitsHandler;
        _registerProductHandler = registerProductHandler;
        _setPriceHandler = setPriceHandler;
    }

    #endregion

    #region Public Interface

    public void Run()
    {
        _registerProductHandler.Handle(
            new(
                "An inexpensive, environmentally-conscious grass-shortening solution",
                "Scythe",
                ScytheSku
            )
        );

        _registerProductHandler.Handle(
            new(
                "An environmentally-conscious grass-shortening solution",
                "Push Reel Mower",
                ReelMowerSku
            )
        );

        _registerProductHandler.Handle(
            new(
                "A luxury grass-shortening solution",
                "Riding Mower",
                RidingMowerSku
            )
        );

        _setPriceHandler.Handle(new(9.99m, ScytheSku));
        _setPriceHandler.Handle(new(99.99m, ReelMowerSku));
        _setPriceHandler.Handle(new(1999.99m, RidingMowerSku));

        _receiveUnitsHandler.Handle(new(ScytheSku, 48));
        _receiveUnitsHandler.Handle(new(ReelMowerSku, 24));
        _receiveUnitsHandler.Handle(new(RidingMowerSku, 12));

        _beginShoppingHandler.Handle(new("John", "Doe"));

        var customer = _getCustomerHandler.Handle(new("John", "Doe"));

        var prepareShipment = new PrepareShipment(
            customer.Id,
            new CreateLineItemDto(ScytheSku, 2),
            new CreateLineItemDto(RidingMowerSku, 1)
        );

        _prepareShipmentHandler.Handle(prepareShipment);
    }

    #endregion
}
