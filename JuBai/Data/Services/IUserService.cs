using JuBai.Models;

namespace JuBai.Data.Services
{
    public interface IUserService
    {
        Task<IEnumerable<UserService>> GetAllUsersAsync();
        Task<UserService?> GetUserByIdAsync(int id);
        Task CreateUserAsync(UserService user);
        Task UpdateUserAsync(UserService user);
        Task DeleteUserAsync(int id);
    }
}
