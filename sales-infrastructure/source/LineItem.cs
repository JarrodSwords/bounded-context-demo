using BoundedContextDemo.Infrastructure;

namespace BoundedContextDemo.Sales.Infrastructure;

using SalesLineItem = Sales.LineItem;

public class LineItem : Entity
{
    #region Creation

    public LineItem()
    {
    }

    public LineItem(SalesLineItem source)
    {
        Id = source.Id;
        Price = source.Price;
        ProductId = source.ProductId;
        Units = source.Units;
    }

    #endregion

    #region Public Interface

    public decimal Price { get; set; }
    public Guid ProductId { get; set; }
    public decimal Subtotal => Price * Units;
    public uint Units { get; set; }

    #endregion

    #region Static Interface

    public static implicit operator LineItem(SalesLineItem source) => new(source);

    #endregion
}
