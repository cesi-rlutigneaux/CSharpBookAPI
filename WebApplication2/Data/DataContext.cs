global using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=bookdb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Book> Books { get; set; }
    }
}
