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

        [Fact]
        public static void SaveTastValid()
        {
            var productRepository = new ProductRepository();
            var updateProduct = new BL.Product.Model.Product(2)
            {
                CurrentPrice = 3,
                ProductName = "Coxinha",
                ProductDescription = "Massa de mandioca e recheio de frango",
                HasChanges = true
            };

            productRepository.Save(updateProduct).Should().BeTrue();
        }

        [Fact]
        public static void SaveTastMissingPrice()
        {
            var productRepository = new ProductRepository();
            var updateProduct = new BL.Product.Model.Product(2)
            {
                CurrentPrice = null,
                ProductName = "Coxinha",
                ProductDescription = "Massa de mandioca e recheio de frango",
                HasChanges = true
            };

            productRepository.Save(updateProduct).Should().BeFalse();
        }
    }
}
