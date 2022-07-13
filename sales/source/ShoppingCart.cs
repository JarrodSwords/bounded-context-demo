using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Sales;

public class ShoppingCart : Aggregate
{
    private readonly List<LineItem> _lineItems = new();

    #region Creation

    public ShoppingCart(Guid customerId, Guid id = default) : base(id)
    {
        CustomerId = customerId;
    }

    #endregion

    #region Public Interface

    public Guid CustomerId { get; }
    public IReadOnlyCollection<LineItem> LineItems => _lineItems.AsReadOnly();
    public decimal Total => _lineItems.Sum(x => x.Subtotal);

    public ShoppingCart Add(Product product, uint units)
    {
        _lineItems.Add(new(product.Price, product.Id, units));
        return this;
    }

    #endregion
}
