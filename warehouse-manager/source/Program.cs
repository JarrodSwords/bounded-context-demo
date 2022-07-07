using Autofac;
using BoundedContextDemo.Warehouse.Manager;

using var container = new ContainerBuilder().Configure().Build();

var manager = container.Resolve<Manager>();

manager.Run();
