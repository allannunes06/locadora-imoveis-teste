using homeLocation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeLocation.Services
{
   public interface IUserService
    {
        List<User> GetUsers();
        User AddUsers(User newUsers);
        User DeleteUsers(int id);
        User UpdateUsers(User newUsers);
    }
}
