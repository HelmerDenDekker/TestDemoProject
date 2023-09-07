using DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestDemoProject;

namespace UnitTestProject
{
    [TestClass]
    public class UsersLogicQueryTest
    {
        /// <summary>
        /// For a query always use a stub. A stub is lightweight and very fast
        /// </summary>
        [TestMethod]
        public void GetUserInfo_Should_ReturnUser()
        {
            //Arrange
            var userRepository = new UserRepositoryStub();
            userRepository.IsHappy = true;
            var logic = new UserLogic(userRepository);

            //Act
            var result = logic.GetUserInfo(1);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Helmer", result.UserName);
        }

        [TestMethod]
        public void GetUserInfo_Should_ReturnNullWhenUserNotfound()
        {
            //Arrange
            var userRepository = new UserRepositoryStub();
            userRepository.IsHappy = false;
            var logic = new UserLogic(userRepository);

            //Act
            var result = logic.GetUserInfo(2);

            //Assert
            Assert.IsNull(result);
        }

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        /// <summary>
        /// It is also possible to use a Mock and setup a response, but it is really expensive and heavy (60-80 times slower)
        /// </summary>
        [TestMethod]
        public void GetUserInfo_WithMock_Should_ReturnUser()
        {
            //Arrange
            var userRepository = new Mock<IUserRepository>();
            //The setup for a mock is heavier, and looks complicated: Looking for any userId will return the user.
            var user = new User { Id = 1, UserName = "Tejas" };
            userRepository.Setup(repo => repo.FindById(It.IsAny<int>())).Returns(user);

            var logic = new UserLogic(userRepository.Object);

            //Act
            var result = logic.GetUserInfo(1);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Tejas", result.UserName);
        }


    }
}
