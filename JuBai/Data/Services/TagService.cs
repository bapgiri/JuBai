using JuBai.Models;
using Microsoft.EntityFrameworkCore;

namespace JuBai.Data.Services
{
    public class TagService : ITagService
    {
        private readonly ApplicationDbContext _context;

        public TagService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Correct return type
        public async Task<IEnumerable<Tag>> GetAllTagsAsync()
        {
            return await _context.Tags.ToListAsync();
        }

        public async Task<Tag?> GetTagByIdAsync(int id)
        {
            return await _context.Tags.FindAsync(id);
        }

        public async Task CreateTagAsync(Tag tag)
        {
            await _context.Tags.AddAsync(tag);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTagAsync(Tag tag)
        {
            _context.Tags.Update(tag);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTagAsync(int id)
        {
            var tag = await _context.Tags.FindAsync(id);
            if (tag != null)
            {
                _context.Tags.Remove(tag);
                await _context.SaveChangesAsync();
            }
        }

        Task<IEnumerable<TagService>> ITagService.GetAllTagsAsync()
        {
            throw new NotImplementedException();
        }

        Task<TagService?> ITagService.GetTagByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task CreateTagAsync(TagService tag)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTagAsync(TagService tag)
        {
            throw new NotImplementedException();
        }
    }
}
