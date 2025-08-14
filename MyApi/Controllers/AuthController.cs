using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyApi.Interfaces;
using MyApi.Models;

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var user = _authService.ValidateUser(request.Username, request.Password);

            if (user == null)
                return Unauthorized();

            var token = _authService.GenerateJwtToken(user);
            return Ok(new { token });
        }

        [Authorize]
        [HttpGet("secure-data")]
        public IActionResult SecureData()
        {
            return Ok(new { Message = "You are authorized!", User = User.Identity?.Name });
        }
    }
}
