namespace WebApplication2.Services.BookService
{
    public class BookService : IBookService
    {
        private static List<Book> books = new List<Book> {
                new Book
                {
                    Id = 1,
                    Title = "Kingdom",
                    Author = "Yohou",
                    Category = "Manga",
                    Year="2008"
                },
                 new Book
                 {
                    Id = 2,
                    Title = "Kingdom2",
                    Author = "Yohou2",
                    Category = "Manga2",
                    Year="2022"
                 }
            };

        public List<Book> AddBook(Book book)
        {
            books.Add(book);
            return books;
        }

        public List<Book> DeleteBook(int id)
        {
            var book = books.Find(x => x.Id == id);
            if (book is null)
                return null;

            books.Remove(book);

            return books;
        }

        public List<Book> GetAllBooks()
        {
            return books;
        }

        public Book GetBook(int id)
        {
            var book = books.Find(x => x.Id == id);
            if (book is null)
                return null;

            return book;
        }

        public List<Book> UpdateBook(int id, Book request)
        {
            var book = books.Find(x => x.Id == id);
            if (book is null)
                return null;

            book.Author = request.Author;
            book.Title = request.Title;
            book.Category = request.Category;
            book.Year = request.Year;

            return books;
        }
    }
}
