using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Warehouse;

public class Product : Aggregate
{
    #region Creation

    public Product(string sku, uint unitsOnHand)
    {
        Sku = sku;
        UnitsOnHand = unitsOnHand;
    }

    #endregion

    #region Public Interface

    public string Sku { get; }
    public uint UnitsOnHand { get; private set; }

    public Product ReceiveUnits(uint units)
    {
        UnitsOnHand += units;
        return this;
    }

    #endregion
}