using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using static System.Char;

namespace SlugityLib
{
    internal class StringToUrlSanitizer
    {
        /// <summary>GenerateSlug input string to URL</summary>
        /// <param name="input">Input string</param>
        /// <returns>Sanitized output string</returns>
        public static string Sanitize(string input)
        {
            if (string.IsNullOrEmpty(input.Trim()))
                return input;

            var result = SanitizeString(input).ToString();

            result = Regex.Replace(result, "[^\\s-0-9a-zA-Z]+", "");
            return result;
        }

        /// <summary>GenerateSlug input string to URL, removing stop words</summary>
        /// <param name="input">Input string</param>
        /// <returns>Sanitized output string with stop words removed</returns>
        public static string SanitizeAndRemoveStopWords(string input)
        {
            if (string.IsNullOrEmpty(input.Trim()))
                return input;

            var result = SanitizeString(input).ToString();
            string[] formatted = result.Split('-');

            return string.Join("-", formatted.Except(StopWords.StopWordList));
        }

        // https://moz.com/blog/15-seo-best-practices-for-structuring-urls
        private static StringBuilder SanitizeString(string input)
        {
            bool lastCharIsSeperator = false;
            bool isHtml = false;
            var result = new StringBuilder();

            input = DiacriticalFoldingService.FoldDiacriticals(input);
            foreach (char currentChar in input)
            {
                if (currentChar == '<')
                {
                    isHtml = true;
                    continue;
                }
                if (currentChar == '>')
                {
                    isHtml = false;
                    continue;
                }

                if (isHtml) continue;

                if (char.IsWhiteSpace(currentChar) || currentChar == '-')
                {
                    if (!lastCharIsSeperator) result.Append('-');
                    lastCharIsSeperator = true;
                    continue;
                }

                lastCharIsSeperator = false;

                result.Append(ToLower(currentChar));
            }

            return result;
        }
    }
}