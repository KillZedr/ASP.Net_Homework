using Domain;
using Interfaces;
using RealisarionInterfaces;

namespace UserTests
{


    
    public class UnitTest1
    {
       private readonly UserRepository userRepository = new UserRepository();
       

      


        [Fact]
        public void GetLengthListUsers()
        {
            // arrange

            var users = userRepository.GetAllUsers();

            int countUsers = 0;
            // act
            foreach (var user in users)
            {
                countUsers++;
            }

            // assert

            Assert.Equal(countUsers, users.Count);

        }

        [Fact]
        public void GetSumAllUsers()
        {
            // arrange

            var users = userRepository.GetAllUsers();
            int sumUsersInList = users.Sum(u => u.Age);

            int sumUsers = 0;


            // act
            foreach (var user in users)
            {
                sumUsers = sumUsers + user.Age;
            }

            // assert
            Assert.Equal(sumUsersInList, sumUsers);


        }
    }
}