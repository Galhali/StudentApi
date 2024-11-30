using StudentApi.Models;

namespace StudentApi.Repositories
{
    public interface IUserRepository
    {
        Task<User?> GetUserByNameAsync(string username);

        Task AddUserAsync(User user);
    }
}
