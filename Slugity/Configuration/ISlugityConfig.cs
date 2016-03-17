namespace Slugity.Configuration
{
    public interface ISlugityConfig
    {
        TextCase TextCase { get; set; }

        char StringSeparator { get; set; }

        int? MaxLength { get; set; }

        CharacterReplacement ReplacementCharacters { get; set; }

        bool EnableStopWords { get; set; }
    }
}