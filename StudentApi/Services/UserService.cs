using StudentApi.Models;
using StudentApi.Repositories;

namespace StudentApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task AddUserAsync(User user)
        {
           await userRepository.AddUserAsync(user);
        }

        public async Task<User?> ValidateUserAsync(string username, string password)
        {
            var user = await userRepository.GetUserByNameAsync(username);
            return user != null && user.HashedPassword == password ? user : null;
        }
    }
}
