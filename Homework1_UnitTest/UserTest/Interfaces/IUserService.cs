using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        User FindOldUser();
        User FindUserByName(User userFind);
        List<string> GetDuplicateNames();
    }
}
