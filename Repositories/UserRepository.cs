using UserApi.Models;
using UserApi.Persistence;

namespace UserApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _userContext;

        public UserRepository(UserContext userContext)
        {
            _userContext = userContext;
        }

        public async Task<User> CreateUser(User user)
        {
            await _userContext.Users.AddAsync(user);
            await _userContext.SaveChangesAsync();
            return user;
        }
    }
}
