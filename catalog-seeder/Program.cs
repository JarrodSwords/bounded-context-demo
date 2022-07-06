// See https://aka.ms/new-console-template for more information

using Autofac;
using BoundedContextDemo.Catalog.Seeder;

using var container = new ContainerBuilder().Configure().Build();

var seeder = container.Resolve<Seeder>();

seeder.Run();
