using LibraryMgmtSystem.Entities;
using LibraryMgmtSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryMgmtSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ApplicationDBContext dbContext;

        public CategoryController(ApplicationDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //Get all Categorylist

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            var allCategories = dbContext.category.ToList();
            return Ok(allCategories);
        }
        //add new category
        [HttpPost]
        public IActionResult AddCategory(AddCategory addCategoryDto)
        {
            var categoryEntity = new Category()
            {
                Name = addCategoryDto.Name,
                Description = addCategoryDto.Description


            };

            dbContext.category.Add(categoryEntity);
            dbContext.SaveChanges();
            return Ok(categoryEntity);
        }

    }
}
