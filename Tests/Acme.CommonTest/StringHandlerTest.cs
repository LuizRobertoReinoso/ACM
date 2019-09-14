using Acme.Common;
using FluentAssertions;
using Xunit;

namespace Acme.CommonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpacesTestValid() =>
            "ProdutoJunto".InsertSpaces().Should().Be("Produto Junto");

        [Fact]
        public void InsertSpacesTestWithExistingSpace() =>
            "Produto Separado".InsertSpaces().Should().Be("Produto Separado");
    }
}
