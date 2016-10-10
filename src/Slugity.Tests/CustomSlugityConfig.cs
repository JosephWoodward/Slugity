using Slugity;
using SlugityLib.Configuration;

namespace SlugityLib.Tests
{
    public class CustomSlugityConfig : ISlugityConfig
    {
        public CustomSlugityConfig()
        {
            TextCase = TextCase.LowerCase;
            StripStopWords = false;
            MaxLength = 30;
            StringSeparator = ' ';
            ReplacementCharacters = new CharacterReplacement();
        }

        public TextCase TextCase { get; set; }

        public char StringSeparator { get; set; }

        public int? MaxLength { get; set; }

        public CharacterReplacement ReplacementCharacters { get; set; }

        public bool StripStopWords { get; set; }

        public StopWords StopWords { get; set; }
    }
}