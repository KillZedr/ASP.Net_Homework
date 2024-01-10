using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Interfaces
{
    public interface IUserRepositiry
    {
        List<User> GetAllUsers();
        void AddUser(User userNew);
        
        User GetUser(string name);
        void RemoveUser(User userToDelete);
    }
}
