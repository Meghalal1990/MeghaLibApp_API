using LibraryMgmtSystem.Entities;
using LibraryMgmtSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace LibraryMgmtSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly ApplicationDBContext dbContext;

        public AuthorController(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Get all Authorlist
        [HttpGet]
        public IActionResult GetAllAuthors()
        {
            var allAuthors = dbContext.author.ToList();
            return Ok(allAuthors);
        }

        //Add new author
        [HttpPost]
        public IActionResult AddAuthor(AddAuthor addAuthorDto)
        {
            var authorEntity = new Author()
            {
                Name = addAuthorDto.Name,
                Bio = addAuthorDto.Bio
                

            };

            dbContext.author.Add(authorEntity);
            dbContext.SaveChanges();
            return Ok(authorEntity);
        }

    }
}
