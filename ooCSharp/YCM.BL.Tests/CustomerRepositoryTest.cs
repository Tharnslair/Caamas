using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YCM.BL;

namespace YCM.BL.Tests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            // Arrange
            var cr = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "chorn@corsec.net",
                FirstName = "Corran",
                LastName = "Horn"
            };

            // Act
            var actual = cr.Retrieve(1);

            // Assert
            // Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }
    }
}
