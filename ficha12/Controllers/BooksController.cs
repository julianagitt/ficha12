using ficha12.Models;
using ficha12.Services;
using Microsoft.AspNetCore.Mvc;

namespace ficha12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService service;

        public BooksController(IBookService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return service.GetALL();
        }

        [HttpGet("{isbn}", Name = "GetByISBN")]
        public IActionResult Get(string isbn)
        {
            Book? book = service.GetByISBN(isbn);
            if (book == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(book);
            }
        }
        // esta parte copiei pelo codigo da andreia falta fazer a parte do BookService
        [HttpGet("{author}")]
        public IActionResult GetAuthor(string author);
        {
            Book? book = service.GetByAuthor(author);
            if(book ==null)
            {
                return NotFund();
            }
            else
            {
            return OK(author);
            }
        }


    }
}