namespace WebApplication2.Services.BookService
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBook(int id);
        List<Book> AddBook(Book book);
        List<Book> UpdateBook(int id, Book request);
        List<Book> DeleteBook(int id);
    }
}
