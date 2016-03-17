using System.Text.RegularExpressions;
using Slugity.Configuration;

namespace Slugity.FormattingTypes
{
    public class CleanStringFormatter : ISlugFormatter
    {
        public string Format(string transformedString, ISlugityConfig config)
        {
            string stripHtml = Regex.Replace(transformedString, @"<[^>]+>|&nbsp;", "").Trim();
            string cleanSpaces = Regex.Replace(stripHtml, @"\s{2,}", " ");

            return cleanSpaces;
        }
    }
}