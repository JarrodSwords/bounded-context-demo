using Autofac;
using BoundedContextDemo.Simulator;

using var container = new ContainerBuilder().Configure().Build();

var simulator = container.Resolve<Simulator>();

simulator.Run();
