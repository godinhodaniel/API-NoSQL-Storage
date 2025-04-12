using Microsoft.AspNetCore.Mvc;
using UserApi.Models;
using UserApi.Services;

namespace UserApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult<List<User>> Get() => _userService.Get();

        [HttpGet("{email}")]
        public ActionResult<User> GetByEmail(string email)
        {
            var user = _userService.GetByEmail(email);
            if (user == null) return NotFound();
            return user;
        }

        [HttpPost]
        public ActionResult<User> Create(User user)
        {
            _userService.Create(user);
            return CreatedAtAction(nameof(GetByEmail), new { email = user.Email }, user);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, User userIn)
        {
            var user = _userService.Get().FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();

            _userService.Update(id, userIn);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            var user = _userService.Get().FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();

            _userService.Remove(id);
            return NoContent();
        }
    }
}