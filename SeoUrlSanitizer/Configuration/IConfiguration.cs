namespace SeoUrlSanitizer.Configuration
{
    public interface IConfiguration
    {
        TextCase TextCase { get; set; }

        char StringSeparator { get; set; }

        int? MaxLength { get; set; }

        CharacterReplacement ReplacementCharacters { get; set; }

        bool EnableStopWords { get; set; }
    }
}