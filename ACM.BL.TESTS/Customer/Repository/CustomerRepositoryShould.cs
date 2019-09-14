using ACM.BL.Customer.Repository;
using FluentAssertions;
using Xunit;

namespace ACM.BL.TESTS.Customer.Repository
{
    public class CustomerRepositoryShould
    {
        [Fact]
        public static void RetrieveValide()
        {
            var customerRepository = new CustomerRepository();

            var valorRetornado = customerRepository.Retrieve(1);
            valorRetornado.CustomerId.Should().Be(1);
            valorRetornado.FirstName.Should().Be("Luiz Roberto");
            valorRetornado.LastName.Should().Be("Reinoso");
            valorRetornado.EmailAddress.Should().Be("luiz@sistemasbr.net");

        }

        [Fact]
        public static void RetrieveExistingWithAddress()
        {
            var customerRepository = new CustomerRepository();

            var valorRetornado = customerRepository.Retrieve(1);

            valorRetornado.EmailAddress.Should().Be("luiz@sistemasbr.net");
            valorRetornado.FirstName.Should().Be("Luiz Roberto");
            valorRetornado.LastName.Should().Be("Reinoso");
            valorRetornado.AddressList.Count.Should().Be(2);
            valorRetornado.AddressList[0].AddressType.Should().Be(1);
            valorRetornado.AddressList[1].AddressType.Should().Be(2);
        }
    }
}
