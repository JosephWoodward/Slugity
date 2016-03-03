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

            bool lastCharWasWhiteSpace = false;
            var result = new StringBuilder();
            char c;
            foreach (char currentChar in input)
            {
                c = currentChar;
                int index = input.IndexOf(c);
                if (index < 0) continue;

                if (char.IsWhiteSpace(c) || c == '-')
                {
                    /*if (!lastCharWasWhiteSpace)*/
                        result.Append('-');

                    lastCharWasWhiteSpace = true;
                    continue;
                }


                if (c != ' ')
                    result.Append(ToLower(c));

                /*input = input.Remove(ix, 1);*/
            }

            return result.ToString();
        }

        public static string Sanitize(string input, bool removeStopWords)
        {
            return "";
        }
    }
}
