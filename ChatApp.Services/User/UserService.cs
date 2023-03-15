using ChatApp.Data.Contexts;
using ChatApp.Repository;
using ChatApp.Repository.Base;
using ChatApp.Services.Base;
using System.Linq.Expressions;

namespace ChatApp.Services
{
    public class UserService : BaseService<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService( IBaseRepository<User> baseRepository,
            IUserRepository userRepository) : base(baseRepository) 
        {
            _userRepository = userRepository;
        }
    }
}
