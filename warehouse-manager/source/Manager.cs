using static BoundedContextDemo.Kernel.Command;

namespace BoundedContextDemo.Warehouse.Manager;

public class Manager
{
    private readonly IHandler<ReceiveUnits> _receiveUnitsHandler;

    #region Creation

    public Manager(IHandler<ReceiveUnits> receiveUnitsHandler)
    {
        _receiveUnitsHandler = receiveUnitsHandler;
    }

    #endregion

    #region Public Interface

    public void Run()
    {
        _receiveUnitsHandler.Handle(new("grass-man-01", 10));
        _receiveUnitsHandler.Handle(new("grass-rotary-01", 8));
        _receiveUnitsHandler.Handle(new("grass-riding-01", 6));
        _receiveUnitsHandler.Handle(new("grass-riding-01", 6));
    }

    #endregion
}
