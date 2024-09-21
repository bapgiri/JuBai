using JuBai.Models;
using Microsoft.EntityFrameworkCore;

namespace JuBai.Data.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User?> GetUserByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task CreateUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUserAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }
        }

        Task<IEnumerable<UserService>> IUserService.GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        Task<UserService?> IUserService.GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task CreateUserAsync(UserService user)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(UserService user)
        {
            throw new NotImplementedException();
        }
    }
}
