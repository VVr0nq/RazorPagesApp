using Microsoft.EntityFrameworkCore;
using RazorPagesShoppingList.Pages;

namespace RazorPagesShoppingList.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Products> Produkty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }
    }
}
