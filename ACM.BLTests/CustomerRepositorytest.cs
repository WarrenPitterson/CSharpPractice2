using System;
using System.Collections.Generic;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerRepositorytest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "Warrenpittersondev@gmail.com",
                FirstName = "Warren",
                LastName = "Pitterson"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

        }


        [TestMethod]
        public void RetrieveExisistingWithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "Warrenpittersondev@gmail.com",
                FirstName = "Warren",
                LastName = "Pitterson",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                AddressType = 1,
                StreetLine1 = "11 Dewy Meadow Road",
                StreetLine2 = "Salford",
                City = "Manchester",
                PostCode = "M6 6GT",
                Country = "United Kingdom"
                     },
                    new Address()
                    {
                AddressType = 2,
                StreetLine1 = "12 Eagle Drive",
                StreetLine2 = "Salford",
                City = "Manchester",
                PostCode = "M6 6EY",
                Country = "United Kingdom"
                    }
                }
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);


            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostCode, actual.AddressList[i].PostCode);

            }

        }

    }
}

