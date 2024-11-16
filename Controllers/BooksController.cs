using LibraryMgmtSystem.Entities;
using LibraryMgmtSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryMgmtSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly ApplicationDBContext dbContext;

        public BooksController(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Get all Books
        [HttpGet]
        public IActionResult GetData()
        {
            var allBooks = dbContext.books.ToList();
            return Ok(allBooks);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetBookById(int id)
        {
            var book = dbContext.books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);

        }
        [HttpPost]
        public IActionResult AddBook(AddBook addbookDto)
        {
            var bookEntity = new Book()
            {
                Title = addbookDto.Title,
                Description = addbookDto.Description,
                Year = addbookDto.Year,
                CategoryId = addbookDto.CategoryId,
               AuthorId = addbookDto.AuthorId,

            };

            dbContext.books.Add(bookEntity);
            dbContext.SaveChanges();
            return Ok(bookEntity);
        }

    }


}
