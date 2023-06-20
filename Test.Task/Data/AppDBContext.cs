using Microsoft.EntityFrameworkCore;
using Test.Task.Entities;

namespace Test.Task.Data;

public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions<AppDBContext> options ) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 1,
            Title = "HDD 1TB",
            Quantiy = "55",
            Price = "74.99"
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 2,
            Title = " HDD SSD 512GB ",
            Quantiy = "102",
            Price = "109.99"
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 3,
            Title = " RAM DDR4 16GB",
            Quantiy = "47",
            Price = "80.99"
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 4,
            Title = "SDD 1TB",
            Quantiy = "120",
            Price = "149.99"
        });
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<SignUp> User { get; set; }
}