using CRUDOperations.Data;
using CRUDOperations.DTOs;
using CRUDOperations.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDOperations.Controllers
{
    [ApiController]
    [Route("api")]
    public class LoginController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly TokenService _tokenService;
        public LoginController(AppDbContext context , TokenService tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto login)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u =>
                 u.Email == login.Email &&
                 u.Password == login.Password
            );

            if (user == null)
            {
                return Unauthorized(new { message = "Invalid email or password" });
            }
            var token = _tokenService.CreateService(user);

            return Ok(new
            {
                message = "Login Successgully",
                token = token,
                userId = user.Id,
                email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName
            });
        }
    }
}
