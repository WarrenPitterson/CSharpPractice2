using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValidity()
        {
            Customer customer = new Customer
            {
                FirstName = "Warren",
                LastName = "Pitterson"
            };

            string expected = "Pitterson, Warren";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void FullNameButTheLastnameIsEmpty()
        {
            Customer customer = new Customer
            {
                LastName = "Pitterson"
            };

            string expected = "Pitterson";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameButTheFirstnameIsEmpty()
        {
            Customer customer = new Customer
            {
                FirstName = "Warren"
            };

            string expected = "Warren";

            string actual = customer.FullName;

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void StaticTest()
        {
            var c1 = new Customer();
            c1.FirstName = "Warren";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c1.FirstName = "Liam";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c1.FirstName = "Anser";
            Customer.InstanceCount += 1;

            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            var customer = new Customer
            {
                LastName = "Pitterson",
                EmailAddress = "warrenpittersondev@gmail.com"
            };

            var expected = true;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissLastName()
        {
            var customer = new Customer
            {
                LastName = "Pitterson",
            };

            var expected = false;

            var actual = customer.Validate();

            Assert.AreEqual(expected, actual);
        }


    }
}
