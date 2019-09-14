using FluentAssertions;
using Xunit;

namespace ACM.BL.TESTS.Model
{
    public class CostumerShould
    {
        [Theory]
        [InlineData("Luiz Roberto", "Reinoso", "Luiz Roberto Reinoso")]
        [InlineData("João Lucas", "Farias", "João Lucas Farias")]
        [InlineData("Bruno Siqueira", "Oliveira", "Bruno Siqueira Oliveira")]
        [InlineData("Jesga", "Bento", "Jesga Bento")]
        public void TerNomeCompletoCorretamente(string nome, string sobrenome, string nomeCompleto)
        {
            var customer = new Customer.Model.Customer {FirstName = nome, LastName = sobrenome };
            customer.FullName.Should().Be(nomeCompleto, $"Nome completo deveria ser {nomeCompleto}");
        }

        [Fact]
        public void ConstarQuantidadeDeInstancias()
        {
            // ReSharper disable once UnusedVariable
            var customer1 = new Customer.Model.Customer
            {
                FirstName="Luiz Roberto",
                LastName = "Reinoso"
            };
            Customer.Model.Customer.InstanceCount += 1;
            // ReSharper disable once UnusedVariable
            var customer2 = new Customer.Model.Customer
            {
                FirstName = "João Lucas",
                LastName = "Farias"
            };
            Customer.Model.Customer.InstanceCount += 1;
            // ReSharper disable once UnusedVariable
            var customer3 = new Customer.Model.Customer
            {
                FirstName = "Jesga",
                LastName = "Bento"
            };
            Customer.Model.Customer.InstanceCount += 1;

            Customer.Model.Customer.InstanceCount.Should().Be(3, "Número de instancias é diferente de 3");
        }

        [Fact]
        public static void ValidateValid()
        {
            var customer = new Customer.Model.Customer
            {
                LastName = "Reinoso",
                EmailAddress = "luiz@sistemasbr.net"
            };

            customer.Validate().Should().BeTrue("As informações são validas. Retorno esperado é true.");
        }

        [Fact]
        public static void ValidateMissingLastName()
        {
            var customer = new Customer.Model.Customer
            {
                EmailAddress = "luiz@sistemasbr.net"
            };

            customer.Validate().Should().BeFalse("Informações são infalidas. Retorno esperado é false.");
        }
    }
}
