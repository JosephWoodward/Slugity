using SeoUrlSanitizer.Configuration;

namespace SeoUrlSanitizer.Tests
{
    public class CustomConfiguration : IConfiguration
    {
        public CustomConfiguration()
        {
            TextCase = TextCase.LowerCase;
            EnableStopWords = false;
            MaxLength = 30;
            StringSeparator = ' ';
            ReplacementCharacters = new CharacterReplacement();
        }

        public TextCase TextCase { get; set; }

        public char StringSeparator { get; set; }

        public int? MaxLength { get; set; }

        public CharacterReplacement ReplacementCharacters { get; set; }

        public bool EnableStopWords { get; set; }
    }
}