namespace Slugity.Configuration
{
    public abstract class DefaultSlugityConfig : ISlugityConfig
    {
        protected DefaultSlugityConfig()
        {
            TextCase = TextCase.LowerCase;
            StringSeparator = '-';
            MaxLength = 100;
            ReplacementCharacters = new CharacterReplacement();
            EnableStopWords = false;
        }

        public TextCase TextCase { get; set; }

        public char StringSeparator { get; set; }

        public int? MaxLength { get; set; }

        public CharacterReplacement ReplacementCharacters { get; set; }

        public bool EnableStopWords { get; set; }
    }
}
