using RealisarionInterfaces;

namespace ConsoleUI2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userRepository = new UserRepository();
            var userServise = new UserService(userRepository);

            var OldUser = userServise.FindOldUser();
            Console.WriteLine(OldUser);

            var DublicateNames = userServise.GetDuplicateNames();
            foreach (var d in DublicateNames)
            {
                Console.WriteLine(d);
            }
        }
    }
}
