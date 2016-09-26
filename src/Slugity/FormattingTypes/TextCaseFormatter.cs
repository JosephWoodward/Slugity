using System.Collections.Generic;
using System.Linq;
using SlugityLib.Configuration;

namespace SlugityLib.FormattingTypes
{
    internal class TextCaseFormatter : ISlugFormatter
    {
        private ISlugityConfig _configuration;

        public string Format(string transformedString, ISlugityConfig config)
        {
            _configuration = config;

            switch (config.TextCase)
            {
                case TextCase.LowerCase:
                    return transformedString.ToLower();
                case TextCase.CamalCase:
                    return ToCamalCaseRevisted(transformedString);
                case TextCase.UpperCase:
                    return transformedString.ToUpper();
                default:
                    return transformedString;
            }
        }

        private string ToCamalCaseRevisted(string input)
        {
            var words = input.Split('-');
            var result = new List<string>();

            foreach (var word in words)
            {
	            if (word.Length == 1)
	            {
		            result.Add(word.ToUpper());
	            }
	            else
	            {
		            result.Add(char.ToUpper(word[0]) + word.Remove(0, 1).ToLower());
	            }
            }

            string output = string.Join("-", result);
            
            return output;
        }

        private static bool IsAllCapitals(string input)
        {
            return input.ToCharArray().All(char.IsUpper);
        }
    }
}