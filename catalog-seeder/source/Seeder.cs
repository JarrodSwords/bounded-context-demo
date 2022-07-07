using BoundedContextDemo.Kernel;

namespace BoundedContextDemo.Catalog.Seeder;

public class Seeder
{
    private readonly Command.IHandler<RegisterProduct> _registerProductHandler;

    #region Creation

    public Seeder(Command.IHandler<RegisterProduct> registerProductHandler)
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
                "grass-man-01"
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
