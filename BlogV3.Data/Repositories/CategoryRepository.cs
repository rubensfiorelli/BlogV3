using BlogV3.Data.DataContext;
using BlogV3.Domain.Entities;
using BlogV3.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BlogV3.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) => _context = context;
       

        public async Task AddAsync(Category category)
        {
            var entity = await _context.Categories.AddAsync(category);

            await _context.SaveChangesAsync();            
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = await _context.Categories.ToListAsync();

            return categories;
        }

        public Task<Category> GetCategoryByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Category> UpdateAsync(Guid id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
