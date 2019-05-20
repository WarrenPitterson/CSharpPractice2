using System;
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
                EmailAddress = "Warrenpitterson@gmail.com",
                FirstName = "Warren",
                LastName = "Pitterson"
            };

            var actual = customerRepository.Retrieve(1);

            Assert.AreEqual(expected, actual);
            }
        
    }
}
