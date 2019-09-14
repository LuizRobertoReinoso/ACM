
using System;
using ACM.BL.Order.Repository;
using FluentAssertions;
using Xunit;

namespace ACM.BL.TESTS.Order.Repository
{
    public class OrderRepositoryShould
    {
        [Fact]
        public static void RetrieveOrderCorrectly()
        {
            var orderRepository = new OrderRepository();

            var valorRetornado = orderRepository.Retrieve(10);

            valorRetornado.OrderId.Should().Be(10);
            valorRetornado.OrderDate.Should().Be(new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                new TimeSpan(7, 0, 0)));
        }
    }
}
