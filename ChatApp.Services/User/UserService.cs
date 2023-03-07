using ChatApp.Data.Contexts;
using ChatApp.Repository;

namespace ChatApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<User> Add(User model)
        {
            return _userRepository.Add(model);
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
        }

        public Task<IEnumerable<User>> GetAll()
        {
            return _userRepository.GetAll();
        }

        public Task<User> GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public Task<int> SaveChanges()
        {
            return _userRepository.SaveChanges();
        }

        public Task<int> Update(int id, User model)
        {
            return _userRepository.Update(id, model);
        }
    }
}
