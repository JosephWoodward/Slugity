using System;
using System.Text;
using static System.Char;

namespace SeoUrlSanitizer
{
    public class StringToUrlSanitizer
    {
        private const int UrlMaxLenth = 60;

        // https://moz.com/blog/15-seo-best-practices-for-structuring-urls
        public static string Sanitize(string input)
        {
            if (string.IsNullOrEmpty(input.Trim()))
                return input;

            bool lastCharIsSeperator = false;
            bool isHtml = false;
            var result = new StringBuilder();
            char c;
            foreach (char currentChar in input)
            {
                c = currentChar;
                int index = input.IndexOf(c);

                if (c == '<')
                {
                    isHtml = true;
                    continue;
                }
                if (c == '>')
                {
                    isHtml = false;
                    continue;
                }

                if (isHtml) continue;

                if (char.IsWhiteSpace(c) || c == '-')
                {
                    if (!lastCharIsSeperator) result.Append('-');
                    lastCharIsSeperator = true;
                    continue;
                }

                lastCharIsSeperator = false;

                result.Append(ToLower(c));


            }

            return result.ToString();
        }

        public static string Sanitize(string input, bool removeStopWords)
        {
            return "";
        }
    }
}
