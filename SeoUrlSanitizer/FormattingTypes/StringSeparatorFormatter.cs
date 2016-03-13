using System.Text;
using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public class StringSeparatorFormatter : ISlugFormatter
    {
        public string Format(string transformedString, IConfiguration configuration)
        {
            if (configuration.StringSeparator == null) return transformedString;

            bool lastCharIsSeperator = false;

            var result = new StringBuilder();

            bool isWhiteSpace;
            foreach (char currentChar in transformedString)
            {
                isWhiteSpace = char.IsWhiteSpace(currentChar);
                if (isWhiteSpace && transformedString.IndexOf(currentChar) == transformedString.Length - 1)
                    break;

                if (char.IsWhiteSpace(currentChar) || currentChar == '-')
                {
                    if (!lastCharIsSeperator) result.Append('-');
                    lastCharIsSeperator = true;
                    continue;
                }

                lastCharIsSeperator = false;
                result.Append(currentChar);
            }

            return result.ToString();
        }
    }
}