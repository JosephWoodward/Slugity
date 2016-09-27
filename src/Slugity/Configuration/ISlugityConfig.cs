namespace SlugityLib.Configuration
{
    public interface ISlugityConfig
    {
        /// <summary>
        /// Text case of slug generated
        /// </summary>
        TextCase TextCase { get; set; }

        /// <summary>
        /// Character used to separate slug
        /// </summary>
        char StringSeparator { get; set; }

        /// <summary>
        /// Optional maximum length of slug string. Set as null for unlimited
        /// </summary>
        int? MaxLength { get; set; }

        /// <summary>
        /// Collection of characters or words to be replaced within final slug
        /// </summary>
        CharacterReplacement ReplacementCharacters { get; set; }

        /// <summary>
        /// Strip or leave stop words in your final slug
        /// </summary>
        bool StripStopWords { get; set; }
    }
}