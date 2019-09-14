using ACM.BL.Product.Repository;
using FluentAssertions;
using Xunit;

namespace ACM.BL.TESTS.Product.Repository
{
    public class ProductRepositoryShould
    {
        [Fact]
        public static void RetrieveCorrectly()
        {
            var repositoryProduct = new ProductRepository();

            var produtoRetornado = repositoryProduct.Retrieve(2);

            produtoRetornado.ProductId.Should().Be(2);
            produtoRetornado.CurrentPrice.Should().Be(3M);
            produtoRetornado.ProductName.Should().Be("Coxinha");
            produtoRetornado.ProductDescription.Should().Be("Massa de mandioca e recheio de flango");
        }
    }
}
