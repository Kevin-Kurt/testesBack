using Microsoft.EntityFrameworkCore;
using Back_Estoque.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Backend_Estoque.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
              .Property(p => p.Name)
                .HasMaxLength(80);

            modelBuilder.Entity<Product>()
              .Property(p => p.Price)
                .HasPrecision(10, 2);

           
        }

    }
}