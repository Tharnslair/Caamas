using System;
using System.Collections.Generic;
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
            //-- Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            //-- Act
            var actual = customerRepository.Retrieve(1);

            //-- Assert
            //Assert.AreEqual(expected, actual);

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithEmail()
        {
            // Arrange 
            var cr = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "chorn@corsec.net",
                FirstName = "Corran",
                LastName = "Horn",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Twin Suns Blvd",
                        StreetLine2 = "Sandlot 223",
                        City = "Anchorhead",
                        State = "Tatooine",
                        Country = "Evil Empire",
                        PostalCode = "144"
                    },

                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "123 Yoda Way",
                        City = "TheSwamp",
                        State = "Dagobah",
                        Country = "Evil Empire",
                        PostalCode = "146"
                    }
                }

            };

            // Act
            var actual = cr.Retrieve(1);

            // Assert
            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);                
            }
        }
    }
}
