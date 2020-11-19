using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Moq;
using TestDemoProject;

namespace UnitTestProject
{
    [TestClass]
    public class UserLogicCommandTest
    {
        [TestMethod]
        public void AddUser_should_AddUser()
        {
            //Arrange
            var userRepository = new Mock<IUserRepository>();
            var logic = new UserLogic(userRepository.Object);
            var newUser = new NewUserDto{UserName = "Rogier"};
            //Act
            logic.AddNewUser(newUser);

            //Assert
            userRepository.Verify(repo=>repo.AddUser(It.IsAny<User>()));
        }

    }
}
