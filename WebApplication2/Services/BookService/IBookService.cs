namespace WebApplication2.Services.BookService
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooks();
        Task<Book?> GetBook(int id);
        Task<List<Book>> AddBook(Book book);
        Task<List<Book>?> UpdateBook(int id, Book request);
        Task<List<Book>?> DeleteBook(int id);
    }
}
