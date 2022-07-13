using BoundedContextDemo.Catalog;
using BoundedContextDemo.Kernel;
using BoundedContextDemo.Sales;
using BoundedContextDemo.Warehouse;
using static BoundedContextDemo.Kernel.Command;
using static BoundedContextDemo.Kernel.Query;
using IProductRepository = BoundedContextDemo.Sales.IProductRepository;

namespace BoundedContextDemo.Simulator;

public class Simulator
{
    private const string ReelMowerSku = "mower-reel-01";
    private const string RidingMowerSku = "mower-riding-01";
    private const string ScytheSku = "mower-manual-01";
    private readonly IHandler<AddToShoppingCart> _addToShoppingCartHandler;
    private readonly IHandler<BeginShopping> _beginShoppingHandler;
    private readonly IHandler<Checkout> _checkoutHandler;
    private readonly IHandler<GetCustomer, CustomerDto> _getCustomerHandler;
    private readonly IProductRepository _productRepository;
    private readonly IHandler<ReceiveUnits> _receiveUnitsHandler;
    private readonly IHandler<RegisterProduct> _registerProductHandler;
    private readonly IHandler<SetPrice> _setPriceHandler;
    private readonly IShoppingCartRepository _shoppingCartRepository;

    #region Creation

    public Simulator(
        IHandler<AddToShoppingCart> addToShoppingCartHandler,
        IHandler<Checkout> checkoutHandler,
        IHandler<GetCustomer, CustomerDto> getCustomerHandler,
        IHandler<BeginShopping> beginShoppingHandler,
        IProductRepository productRepository,
        IHandler<ReceiveUnits> receiveUnitsHandler,
        IHandler<RegisterProduct> registerProductHandler,
        IHandler<SetPrice> setPriceHandler,
        IShoppingCartRepository shoppingCartRepository
    )
    {
        EventProcessor.Init();
        _addToShoppingCartHandler = addToShoppingCartHandler;
        _checkoutHandler = checkoutHandler;
        _getCustomerHandler = getCustomerHandler;
        _beginShoppingHandler = beginShoppingHandler;
        _productRepository = productRepository;
        _receiveUnitsHandler = receiveUnitsHandler;
        _registerProductHandler = registerProductHandler;
        _setPriceHandler = setPriceHandler;
        _shoppingCartRepository = shoppingCartRepository;
    }

    #endregion

    #region Public Interface

    public void Run()
    {
        RegisterProducts();
        SetPrices();
        ReceiveUnits();
        DoSomeShopping();
    }

    #endregion

    #region Private Interface

    private void DoSomeShopping()
    {
        var customer = _getCustomerHandler.Handle(new("John", "Doe"));
        var oldCarts = customer.ShoppingCarts.Select(x => x.Id).ToList();

        _beginShoppingHandler.Handle(new(customer.Id));

        var shoppingCartId = _getCustomerHandler.Handle(new("John", "Doe"))
            .ShoppingCarts
            .Select(x => x.Id)
            .Except(oldCarts)
            .First();

        var scythe = _productRepository.Find(ScytheSku);
        _addToShoppingCartHandler.Handle(new(scythe.Id, shoppingCartId, 2));

        _checkoutHandler.Handle(new(shoppingCartId));
    }

    private void ReceiveUnits()
    {
        _receiveUnitsHandler.Handle(new(ScytheSku, 48));
        _receiveUnitsHandler.Handle(new(ReelMowerSku, 24));
        _receiveUnitsHandler.Handle(new(RidingMowerSku, 12));
    }

    private void RegisterProducts()
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
    }

    private void SetPrices()
    {
        _setPriceHandler.Handle(new(9.99m, ScytheSku));
        _setPriceHandler.Handle(new(99.99m, ReelMowerSku));
        _setPriceHandler.Handle(new(1999.99m, RidingMowerSku));
    }

    #endregion
}
