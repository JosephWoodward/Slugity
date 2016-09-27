using System;
using System.Collections.Generic;
using SlugityLib.Configuration;

namespace SlugityLib.FormattingTypes
{
    internal class ReplaceCharactersFormatter : ISlugFormatter
    {
        public string Format(string transformedString, ISlugityConfig config)
        {
            if (config.ReplacementCharacters == null)
                throw new ArgumentNullException(nameof(config.ReplacementCharacters));

            foreach (KeyValuePair<string, string> characters in config.ReplacementCharacters.ReplacementCharacters)
            {
                transformedString = transformedString.Replace(characters.Key, characters.Value);
            }

            return transformedString;
        }
    }
}