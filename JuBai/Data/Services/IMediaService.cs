using JuBai.Models;

namespace JuBai.Data.Services
{
    public interface IMediaService
    {
        Task<IEnumerable<MediaService>> GetAllMediaAsync();
        Task<MediaService?> GetMediaByIdAsync(int id);
        Task CreateMediaAsync(MediaService media);
        Task UpdateMediaAsync(MediaService media);
        Task DeleteMediaAsync(int id);
    }
}
