using WebApplication2.Data;

namespace WebApplication2.Services.BookService
{
    public class BookService : IBookService
    {
        private readonly DataContext _context;

        public BookService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> AddBook(Book book)
        {
            _context.Books.Add(book);
            await _context.SaveChangesAsync();
            return await _context.Books.ToListAsync();
        }

        public async Task<List<Book>?> DeleteBook(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book is null)
                return null;

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();

            return await _context.Books.ToListAsync();
        }

        public async Task<List<Book>> GetAllBooks()
        {
            var books = await _context.Books.Include(b => b.Author).ToListAsync();
            return books;
        }

        public async Task<Book?> GetBook(int id)
        {
            var book = await _context.Books.Include(b => b.Author).FirstOrDefaultAsync();
            if (book is null)
                return null;

            return book;
        }

        public async Task<List<Book>?> UpdateBook(int id, Book request)
        {
            var book = await _context.Books.FindAsync(id);
            if (book is null)
                return null;

            book.Author = request.Author;
            book.Title = request.Title;
            book.Category = request.Category;
            book.Year = request.Year;

            await _context.SaveChangesAsync();

            return await _context.Books.ToListAsync();
        }
    }
}
