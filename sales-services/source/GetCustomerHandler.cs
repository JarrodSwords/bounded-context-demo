namespace BoundedContextDemo.Sales.Services;

public class GetCustomerHandler : Handler<GetCustomer, CustomerDto>
{
    #region Creation

    public GetCustomerHandler(IUnitOfWork uow) : base(uow)
    {
    }

    #endregion

    #region Public Interface

    public override CustomerDto Handle(GetCustomer args) => Uow.Customers.QueryCustomer(args.Name, args.Surname);

    #endregion
}
