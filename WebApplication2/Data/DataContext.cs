global using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Book> Seller { get; set; }
        public DbSet<Book> Author { get; set; }
    }
}
