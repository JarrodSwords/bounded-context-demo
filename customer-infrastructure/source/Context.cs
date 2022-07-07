using Microsoft.EntityFrameworkCore;
using static System.Guid;

namespace BoundedContextDemo.Infrastructure.Customers;

public class Context : DbContext
{
    #region Public Interface

    public DbSet<Customer> Customer { get; set; }

    #endregion

    #region Protected Interface

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=BECKY\\SQLEXPRESS;Initial Catalog=CustomerData;Integrated Security=True;Connect Timeout=60;"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasData(
            new Customer { Id = NewGuid(), Name = "John", Surname = "Doe" },
            new Customer { Id = NewGuid(), Name = "Jane", Surname = "Doe" }
        );
    }

    #endregion
}
