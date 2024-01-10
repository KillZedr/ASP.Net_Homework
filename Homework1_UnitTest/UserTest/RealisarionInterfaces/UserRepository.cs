using Domain;
using Interfaces;

namespace RealisarionInterfaces
{
    public class UserRepository : IUserRepositiry
    {

        private readonly List<User> _user = new List<User>();

        public UserRepository()
        {
            _user.Add(new User()
            {
                Name = "Ilia",
                Id = "Tsarikov",
                Age = 22
            });
            _user.Add(new User()
            {
                Name = "Dmitriy",
                Id = "Protko",
                Age = 27
            });
            _user.Add(new User()
            {
                Name = "Arsen",
                Id = "Alfimov",
                Age = 24
            });
            _user.Add(new User()
            {
                Name = "Artur",
                Id = "Gavrosik",
                Age = 25
            });
            _user.Add(new User()
            {
                Name = "Ilia",
                Id = "Tsar",
                Age = 25
            });
        }
        public void AddUser(User userNew) => _user.Add(userNew);

        public List<User> GetAllUsers()
        {
            return _user;
        }

        public User GetUser(string name)
        {
            return _user.FirstOrDefault(u => u.Name == name)!;
        }

        public void RemoveUser(User userToDelete)
        {
            _user.Remove(userToDelete);
        }
    }
}
