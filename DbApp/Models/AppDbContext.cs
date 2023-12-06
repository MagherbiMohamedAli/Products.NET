using Microsoft.EntityFrameworkCore;

namespace DbApp.Models{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products
        { get; set; }
        }
}