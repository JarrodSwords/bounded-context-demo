using System.Reflection;
using Autofac;
using BoundedContextDemo.Catalog.Infrastructure;
using BoundedContextDemo.Catalog.Services;
using BoundedContextDemo.Sales.Services;
using BoundedContextDemo.Shipping.Services;
using BoundedContextDemo.Warehouse.Services;

namespace BoundedContextDemo.Simulator;

using CatalogContext = Context;
using SalesContext = Sales.Infrastructure.Context;
using ShippingContext = Shipping.Infrastructure.Context;
using WarehouseContext = Warehouse.Infrastructure.Context;

public static class ContainerBuilderExtensions
{
    private static readonly Assembly[] Assemblies =
    {
        typeof(ContainerBuilderExtensions).Assembly,
        typeof(PrepareShipmentHandler).Assembly,
        typeof(ReceiveUnitsHandler).Assembly,
        typeof(RegisterProductHandler).Assembly,
        typeof(SetPriceHandler).Assembly,
        typeof(CatalogContext).Assembly,
        typeof(SalesContext).Assembly,
        typeof(ShippingContext).Assembly,
        typeof(WarehouseContext).Assembly
    };

    #region Static Interface

    public static ContainerBuilder Configure(this ContainerBuilder builder)
    {
        builder.RegisterAssemblyModules(Assemblies);
        return builder;
    }

    #endregion
}
