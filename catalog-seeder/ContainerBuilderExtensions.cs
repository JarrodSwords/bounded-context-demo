using System.Reflection;
using Autofac;
using BoundedContextDemo.Catalog.Infrastructure;
using BoundedContextDemo.Catalog.Services;

namespace BoundedContextDemo.Catalog.Seeder;

public static class ContainerBuilderExtensions
{
    private static readonly Assembly[] Assemblies =
    {
        typeof(Seeder).Assembly,
        typeof(RegisterProductHandler).Assembly,
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
