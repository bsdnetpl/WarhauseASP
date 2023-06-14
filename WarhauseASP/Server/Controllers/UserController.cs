using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WarhauseASP.Server.DB;
using WarhauseASP.Server.Service;
using WarhauseASP.Shared;

namespace WarhauseASP.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ConnectionDB _connection;
        private readonly IRole _role;


        public UserController(ConnectionDB connection, IRole role)
        {
            _connection = connection;
            _role = role;
        }

        [HttpPost("AddRole")]
        public async Task<IActionResult> AddRole(Guid UserId, string Role)
        {
      
            if (UserId!= null)
            {
                var ret = _role.AddRole(UserId, Role);
                if (ret == 1)
                {
                    return Ok("Role add!");
                }
                else
                {
                    return BadRequest("No role added !");
                }
            }
            return Ok("this user is in Role table");
        }
    }
}
