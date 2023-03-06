using Microsoft.EntityFrameworkCore;
using SimpleStore.Api.DAL.Entities;

namespace SimpleStore.Api.DAL;

public sealed class ProductsDbContext : DbContext
{
    public DbSet<ProductEntity>? Products { get; set; }
}