using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public class Customer : Aggregate
{
    #region Public Interface

    public string Name { get; }
    public string Surname { get; }

    #endregion
}
