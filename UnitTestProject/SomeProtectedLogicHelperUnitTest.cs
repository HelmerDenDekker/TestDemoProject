using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.Helpers;

namespace UnitTestProject
{

    [TestClass]
    public class SomeProtectedLogicHelperUnitTest
    {
        private ExposedSomeProtectedLogicHelper _someProtectedLogicHelper;

        /// <summary>
        /// Initialize the test with a new ExposedSomeProtectedLogicHelper
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            _someProtectedLogicHelper = CreateSomeProtectedLogicHelper();
        }

        [TestMethod]
        public void IsDenumenatorNonZero_WithNonZeroInput_ReturnsTrue()
        {
            // Arrange
            var denumerator = 1;

            // Act
            var result = _someProtectedLogicHelper.IsDenumenatorNonZero(denumerator);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsDenumenatorNonZero_WithZeroInput_ReturnsFalse()
        {
            // Arrange
            var denumerator = 0;

            // Act
            var result = _someProtectedLogicHelper.IsDenumenatorNonZero(denumerator);

            // Assert
            Assert.IsFalse(result);
        }

        /// <summary>
        /// Creates the logic, because the dependency injected 
        /// </summary>
        /// <returns></returns>
        private ExposedSomeProtectedLogicHelper CreateSomeProtectedLogicHelper()
        {
            return new ExposedSomeProtectedLogicHelper();
        }
    }
}
