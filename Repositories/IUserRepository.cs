using UserApi.Models;

namespace UserApi.Repositories
{
    public interface IUserRepository
    {
        Task<User> CreateUser(User user);
    }
}
