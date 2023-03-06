using ChatApp.Data.Contexts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ChatApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IConfiguration _config;
        public LoginController(IConfiguration config)
        {
            _config = config;
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login(UserLogin userLogin)
        {
            var user = Authenticate(userLogin);
            if (user != null) {
                var token = Generate(user);
                return Ok(token);
            }
            return NotFound("User not found");
        }
        private string Generate(User user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]??""));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claimns = new[]
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Role, user.Role)
            };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"], claimns,expires: DateTime.Now.AddMinutes(30), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        private User Authenticate(UserLogin userLogin)
        {
            var currentUser = UserConstants.users.FirstOrDefault(u => u.UserName == userLogin.UserName && u.Password == userLogin.Password);
            if (currentUser != null)
            {
                return currentUser;
            }
            return null;
        }

    }
}
