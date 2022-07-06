using System.Reflection;
using Autofac;
using BoundedContextDemo.Warehouse.Infrastructure;
using BoundedContextDemo.Warehouse.Services;

namespace BoundedContextDemo.Warehouse.Manager;

public static class ContainerBuilderExtensions
{
    private static readonly Assembly[] Assemblies =
    {
        typeof(Manager).Assembly,
        typeof(ReceiveUnitsHandler).Assembly,
        typeof(Context).Assembly
    };

    #region Static Interface

    public static ContainerBuilder Configure(this ContainerBuilder builder)
    {
        builder.RegisterAssemblyModules(Assemblies);
        return builder;
    }

    #endregion
}
