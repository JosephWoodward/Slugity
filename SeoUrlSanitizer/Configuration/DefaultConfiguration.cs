using System.Collections.Generic;

namespace SeoUrlSanitizer.Configuration
{
    public abstract class DefaultConfiguration : IConfiguration
    {
        protected DefaultConfiguration()
        {
            TextCase = TextCase.LowerCase;
            StringSeparator = '-';
            MaxLength = null;
            ReplacementCharacters = new CharacterReplacement();
        }

        public TextCase TextCase { get; set; }

        public char StringSeparator { get; set; }

        public int? MaxLength { get; set; }

        public CharacterReplacement ReplacementCharacters { get; set; }
    }
}