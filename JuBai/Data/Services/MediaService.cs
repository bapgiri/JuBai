using JuBai.Models;
using Microsoft.EntityFrameworkCore;

namespace JuBai.Data.Services
{
    public class MediaService : IMediaService
    {
        private readonly ApplicationDbContext _context;

        public MediaService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Media>> GetAllMediaAsync()
        {
            return await _context.Media.ToListAsync();
        }

        public async Task<Media?> GetMediaByIdAsync(int id)
        {
            return await _context.Media.FindAsync(id);
        }

        public async Task CreateMediaAsync(Media media)
        {
            await _context.Media.AddAsync(media);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMediaAsync(Media media)
        {
            _context.Media.Update(media);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMediaAsync(int id)
        {
            var media = await _context.Media.FindAsync(id);
            if (media != null)
            {
                _context.Media.Remove(media);
                await _context.SaveChangesAsync();
            }
        }

        Task<IEnumerable<MediaService>> IMediaService.GetAllMediaAsync()
        {
            throw new NotImplementedException();
        }

        Task<MediaService?> IMediaService.GetMediaByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task CreateMediaAsync(MediaService media)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMediaAsync(MediaService media)
        {
            throw new NotImplementedException();
        }
    }
}
