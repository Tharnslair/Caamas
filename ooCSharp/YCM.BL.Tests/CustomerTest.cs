using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YCM.BL;

namespace YCM.BL.Tests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange

            Customer customer = new Customer();

            customer.FirstName = "Luke";
            customer.LastName = "Skywalker";

            // string expected = "Luke Skywalker"; this breaks it
            string expected = "Skywalker, Luke";

            // Act

            string actual = customer.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.LastName = "Skywalker";
            string expected = "Skywalker";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer();
            customer.FirstName = "Luke";
            string expected = "Luke";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void staticTest()
        {
            // Arrange
            var c1 = new Customer();
            c1.FirstName = "Han";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Lando";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Chewbacca";
            Customer.InstanceCount += 1;

            // Act

            // Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer();
            customer.LastName = "Antilles";
            customer.EmailAddress = "wantilles@coreilla.me";

            var expected = true;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer();
            customer.EmailAddress = "wantilles@coreilla.me";

            var expected = false;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
