using JuBai.Models;

namespace JuBai.Data.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryService>> GetAllCategoriesAsync();
        Task<CategoryService?> GetCategoryByIdAsync(int id);
        Task CreateCategoryAsync(CategoryService category);
        Task UpdateCategoryAsync(CategoryService category);
        Task DeleteCategoryAsync(int id);
    }
}
