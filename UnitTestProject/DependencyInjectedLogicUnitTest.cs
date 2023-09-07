using Logic;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class DependencyInjectedLogicUnitTest
    {
        private Mock<ILogger> _logger;

        /// <summary>
        /// On every test initialize a new environment (with a new mock)
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            this._logger = new Mock<ILogger>();
        }

        /// <summary>
        /// On every test clenup the environment by deleting all of the mocks data
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            _logger = null;
        }

        [TestMethod]
        public void Multiply_withCorrectNumbersTwoThree_ReturnsCorrectcResult()
        {
            //Arrange
            var numberOne = 2;
            var numberTwo = 3;

            //Right here we can manipulate the mocks.
            var logic = CreateDependencyInjectedLogic();

            //Act

            var result = logic.Multiply(numberOne, numberTwo);

            //Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Multiply_withCorrectNumbersThreeFour_ReturnsCorrectcResult()
        {
            //Arrange
            var numberOne = 3;
            var numberTwo = 4;

            //Right here we can manipulate the mocks.
            var logic = CreateDependencyInjectedLogic();

            //Act

            var result = logic.Multiply(numberOne, numberTwo);

            //Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Multiply_withCorrectNumbers_VerifyLog()
        {
            //Arrange
            var numberOne = 1;
            var numberTwo = 2;

            //Right here we can manipulate the mocks.
            var logic = CreateDependencyInjectedLogic();

            //Act

            var result = logic.Multiply(numberOne, numberTwo);

            //Assert
            _logger.Verify(log=>log.Log(It.Is<LogLevel>(l => l == LogLevel.Information),
            It.IsAny<EventId>(),
            It.Is<It.IsAnyType>((v, t) => v.ToString() == "Start multiplying"),
            It.IsAny<Exception>(),
            It.Is<Func<It.IsAnyType, Exception, string>>((v, t) => true)));
            Assert.AreEqual(2, result);
        }

        /// <summary>
        /// Creates the logic, because the dependency injected 
        /// </summary>
        /// <returns></returns>
        private DependencyInjectedLogic CreateDependencyInjectedLogic()
        {
            return new DependencyInjectedLogic(_logger.Object);
        }

    }
}
