using ChatApp.Base;
using ChatApp.Data.Contexts;
using ChatApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Security.Claims;
using System.Net.Http;

namespace ChatApp.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: api/User
        [HttpGet]
        [AllowAnonymous]
        public List<User> GetUsers()
        {
            return _userService.GetAll().ToList();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        //[Authorize(Roles = "admin")]
        [AllowAnonymous]
        public User? GetUser(int id)
        {
            var user = _userService.GetById(id);
            return user;
        }

        // PUT: api/User/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut]
        public void Update(User user)
        {
            _userService.Update(user);
            _userService.SaveChanges();
        }

        // POST: api/User
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<ResultBase> AddUser(User user)
        {
            try
            {
                _userService.Add(user);
                _userService.SaveChanges();                
            }
            catch (Exception ex)
            {
                return ResultBase.GetResultBase((int)HttpStatusCode.BadRequest, ex.Message, false, user);
            }
            return ResultBase.GetResultBase((int)HttpStatusCode.OK, "", true, user); ;


        }

        // DELETE: api/User/5
        [HttpDelete]
        public void DeleteUser(User user)
        {
            _userService.Delete(user);
            _userService.SaveChanges();
        }

        private User GetCurrentUser()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var userClaims = identity.Claims;
                return new User
                {
                    UserName = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value,
                    Role = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value
                };
            }
            return null;
        }
    }
}
