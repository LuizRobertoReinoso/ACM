
namespace Acme.Common
{
    public class StringHandler
    {
        public string InsertSpaces(string source)
        {
            if (string.IsNullOrWhiteSpace(source)) return string.Empty;

            var result = string.Empty;
            foreach (var letter in source)
            {
                if (char.IsUpper(letter))
                {
                    result = result.Trim();
                    result += $" {letter}";
                }
                else
                    result += letter;
            }

            return result.Trim();
        }
    }
}
