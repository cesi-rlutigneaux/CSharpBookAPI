using Microsoft.AspNetCore.Mvc;
using WebApplication2.Services.BookService;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAllBooks()
        {
            return await _bookService.GetAllBooks();
        }

        [HttpGet("{id}")]
        //[Route("{id}")]
        public async Task<ActionResult<List<Book>>> GetBook(int id)
        {
            var result = await _bookService.GetBook(id);
            if (result is null)
                return NotFound("Book not found");
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Book>>> AddBook(Book book)
        {
            var result = await _bookService.AddBook(book);
            if (result is null)
                return NotFound("Book not found");
            return Ok(result);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<List<Book>>> UpdateBook(int id, Book request)
        {
            var result = await _bookService.UpdateBook(id, request);
            if (result is null)
                return NotFound("Book not found");
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<Book>>> DeleteBook(int id)
        {
            var result = await _bookService.DeleteBook(id);
            if (result is null)
                return NotFound("Book not found");
            return Ok(result);
        }
    }
}
