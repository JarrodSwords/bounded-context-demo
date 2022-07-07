using Autofac;

namespace BoundedContextDemo.Catalog.Seeder;

public class AutofacModule : Module
{
    #region Protected Interface

    protected override void Load(ContainerBuilder builder)
    {
        builder
            .RegisterAssemblyTypes(typeof(AutofacModule).Assembly)
            .AsSelf();
    }

    #endregion
}
