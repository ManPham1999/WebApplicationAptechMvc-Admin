﻿using KerryExample.Entity;
using Microsoft.EntityFrameworkCore;

namespace KerryExample
{
  public class MainDbContext : DbContext
  {

    public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.ApplyConfigurationsFromAssembly(typeof(MainDbContext).Assembly);
      //base.OnModelCreating(builder);
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Catgory> Catgories { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<CartType> CartTypes { get; set; }
    public DbSet<CartLine> CartLines { get; set; }
  }
}
