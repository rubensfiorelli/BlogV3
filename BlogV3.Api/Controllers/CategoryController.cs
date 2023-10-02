using BlogV3.Application.InputModels;
using BlogV3.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlogV3.Api.Controllers
{
    [Route("v3")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService) => _categoryService = categoryService;


        [HttpGet("categories")]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetCategories();

            return Ok(categories);
        }

        [HttpGet("categories/{id}")]
        public async Task<IActionResult> GetById(Guid categoryId)
        {
            var category = await _categoryService.GetById(categoryId);

            return Ok(category);
        }

        [HttpPost("categories")]
        public async Task<IActionResult> Post(CategoryInputModel model)
        {
            var categoryId =            
                 await _categoryService.Add(model);

            return CreatedAtAction(nameof(GetById), new { categoryId }, model);
        }       

        [HttpDelete("categories/{id}")]
        public async Task<IActionResult> Delete()
        {
           
            //return CreatedAtAction(nameof(GetById), new { id }, model);
            return Ok();
        }
    }
}
