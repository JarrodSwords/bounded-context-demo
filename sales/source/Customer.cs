using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public class Customer : Aggregate
{
    #region Creation

    public Customer(string name, string surname, Guid id) : base(id)
    {
        Name = name;
        Surname = surname;
    }

    #endregion

    #region Public Interface

    public string Name { get; }
    public string Surname { get; }

    #endregion
}
