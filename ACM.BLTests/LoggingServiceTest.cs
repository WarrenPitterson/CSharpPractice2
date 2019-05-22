using System;
using System.Collections.Generic;
using ACM.BL;
using Acme.Common;
using Acme.CommonTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "Warrenpitterson@gmail.com",
                FirstName = "Warren",
                LastName = "Pitterson",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);
        }
    }
}
