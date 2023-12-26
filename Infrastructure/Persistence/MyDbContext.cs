using Microsoft.EntityFrameworkCore;

using Domain.Entities;


namespace Infrastructure.Persistence;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders {get; set;}
    public DbSet<Product> Products {get; set;}
    public DbSet<OrderLineItem> OrderLineItems {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().ToTable("Customer");
        modelBuilder.Entity<Order>().ToTable("Order");
        modelBuilder.Entity<Product>().ToTable("Product");
        
    }
}
