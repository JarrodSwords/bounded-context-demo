using static BoundedContextDemo.Kernel.Command;

namespace BoundedContextDemo.Catalog.Seeder;

public class Seeder
{
    private readonly IHandler<RegisterProduct> _registerProductHandler;

    #region Creation

    public Seeder(IHandler<RegisterProduct> registerProductHandler)
    {
        _registerProductHandler = registerProductHandler;
    }

    #endregion

    #region Public Interface

    public void Run()
    {
        _registerProductHandler.Handle(
            new(
                "An inexpensive, environmentally-conscious grass-shortening solution",
                "Scythe",
                "mower-manual-01"
            )
        );
        _registerProductHandler.Handle(
            new(
                "An environmentally-conscious grass-shortening solution",
                "Rotary Mower",
                "grass-rotary-01"
            )
        );
        _registerProductHandler.Handle(
            new(
                "A luxury grass-shortening solution",
                "Riding Mower",
                "grass-riding-01"
            )
        );
    }

    #endregion
}
