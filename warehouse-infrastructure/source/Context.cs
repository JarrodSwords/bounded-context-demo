using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Warehouse.Infrastructure;

public class Context : DbContext
{
    #region Public Interface

    public DbSet<Order> Order { get; set; }
    public DbSet<Product> Product { get; set; }

    #endregion

    #region Protected Interface

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=BECKY\\SQLEXPRESS;Initial Catalog=BoundedContextDemo;Integrated Security=True;Connect Timeout=60;"
        );
    }

    #endregion
}
