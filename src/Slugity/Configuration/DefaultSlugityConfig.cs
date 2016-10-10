using Slugity;

namespace SlugityLib.Configuration
{
    public abstract class DefaultSlugityConfig : ISlugityConfig
    {
        protected DefaultSlugityConfig()
        {
            TextCase = TextCase.LowerCase;
            StringSeparator = '-';
            MaxLength = 100;
            ReplacementCharacters = new CharacterReplacement();
            StripStopWords = false;
            StopWords = new StopWords();
        }

        public TextCase TextCase { get; set; }

        public char StringSeparator { get; set; }

        public int? MaxLength { get; set; }

        public CharacterReplacement ReplacementCharacters { get; set; }

        public bool StripStopWords { get; set; }

        public StopWords StopWords { get; set; }
    }
}
