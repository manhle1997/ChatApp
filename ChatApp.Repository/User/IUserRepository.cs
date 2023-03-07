using ChatApp.Data.Contexts;
using ChatApp.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {

    }
}
