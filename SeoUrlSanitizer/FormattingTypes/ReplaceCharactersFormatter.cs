using System.Collections.Generic;
using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.FormattingTypes
{
    public class ReplaceCharactersFormatter : ISlugFormatter
    {
        public string Format(string transformedString, IConfiguration configuration)
        {
            foreach (KeyValuePair<string, string> characters in configuration.ReplacementCharacters.ReplacementCharacters)
            {
                transformedString = transformedString.Replace(characters.Key, characters.Value);
            }

            return transformedString;
        }
    }
}