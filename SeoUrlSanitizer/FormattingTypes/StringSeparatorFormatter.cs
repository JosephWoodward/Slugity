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
            foreach (char currentChar in transformedString)
            {
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