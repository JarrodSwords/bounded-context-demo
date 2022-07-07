using BoundedContextDemo.Kernel;
using static BoundedContextDemo.Kernel.Command;

namespace BoundedContextDemo.Sales.Services;

public abstract class Handler<T> : IHandler<T> where T : Command

{
    protected IUnitOfWork Uow;

    #region Creation

    protected Handler(IUnitOfWork uow)
    {
        Uow = uow;
    }

    #endregion

    #region IHandler<T> Implementation

    public abstract void Handle(T args);

    #endregion
}
