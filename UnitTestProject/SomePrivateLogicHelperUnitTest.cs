﻿using Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.Helpers;

namespace UnitTestProject
{
    [TestClass]
    public class SomePrivateLogicHelperUnitTest
    {
        private PrivateObject _somePrivateLogicHelper;

        /// <summary>
        /// Initialize each test with a new SomePrivateLogicHelper PrivateObject
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            _somePrivateLogicHelper = CreateSomePrivateLogicHelper();
        }

        [TestMethod]
        public void IsDenumenatorNonZero_WithNonZeroInput_ReturnsTrue()
        {
            // Arrange
            var denumerator = 1;

            // Act
            double parameters = denumerator;
            var result = _somePrivateLogicHelper.Invoke("IsDenumenatorNonZero",parameters);

            // Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void IsDenumenatorNonZero_WithZeroInput_ReturnsFalse()
        {
            // Arrange
            var denumerator = 0;

            // Act
            double parameters = denumerator;
            var result = _somePrivateLogicHelper.Invoke("IsDenumenatorNonZero", parameters);

            // Assert
            Assert.AreEqual(false, result);
        }

        /// <summary>
        /// Create a shared method for creating a PrivateObject for enetering private methods in SomePrivateLogicHelper
        /// </summary>
        /// <returns></returns>
        private PrivateObject CreateSomePrivateLogicHelper()
        {
            var somePrivateLogicHelper = new SomePrivateLogicHelper();
            PrivateObject privateHelper = new PrivateObject(somePrivateLogicHelper);
            return privateHelper;
        }
    }
}
