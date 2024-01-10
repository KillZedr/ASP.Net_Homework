using Domain;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealisarionInterfaces
{
    public class UserService : IUserService
    {

        private readonly IUserRepositiry _userRepository;
        public UserService(IUserRepositiry userRepositiry)
        {
            _userRepository = userRepositiry;
        }
        public User FindOldUser()
        {
            var users = _userRepository.GetAllUsers();
            var userMostOld = new User();

            foreach (var user in users)
            {
                if (user.Age > userMostOld.Age)
                { userMostOld = user; }
            }
            return userMostOld;
        }

        public User FindUserByName(User userFind)
        {
            return _userRepository.GetUser(userFind.Name);
        }

        public List<User> GetAllUsers()
        {
             return _userRepository.GetAllUsers();
        }

        public List<string> GetDuplicateNames()
        {
            return _userRepository.GetAllUsers()
                    .GroupBy(u => u.Name)
                    .Where(g => g.Count() > 1)
                    .Select(g => g.Key)
                    .ToList();
        }
    }
}
