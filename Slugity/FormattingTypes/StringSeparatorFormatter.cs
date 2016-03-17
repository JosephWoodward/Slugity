using System.Text;
using Slugity.Configuration;

namespace Slugity.FormattingTypes
{
    public class StringSeparatorFormatter : ISlugFormatter
    {
        public string Format(string transformedString, ISlugityConfig config)
        {
/*
            if (config.StringSeparator == null) return transformedString;
*/

            bool lastCharIsSeperator = false;

            var result = new StringBuilder();

            bool isWhiteSpace;
            foreach (char currentChar in transformedString)
            {
                isWhiteSpace = char.IsWhiteSpace(currentChar);
                if (isWhiteSpace && transformedString.IndexOf(currentChar) == transformedString.Length - 1)
                    break;

                if (char.IsWhiteSpace(currentChar) || currentChar == config.StringSeparator)
                {
                    if (!lastCharIsSeperator) result.Append(config.StringSeparator);
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