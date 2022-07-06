using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Catalog.Infrastructure;

public class Context : DbContext
{
    #region Public Interface

    public DbSet<Product> Product { get; set; }

    #endregion
}
