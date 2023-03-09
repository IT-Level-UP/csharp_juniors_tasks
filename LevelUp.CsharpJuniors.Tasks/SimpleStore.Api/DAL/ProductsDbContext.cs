using Microsoft.EntityFrameworkCore;
using SimpleStore.Api.DAL.Configurations;
using SimpleStore.Api.DAL.Entities;

namespace SimpleStore.Api.DAL;

public sealed class ProductsDbContext : DbContext
{
    public DbSet<ProductEntity>? Products { get; set; }

    public ProductsDbContext(DbContextOptions<ProductsDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());
    }
}