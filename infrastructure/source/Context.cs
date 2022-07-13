﻿using Microsoft.EntityFrameworkCore;

namespace BoundedContextDemo.Infrastructure;

public class Context : DbContext
{
    #region Public Interface

    public DbSet<Customer> Customer { get; set; }
    public DbSet<LineItem> LineItem { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<ShoppingCart> ShoppingCart { get; set; }

    #endregion

    #region Protected Interface

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=BECKY\\SQLEXPRESS;Initial Catalog=BoundedContextDemo;Integrated Security=True;Connect Timeout=60;"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(x => x.ToView("CustomerView"));
    }

    #endregion
}
