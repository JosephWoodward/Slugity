using System.Text.RegularExpressions;
using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public class CleanStringFormatter : ISlugFormatter
    {
        public string Format(string transformedString, IConfiguration configuration)
        {
            string stripHtml = Regex.Replace(transformedString, @"<[^>]+>|&nbsp;", "").Trim();
            string cleanSpaces = Regex.Replace(stripHtml, @"\s{2,}", " ");

            return cleanSpaces;
        }
    }
}