using System.Linq;
using SlugityLib.Configuration;

namespace SlugityLib.FormattingTypes
{
    internal class StopWordFormatter : ISlugFormatter
    {
        public static string[] StopWordList =
        {
            "the", "a", "an", "am", "is", "can", "and", "or", "but", "while", "if", "then", "thus", "of", "that", "on",
            "for", "he", "we", "which", "her"
        };

        public string Format(string transformedString, ISlugityConfig config)
        {
            if (!config.StripStopWords) return transformedString;

            string[] inputArray = transformedString.Split(config.StringSeparator);
            string result = string.Join(config.StringSeparator.ToString(), inputArray.Except(StopWords.StopWordList));

            return result;
        }
    }
}