using Autofac;

namespace BoundedContextDemo.Warehouse.Infrastructure;

public class AutofacModule : Module
{
    #region Protected Interface

    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterAssemblyTypes(typeof(AutofacModule).Assembly)
            .AsImplementedInterfaces();

        builder.RegisterType<Context>().AsSelf();
    }

    #endregion
}
