using Autofac;
using BoundedContextDemo.Sales.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Simulator;

public class AutofacModule : Module
{
    #region Protected Interface

    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterAssemblyTypes(typeof(AutofacModule).Assembly)
            .AsSelf();

        builder.RegisterType<Context>().As<DbContext>();
    }

    #endregion
}
