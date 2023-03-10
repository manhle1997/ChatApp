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

        public void Add(User model)
        {
            _userRepository.Add(model);
        }

        public void Delete(User model)
        {
            _userRepository.Delete(model);
        }

        public IQueryable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public User? GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public int SaveChanges()
        {
            return _userRepository.SaveChanges();
        }

        public void Update(User model)
        {
            _userRepository.Update(model);
        }
    }
}
