using System;
using System.Text;
using SlugityLib.Configuration;

namespace SlugityLib.FormattingTypes
{
    internal class StringSeparatorFormatter : ISlugFormatter
    {
        public string Format(string transformedString, ISlugityConfig config)
        {
            if (string.IsNullOrEmpty(transformedString))
                throw new ArgumentNullException(nameof(transformedString));

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