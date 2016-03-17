using Slugity.Configuration;

namespace Slugity.Tests
{
    public class CustomSlugityConfig : ISlugityConfig
    {
        public CustomSlugityConfig()
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