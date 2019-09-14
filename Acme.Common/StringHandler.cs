using System.Linq;

namespace Acme.Common
{
    public class StringHandler
    {
        public string InsertSpaces(string source) => 
            string.IsNullOrWhiteSpace(source)
            ? string.Empty
            : source.Aggregate(string.Empty,
                (current, letter) => current + (char.IsUpper(letter) ? $" {letter}" : letter.ToString()));
    }
}
