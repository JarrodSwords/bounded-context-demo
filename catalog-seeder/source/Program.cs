using Autofac;
using BoundedContextDemo.Catalog.Seeder;

using var container = new ContainerBuilder().Configure().Build();

var seeder = container.Resolve<Seeder>();

seeder.Run();
