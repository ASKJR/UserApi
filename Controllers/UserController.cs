using Microsoft.AspNetCore.Mvc;
using UserApi.Models;
using UserApi.Repositories;

namespace UserApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(
            IUserRepository userRepository
        )
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            var createdUser = await _userRepository.CreateUser(user);
            return Ok(createdUser);
        }
    }
}
