using Acme.Common;
using FluentAssertions;
using Xunit;

namespace Acme.CommonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesTestValid()
        {
            var handler = new StringHandler();
            handler.InsertSpaces("ProdutoJunto").Should().Be("Produto Junto");
        }

        [Fact]
        public void InsertSpacesTestWithExistingSpace()
        {
            var handler = new StringHandler();
            handler.InsertSpaces("Produto Separado").Should().Be("Produto Separado");
        }
    }
}
