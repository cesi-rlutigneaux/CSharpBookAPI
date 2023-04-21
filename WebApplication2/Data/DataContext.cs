global using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebApplication2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(s => s.Author)
                .WithMany(ad => ad.Books)
                .HasForeignKey(s => s.AuthorId);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Author> Author { get; set; }
    }
}
