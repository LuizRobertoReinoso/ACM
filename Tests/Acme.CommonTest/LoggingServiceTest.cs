using System.Collections.Generic;
using ACM.BL.Customer.Model;
using ACM.BL.Product.Model;
using Acme.Common;
using Xunit;

namespace Acme.CommonTest
{
    public class LoggingServiceTest
    {
        [Fact]
        public static void WriteToFileTest()
        {
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                FirstName = "Luiz Roberto",
                LastName = "Reinoso",
                EmailAddress = "luiz@sistemasbr.net",
                AddressList = null
            };

            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Bolo",
                ProductDescription = "Te deixa esperando",
                CurrentPrice = 10M
            };

            changedItems.Add(product);

            LoggingService.WriteToFile(changedItems);



        }
    }
}
