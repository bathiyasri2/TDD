using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Tests.Business
{
    [TestClass]
    public class HomeBusinessTests
    {
        [TestMethod]
        public void Validate_DataValidation()
        {
            // Arrange
            AdjenHelper homebusiness = new AdjenHelper();

            var result = homebusiness.ValidataData(); 

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Validate_DataValidation_CustomerName_Length()
        {
            // Arrange
            AdjenHelper homebusiness = new AdjenHelper();

            var result = homebusiness.ValidateCustomerNameLength();

            // Assert

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Validate_DataValidation_CustomerName()
        {
            // Arrange
            AdjenHelper homebusiness = new AdjenHelper();

            var result = homebusiness.ValidateCustomerName();

            // Assert
            Assert.IsTrue(result);
        }
    }
}
