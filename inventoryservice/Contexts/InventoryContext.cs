using inventoryservice.Models;
using Microsoft.EntityFrameworkCore;

namespace inventoryservice.Contexts
{
    public class InventoryContext : DbContext
    {

        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.Supplier);

        }
    }
}
