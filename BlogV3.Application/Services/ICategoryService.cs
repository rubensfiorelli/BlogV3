using BlogV3.Application.InputModels;
using BlogV3.Application.ViewModels;

namespace BlogV3.Application.Services
{
    public interface ICategoryService
    {
        Task<CategoryOutputDTO> Add(CategoryInputModel model);
        Task<CategoryOutputDTO> GetById(Guid categoryId);
        Task<List<CategoryOutputDTO>> GetCategories();
    }
}
