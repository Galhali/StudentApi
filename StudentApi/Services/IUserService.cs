using StudentApi.Models;

namespace StudentApi.Services
{
    public interface IUserService
    {
        Task<User?> ValidateUserAsync(string username, string password);
        Task AddUserAsync(User user);
    }
}
