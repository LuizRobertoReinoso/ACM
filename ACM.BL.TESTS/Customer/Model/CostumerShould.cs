using FluentAssertions;
using Xunit;

namespace ACM.BL.TESTS.Customer.Model
{
    public class CostumerShould
    {
        [Theory]
        [InlineData("Luiz Roberto", "Reinoso", "Luiz Roberto Reinoso")]
        [InlineData("Jo�o Lucas", "Farias", "Jo�o Lucas Farias")]
        [InlineData("Bruno Siqueira", "Oliveira", "Bruno Siqueira Oliveira")]
        [InlineData("Jesga", "Bento", "Jesga Bento")]
        public void TerNomeCompletoCorretamente(string nome, string sobrenome, string nomeCompleto)
        {
            var customer = new BL.Customer.Model.Customer {FirstName = nome, LastName = sobrenome };
            customer.FullName.Should().Be(nomeCompleto, $"Nome completo deveria ser {nomeCompleto}");
        }

        [Fact]
        public void ConstarQuantidadeDeInstancias()
        {
            // ReSharper disable once UnusedVariable
            var customer1 = new BL.Customer.Model.Customer
            {
                FirstName="Luiz Roberto",
                LastName = "Reinoso"
            };
            BL.Customer.Model.Customer.InstanceCount += 1;
            // ReSharper disable once UnusedVariable
            var customer2 = new BL.Customer.Model.Customer
            {
                FirstName = "Jo�o Lucas",
                LastName = "Farias"
            };
            BL.Customer.Model.Customer.InstanceCount += 1;
            // ReSharper disable once UnusedVariable
            var customer3 = new BL.Customer.Model.Customer
            {
                FirstName = "Jesga",
                LastName = "Bento"
            };
            BL.Customer.Model.Customer.InstanceCount += 1;

            BL.Customer.Model.Customer.InstanceCount.Should().Be(3, "N�mero de instancias � diferente de 3");
        }

        [Fact]
        public static void ValidateValid()
        {
            var customer = new BL.Customer.Model.Customer
            {
                LastName = "Reinoso",
                EmailAddress = "luiz@sistemasbr.net"
            };

            customer.Validate().Should().BeTrue("As informa��es s�o validas. Retorno esperado � true.");
        }

        [Fact]
        public static void ValidateMissingLastName()
        {
            var customer = new BL.Customer.Model.Customer
            {
                EmailAddress = "luiz@sistemasbr.net"
            };

            customer.Validate().Should().BeFalse("Informa��es s�o infalidas. Retorno esperado � false.");
        }
    }
}
