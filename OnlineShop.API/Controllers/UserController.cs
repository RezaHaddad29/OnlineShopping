using Microsoft.AspNetCore.Mvc;
using OnlineShop.Core.Entities;

namespace OnlineShop.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(new { Message = "List of users" });
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            return Ok(new { Message = $"User {id}" });
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            return Created($"api/users/{user.ID}", user);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User user)
        {
            return Ok(new { Message = $"User {id} updated" });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            return Ok(new { Message = $"User {id} deleted" });
        }
    }
}
