using BlogV3.Domain.Entities;

namespace BlogV3.Domain.Repositories
{
    public interface ICategoryRepository
    {
        Task AddAsync(Category category);
        Task<Category> GetCategoryByIdAsync(Guid id);
        Task<List<Category>> GetCategoriesAsync();
    }
}
