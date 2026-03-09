using Microsoft.AspNetCore.Mvc;

namespace CRUDOperations.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class LogoutController : Controller
    {
        [HttpPost("logout")]
        public IActionResult UserLogout()
        {
            return Ok(new
            {
                message = "Logged Out Successfully"
            });
        }
    }
}
