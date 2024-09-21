using JuBai.Models;
using Microsoft.EntityFrameworkCore;

namespace JuBai.Data.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category?> GetCategoryByIdAsync(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task CreateCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();
            }
        }

        Task<IEnumerable<CategoryService>> ICategoryService.GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }

        Task<CategoryService?> ICategoryService.GetCategoryByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task CreateCategoryAsync(CategoryService category)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(CategoryService category)
        {
            throw new NotImplementedException();
        }
    }
}
