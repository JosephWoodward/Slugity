using System.Linq;
using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public class StopWordFormatter : ISlugFormatter
    {
        public static string[] StopWordList =
        {
            "the", "a", "an", "am", "is", "can", "and", "or", "but", "while", "if", "then", "thus", "of", "that", "on",
            "for", "he", "we", "which", "her"
        };

        public string Format(string transformedString, IConfiguration configuration)
        {
            if (!configuration.EnableStopWords) return transformedString;

            string[] inputArray = transformedString.Split();
            return string.Join(configuration.StringSeparator.ToString(), inputArray.Except(StopWords.StopWordList));
        }
    }
}