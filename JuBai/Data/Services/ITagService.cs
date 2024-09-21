using JuBai.Models;

namespace JuBai.Data.Services
{
    public interface ITagService
    {
        Task<IEnumerable<TagService>> GetAllTagsAsync();
        Task<TagService?> GetTagByIdAsync(int id);
        Task CreateTagAsync(TagService tag);
        Task UpdateTagAsync(TagService tag);
        Task DeleteTagAsync(int id);
    }
}
