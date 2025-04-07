using Microsoft.AspNetCore.Mvc;
using SimpleUserAPI.Models;

namespace SimpleUserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private static List<User> users = new List<User>();

        // GET: api/user
        [HttpGet]
        public IActionResult GetUsers() => Ok(users);

        // GET: api/user/1
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();
            return Ok(user);
        }

        // POST: api/user
        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            user.Id = users.Count > 0 ? users.Max(u => u.Id) + 1 : 1;
            users.Add(user);
            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        // PUT: api/user/1
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, User updatedUser)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();
            user.Name = updatedUser.Name;
            user.Email = updatedUser.Email;
            return NoContent();
        }

        // DELETE: api/user/1
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user == null) return NotFound();
            users.Remove(user);
            return NoContent();
        }
    }
}