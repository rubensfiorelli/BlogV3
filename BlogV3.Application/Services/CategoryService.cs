using BlogV3.Application.InputModels;
using BlogV3.Application.ViewModels;
using BlogV3.Domain.Repositories;

namespace BlogV3.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository) => _repository = repository;

        public async Task<CategoryOutputDTO> Add(CategoryInputModel model)
        {
            var category = model.ToEntity();

            await _repository.AddAsync(category);

            return (CategoryOutputDTO)category;
        }

        public async Task<CategoryOutputDTO> GetById(Guid categoryId)
        {

            var category = await _repository.GetCategoryByIdAsync(categoryId);

            return (CategoryOutputDTO)category;

        }

        public async Task<List<CategoryOutputDTO>> GetCategories()
        {
            var categories = await _repository.GetCategoriesAsync();

            return categories
                .Select(x => new CategoryOutputDTO(x.Id, x.Name, x.Slug))
                .ToList();
        }


    }
}
