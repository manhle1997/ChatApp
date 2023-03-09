using ChatApp.Data.Contexts;
using ChatApp.Repository.Base;

namespace ChatApp.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ChatAppContext context) : base(context)
        {

        }
    }
}
