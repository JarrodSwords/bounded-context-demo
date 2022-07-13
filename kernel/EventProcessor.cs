namespace BoundedContextDemo.Kernel;

public static class EventProcessor
{
    private static List<Type> _handlerTypes = new();

    #region Static Interface

    public static void Dispatch(Event @event)
    {
        foreach (var handlerType in _handlerTypes)
        {
            var canHandleEvent = handlerType.GetInterfaces()
                .Any(
                    x => x.IsGenericType
                      && x.GetGenericTypeDefinition() == typeof(IEventHandler<>)
                      && x.GenericTypeArguments[0] == @event.GetType()
                );

            if (canHandleEvent)
            {
                dynamic handler = Activator.CreateInstance(handlerType)!;
                handler.Handle((dynamic)@event);
            }
        }
    }

    public static void Init()
    {
        _handlerTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(x => x.GetTypes())
            .Where(
                x => x.GetInterfaces().Any(
                    y => y.IsGenericType
                      && y.GetGenericTypeDefinition() == typeof(IEventHandler<>)
                )
            )
            .ToList();
    }

    #endregion
}
