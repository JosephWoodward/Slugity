using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using SlugityLib.Configuration;

namespace SlugityLib.FormattingTypes
{
    internal class CleanStringFormatter : ISlugFormatter
    {
        private readonly string[] _validStrings = {
            " "
        };

        public string Format(string transformedString, ISlugityConfig config)
        {
            string stripHtml = StripHtml(transformedString.Trim());
            string cleanSpaces = NormaliseSpaces(stripHtml);

            string result = RemoveInvalidChars(cleanSpaces);

            return result;
        }

        private static string StripHtml(string input)
        {
            return Regex.Replace(input, @"<[^>]+>|&nbsp;", "");
        }

        private static string NormaliseSpaces(string input)
        {
            return Regex.Replace(input, @"\s{2,}", " ");
        }

        private string RemoveInvalidChars(string input)
        {
            var builder = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c) || char.IsNumber(c) || _validStrings.Any(x => x.Contains(c.ToString())))
                    builder.Append(c);
            }

            return builder.ToString();
        }
    }
}