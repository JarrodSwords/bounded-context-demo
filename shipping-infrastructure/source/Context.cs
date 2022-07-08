using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Shipping.Infrastructure;

public class Context : DbContext
{
    #region Public Interface

    public DbSet<Shipment> Shipment { get; set; }

    #endregion

    #region Protected Interface

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=BECKY\\SQLEXPRESS;Initial Catalog=CustomerData;Integrated Security=True;Connect Timeout=60;"
        );
    }

    #endregion
}
