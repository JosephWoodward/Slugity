using System.Linq;
using Slugity.Configuration;

namespace Slugity.FormattingTypes
{
    public class StopWordFormatter : ISlugFormatter
    {
        public static string[] StopWordList =
        {
            "the", "a", "an", "am", "is", "can", "and", "or", "but", "while", "if", "then", "thus", "of", "that", "on",
            "for", "he", "we", "which", "her"
        };

        public string Format(string transformedString, ISlugityConfig config)
        {
            if (!config.EnableStopWords) return transformedString;

            string[] inputArray = transformedString.Split();
            return string.Join(config.StringSeparator.ToString(), inputArray.Except(StopWords.StopWordList));
        }
    }
}